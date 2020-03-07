using PED_GEN.Controllers;
using PED_GEN.Models;
using PED_GEN.RealmConnection;
using Realms;
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
    public partial class frmAlergies : Form
    {
        Realm realm = new RealmInstance().getRealmInstance();
        AllergiesController allergiesController = new AllergiesController();
        List<Allergies> allAllergies = new List<Allergies>();
        Allergies selectedAllergie;


        public frmAlergies()
        {
            InitializeComponent();
        }

        //este metodo permite ocultar las columnas que no son necesarias (todas las columnas despues del campo estado)
        private void hideColumns(int from, int to)
        {
            for(int i=from;i<=to; i++)
            {
                dgvData.Columns[i].Visible=false;
            }
        }

        //este metodo permite renombrar las columnas porque por defecto trae los nombres en ingles del modelo
        private void renameColumns(List<String> l)
        {
            for(int i = 0; i<l.Count; i++)
            {
                dgvData.Columns[i].HeaderText = l[i];
            }
        }

        //este metodo llena el datagridview con los datos de la base
        private void fillData()
        {
            allAllergies = allergiesController.getItems(); 
            dgvData.DataSource = null;
            dgvData.DataSource = allAllergies;
            hideColumns(3, 8);
            List<String> headers = new List<string> { "Nombre", "Tipo de alergia", "Estado" };
            renameColumns(headers);
        }

        //este metodo agrega un elemento a la base
        private void addData(Allergies a)
        {
            allergiesController.addItem(a);
        }

        //este metodo limpia los campos del form
        private void clearForm()
        {
            txtAllergyName.Text = "";
            cmbAllergyType.SelectedIndex = 0;
            selectedAllergie = null;
            btnAddAllergy.Text = "Agregar";
        }
        private void frmAlergies_Load(object sender, EventArgs e)
        {
            //cargamos datos en el datagrid
            fillData();
            //establecemos que el cmb este seleccionado en la primera opcion
            cmbAllergyType.SelectedIndex = 0;
        }

        private void btnAddAllergy_Click(object sender, EventArgs e)
        {
            //contador de errores
            int errorCount = 0;

            //validamos textbox, si posee errores agregamos al contador y establecemos el errorprovider
            if(txtAllergyName.Text.Trim()=="")
            {
                errorProvider.SetError(txtAllergyName, "Ingrese un nombre");
                errorCount++;
            }

            //si no hay errores
            if(errorCount == 0)
            {
                //si el boton dice modificar, modificamos un objeto ya existente en la base
                if (btnAddAllergy.Text == "Modificar")
                {
                    //iniciamos una transaccion de realm (sin esto no podemos modificar el objeto)
                    var transaction = realm.BeginWrite();
                    //actualizamos los campos
                    selectedAllergie.name = txtAllergyName.Text;
                    selectedAllergie.type = cmbAllergyType.SelectedItem.ToString();
                    selectedAllergie.state = chkEnabled.Checked;

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
                    addData(new Allergies
                    {
                        name = txtAllergyName.Text,
                        type = cmbAllergyType.SelectedItem.ToString(),
                        state = chkEnabled.Checked,
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

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //al darle clic a una celda tratamos de obtener el objeto relacionado a dicho row
            try
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    //obtenemos el objeto de la lista de alergias
                    selectedAllergie = allAllergies[index];
                    //llenamos el formulario con los datos
                    txtAllergyName.Text = selectedAllergie.name;
                    cmbAllergyType.SelectedItem = selectedAllergie.type;
                    chkEnabled.Checked = selectedAllergie.state;
                    //establecemos el boton en modo modificar
                    btnAddAllergy.Text = "Modificar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al tratar de obtener la alergia seleccionada" + ex);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        { 
            //limpiamos todo
            clearForm();
        }
    }
}
