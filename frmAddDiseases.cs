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
    public partial class frmAddDiseases : Form
    {
        Realm realm = new RealmInstance().getRealmInstance();
        DiseasesController diseasesController = new DiseasesController();

        private People person = null;
        internal People Person { get => person; set => person = value; }
        List<Diseases> diseasesList = new List<Diseases>();
        List<Diseases> personDiseases = new List<Diseases>();
        public frmAddDiseases()
        {
            InitializeComponent();
        }

        //este metodo permite ocultar las columnas que no son necesarias (todas las columnas despues del campo estado)
        private void hideColumns(int from, int to)
        {
            for (int i = from; i <= to; i++)
            {
                dgvData.Columns[i].Visible = false;
            }
        }

        //este metodo permite renombrar las columnas porque por defecto trae los nombres en ingles del modelo
        private void renameColumns(List<String> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                dgvData.Columns[i].HeaderText = l[i];
            }
        }

        private void fillData()
        {
            personDiseases = person.diseases.ToList();
            dgvData.DataSource = null;
            dgvData.DataSource = personDiseases;
            hideColumns(4, 9); //preguntar esto
            List<String> headers = new List<string> { "Nombre", "Porcentaje", "Enfermedad cronica", "Estado" };
            renameColumns(headers);
        }

        private void fillComboBox()
        {
            cmbDiseases.DataSource = null;
            diseasesList = diseasesController.getActiveItems();

            foreach (Diseases a in personDiseases)
            {
                diseasesList.Remove(a);
            }

            cmbDiseases.DataSource = diseasesList;
        }

        private void addDisease(Diseases a)
        {
            //iniciamos una transaccion de realm (sin esto no podemos modificar el objeto)
            var transaction = realm.BeginWrite();
            //actualizamos los campos
            person.diseases.Add(a);

            //guardamos la transaccion
            transaction.Commit();
            fillData();
            fillComboBox();

        }

        private void frmAddDiseases_Load(object sender, EventArgs e)
        {
            if (person == null)
            {
                MessageBox.Show("No hay persona seleccionada");
                this.Close();
            }
            else
            {
                string[] name = person.name.Split(' ');
                lblTitle1.Text = "Enfermedades de " + name[0];
                fillData();
                fillComboBox();
            }
        }

        private void btnAddDisease_Click(object sender, EventArgs e)
        {
            addDisease(cmbDiseases.SelectedItem as Diseases);
        }
    }
}
