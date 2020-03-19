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
    public partial class frmAddAllergies : Form
    {
        Realm realm = new RealmInstance().getRealmInstance();
        AllergiesController allergiesController = new AllergiesController();

        private People person = null;
        internal People Person { get => person; set => person = value; }
        List<Allergies> allergiesList = new List<Allergies>();
        List<Allergies> personAllergies = new List<Allergies>();
        public frmAddAllergies()
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
            personAllergies = person.allergies.ToList();
            dgvData.DataSource = null;
            dgvData.DataSource = personAllergies;
            hideColumns(2, 8);
            List<String> headers = new List<string> { "Nombre", "Tipo de alergia"};
            renameColumns(headers);
        }

        private void fillComboBox()
        {
            cmbAllergies.DataSource = null;
            allergiesList = allergiesController.getActiveItems();
            
            foreach(Allergies a in personAllergies)
            {
                allergiesList.Remove(a);
            }

            cmbAllergies.DataSource = allergiesList;
        }

        private void addAllergy(Allergies a)
        {
            //iniciamos una transaccion de realm (sin esto no podemos modificar el objeto)
            var transaction = realm.BeginWrite();
            //actualizamos los campos
            person.allergies.Add(a);

            //guardamos la transaccion
            transaction.Commit();
            fillData();
            fillComboBox();

        }

        private void frmAddAllergies_Load(object sender, EventArgs e)
        {
            
           
            if (person == null)
            {
                MessageBox.Show("No hay persona seleccionada");
                this.Close();
            }
            else
            {
                string[] name = person.name.Split(' ');
                lblTitle1.Text = "Alergias de " + name[0];
                fillData();
                fillComboBox();
            }
        }

        private void btnAddDisease_Click(object sender, EventArgs e)
        {
            addAllergy(cmbAllergies.SelectedItem as Allergies);
        }
    }
}
