﻿using PED_GEN.Controllers;
using PED_GEN.ExtModel;
using PED_GEN.Models;
using PED_GEN.RealmConnection;
using Realms;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PED_GEN
{
    public partial class frmPeople : Form
    {
        Realm realm = new RealmInstance().getRealmInstance();
        PeopleController PeopleController = new PeopleController();
        List<People> allPeople = new List<People>();
        People selectedPeople;

        public frmPeople()
        {
            InitializeComponent();
        }
        private void hideColumns(int from, int to)
        {
            for (int i = from; i <= to; i++)
            {
                dgvData.Columns[i].Visible = false;
            }
        }
        private void renameColumns(List<String> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                dgvData.Columns[i].HeaderText = l[i];
            }
        }
        private void fillData()
        {
            allPeople = PeopleController.getItems();
            dgvData.DataSource = null;
            dgvData.DataSource = allPeople;
            hideColumns(7, 12);
            List<String> headers = new List<string> { "Nombre", "Fecha de nacimiento", "Fallecido","Hijos","Enfermedades","Alergias","Conyuge"};
            renameColumns(headers);
        }

        private void addData(People a)
        {
            PeopleController.addItem(a);
        }
        private void clearForm()
        {
            txtPersonName.Text = "";
            chkDiseased.Checked = false;
            selectedPeople = null;
            btnAddPerson.Text = "Agregar";
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            dtpPersonBirth.MaxDate = DateTime.Now;
            fillData();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    //obtenemos el objeto de la lista de alergias
                    selectedPeople = allPeople[index];
                    //llenamos el formulario con los datos
                    txtPersonName.Text = selectedPeople.name;
                    dtpPersonBirth.Value = DateTime.Parse(selectedPeople.dateOfBirth);
                    chkDiseased.Checked = selectedPeople.deceased;
                    //establecemos el boton en modo modificar
                    btnAddPerson.Text = "Modificar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al tratar de obtener la persona seleccionada" + ex);
            }

            if (e.ColumnIndex == 3)
            {
                frmAddRelatives relatives = new frmAddRelatives();
                relatives.Person = selectedPeople;
                relatives.Show();
            }
            if (e.ColumnIndex == 4)
            {
                frmAddDiseases diseases = new frmAddDiseases();
                diseases.Person = selectedPeople;
                diseases.Show();
            }
            if (e.ColumnIndex == 5)
            {
                frmAddAllergies allergies = new frmAddAllergies();
                allergies.Person = selectedPeople;
                allergies.Show();
            }
            
            

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            


            int errorCount = 0;

            //validamos textbox, si posee errores agregamos al contador y establecemos el errorprovider
            if (txtPersonName.Text.Trim() == "")
            {
                errorProvider.SetError(txtPersonName, "Ingrese un nombre");
                errorCount++;
            }
            if (errorCount == 0)
            {
                //si el boton dice modificar, modificamos un objeto ya existente en la base
                if (btnAddPerson.Text == "Modificar")
                {
                    //iniciamos una transaccion de realm (sin esto no podemos modificar el objeto)
                    var transaction = realm.BeginWrite();
                    //actualizamos los campos
                    selectedPeople.name = txtPersonName.Text;
                    selectedPeople.deceased = chkDiseased.Checked;
                    selectedPeople.dateOfBirth = dtpPersonBirth.Value.ToString();

                    //guardamos la transaccion
                    transaction.Commit();

                    //limpiamos todo y llenamos datagrid
                    errorProvider.Clear();
                    fillData();
                    clearForm();

                }
                else
                {
                    //si es nuevo creamos un nuevo objeto y se lo pasamos al metodo add data
                    addData(new People
                    {
                        name = txtPersonName.Text,
                        deceased = chkDiseased.Checked,
                        dateOfBirth = dtpPersonBirth.Value.ToString(),
                        id = System.Guid.NewGuid().ToString() //la llave primaria es una combinacion aleatoria de texto
                    });

                    //limpiamos todo y llenamos datagrid

                    fillData();
                    clearForm();
                }

                //reseteamos variables de error
                errorProvider.Clear();
                errorCount = 0;
            }

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPeople_Enter(object sender, EventArgs e)
        {
            fillData();
        }

        
        private void btnEnd_Click(object sender, EventArgs e)
        {
            //listas necesarias
            ReportDataController rp = new ReportDataController();
            List<PeopleWithData> pwd = rp.getReportData();

            //para cada persona en la lista de todas las personas...
            string output = "------------------------------------------------------------------------------------------------------------------------------------------\n";
            foreach (PeopleWithData p in pwd)
            {
                
                //imprimir nombre de persona
                output +=">>"+p.People.name+"\n";

                //imprimir todas las enfermedades
                output += "-Padece de las siguientes enfermedades: \n";
                foreach(Diseases d in p.People.diseases)
                {
                    output += "\t->"+d.name + "\n";
                }

                //imprimir todas las alergias
                output += "-Tambien padece de las siguientes alergias: \n";
                foreach (Allergies a in p.People.allergies)
                {
                    output += "\t->" + a.name + " de tipo "+a.type+"\n";
                }

                //imprimir todas las enfermedades que podria tener la persona
                output += "-En base al arbol genealogico general, tiene las siguientes probabilidades de contraer enfermedades \n";
                foreach(DiseasesWithPercentage dwp in p.Diseases)
                {
                    output += "\t->" + dwp.Name + " con una probabilidad de: " + dwp.Percentage.ToString("#0.00")+"\n";
                }
                output += "------------------------------------------------------------------------------------------------------------------------------------------\n";
                //output de prueba
                //MessageBox.Show(output);

            }
            printPDF(output);
        }

        private void printPDF(string text)
        {
            PdfDocument doc = new PdfDocument();
            PdfSection section = doc.Sections.Add();
            PdfPageBase page = section.Pages.Add();
            PdfFont font = new PdfFont(PdfFontFamily.Helvetica, 11);
            PdfFont font2 = new PdfFont(PdfFontFamily.Helvetica, 20);
            PdfStringFormat format = new PdfStringFormat();
            format.LineSpacing = 20f;
            PdfBrush brush = PdfBrushes.Black;
            PdfTextWidget textWidget = new PdfTextWidget(text, font, brush);
            PdfTextWidget textWidget2 = new PdfTextWidget("Historial Medico Familiar.", font2, brush);

            float y = 0;
            float y2 = 35;
            PdfTextLayout textLayout = new PdfTextLayout();
            textLayout.Break = PdfLayoutBreakType.FitPage;
            textLayout.Layout = PdfLayoutType.Paginate;
            //limites de header
            RectangleF bounds = new RectangleF(new PointF(0, y), page.Canvas.ClientSize);
            //limites para la lista
            RectangleF bounds2 = new RectangleF(new PointF(0, y2), page.Canvas.ClientSize);
            textWidget.StringFormat = format;
            textWidget2.Draw(page, bounds, textLayout);
            textWidget.Draw(page, bounds2, textLayout);


            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            /*DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    doc.SaveToFile(folderDlg.SelectedPath + "/ReporteFamiliar.pdf", FileFormat.PDF);
                    MessageBox.Show("El documento ha sido almacenado en: " + folderDlg.SelectedPath + "/Reporte.pdf");
                }
                catch
                {
                    MessageBox.Show("No fue posible guardar el PDF, es posible que se encuentre abierto por otra aplicacion");
                }
            }*/

            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "PDF Document (.pdf)|*.pdf";
            sf.Title = "Guardar reporte en...";
            sf.FileName = "Reporte familiar";
            sf.ShowDialog();
            try
            {
                doc.SaveToFile(sf.FileName, FileFormat.PDF);
                System.Diagnostics.Process.Start(sf.FileName);
            }
            catch
            {
                MessageBox.Show("No fue posible guardar el PDF, es posible que se encuentre abierto por otra aplicacion o que cancelara la creacion del mismo");
            }
            
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void BtnTree_Click(object sender, EventArgs e)
        {
            Arbol_Familiar Afamily = new Arbol_Familiar();
            try
            {

                int index = dgvData.CurrentRow.Index;

                if (index >= 0)
                {
                    selectedPeople = allPeople[index];
                    Afamily.Person = selectedPeople;
                    Afamily.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al tratar de obtener la persona seleccionada" + ex);
            }
        }
    }
}

