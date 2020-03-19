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
    public partial class frmAddRelatives : Form
    {
        Realm realm = new RealmInstance().getRealmInstance();
        PeopleController peopleController = new PeopleController();

        People spouse = new People();
        List<People> allPeople = new List<People>();    //Listado de todas las personas para llenar cbo
        List<People> allPeople2 = new List<People>();    //Listado de todas las personas para llenar cbo
        List<People> relatives = new List<People>();    //Listado de hijos + pareja

        private People person = null;
        public frmAddRelatives()
        {
            InitializeComponent();
        }

        internal People Person { get => person; set => person = value; }

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

            relatives = person.sons.ToList();

            if (spouse != null)
                relatives.Add(spouse);

            dgvData.DataSource = null;
            dgvData.DataSource = relatives;
            hideColumns(3, 12);
            List<String> headers = new List<string> { "Nombre", "Fecha de nacimiento", "Fallecido"};
            renameColumns(headers);
        }

        private void fillComboBoxs()
        {
            cmbPartner.DataSource = null;
            cmbSons.DataSource = null;
            allPeople = peopleController.getItems();
            allPeople2 = peopleController.getItems();
            //Remueve los familiares ya agregados
            foreach (People a in relatives)
            {
                allPeople.Remove(a);
            }
            
            if (spouse == null)
            {//Si no hay pareja, elimina todas las personas con pareja
                //Remueve las personas que ya tienen pareja
                foreach (People b in allPeople2)
                {
                    if (b.spouse != null)
                        allPeople.Remove(b);
                }
            }
            else
            {//Si tiene pareja pero el boton modificar esta activo
                if (btnAddDisease.Text=="Modificar")
                {
                    allPeople.Add(spouse);
                    //Remueve las personas que ya tienen pareja
                    foreach (People b in allPeople2)
                    {
                        if (b.spouse != null)
                            allPeople.Remove(b);
                    }
                }

            }
            //Remueve los hijos de otras personas
            foreach (People c in allPeople2)
            {
                if (c.sons.Count>0)
                {
                    foreach (People d in c.sons)
                    {
                        allPeople.Remove(d);
                    }
                }
            }
            //Elimina a la persona del listado
            allPeople.Remove(person);
            //Carga la lista a los combobox
            cmbPartner.DataSource = allPeople;
            cmbPartner.DisplayMember = "name";
            cmbSons.DataSource = allPeople;
            cmbSons.DisplayMember = "name";
        }

        private void frmAddRelatives_Load(object sender, EventArgs e)
        {
            if (person == null)
            {
                MessageBox.Show("No hay persona seleccionada");
                this.Close();
            }
            else
            {
                string[] name = person.name.Split(' ');
                lblTitle1.Text = "Parientes de " + name[0];

                spouse = person.spouse;
                if (person.spouse == null)
                {
                    label1.Visible = false;
                    cmbSons.Visible = false;
                }
                else
                {
                    label2.Visible = false;
                    cmbPartner.Visible = false;
                }
                fillData();
                fillComboBoxs();
            }
        }
        private void addRelative(People a, bool b)
        {
            //iniciamos una transaccion de realm (sin esto no podemos modificar el objeto)
            var transaction = realm.BeginWrite();
            if (b)
            {//Si agrega pareja, se actualizan ambos registros spouse
                a.spouse = person;
                person.spouse = a;
            }
            else
            {//Si agrega hijo, actualiza el registro de ambos padres
                person.sons.Add(a);
                spouse.sons.Add(a);
            }
                

            //guardamos la transaccion
            transaction.Commit();
            fillData();
            fillComboBoxs();
        }
        private void changeSpouse(People a, People b)
        {
            //iniciamos una transaccion de realm (sin esto no podemos modificar el objeto)
            var transaction = realm.BeginWrite();
            a.spouse = null;
            b.spouse = person;
            person.spouse = null;
            person.spouse = b;
            //guardamos la transaccion
            transaction.Commit();
            //Actualiza el objeto spouse en el formulario
            spouse = b;
            fillData();
            fillComboBoxs();
        }
        private void btnAddDisease_Click(object sender, EventArgs e)
        {
            if (spouse != null)
            {//Si hay pareja
                if (btnAddDisease.Text == "Modificar") {  
                    //Si se modificara pareja
                    changeSpouse(spouse, cmbPartner.SelectedItem as People);
                    btnAddDisease.Text = "Agregar";
                    cmbPartner.Visible = false;
                    label2.Visible = false;
                    cmbSons.Visible = true;
                    label1.Visible = true;
                    //Actualiza combobox
                    fillComboBoxs();
                }else//Se agrega un hijo
                    addRelative(cmbSons.SelectedItem as People, false);
            }
            else
            {//Si no hay pareja la agrega
                //Agrega el objeto para el formulario
                spouse = cmbPartner.SelectedItem as People;
                //Agrega el objeto a la base de datos
                addRelative(cmbPartner.SelectedItem as People, true);
                label1.Visible = true;
                cmbSons.Visible = true;
                label2.Visible = false;
                cmbPartner.Visible = false;
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvData.Rows[e.RowIndex];
                //Obtiene el nombre de la persona seleccionada
                string nombre = row.Cells["name"].Value.ToString();
                //Llena la lista de todas las personas
                allPeople2 = peopleController.getItems().ToList();
                //Establece el objeto seleccionado
                People a = new People();
                foreach (People item in allPeople2)
                {
                    if (nombre == item.name)
                        a = item;
                }
                if (person.spouse.name == a.name)
                {
                    label1.Visible = false;
                    cmbSons.Visible = false;
                    label2.Visible = true;
                    cmbPartner.Visible = true;
                    btnAddDisease.Text = "Modificar";
                }
                else
                {
                    label1.Visible = true;
                    cmbSons.Visible = true;
                    label2.Visible = false;
                    cmbPartner.Visible = false;
                }
                //Actualiza combobox
                fillComboBoxs();
            }

        }
    }
}
