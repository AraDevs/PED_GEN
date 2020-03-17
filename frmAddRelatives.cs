using PED_GEN.Models;
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

        private People person = null;
        public frmAddRelatives()
        {
            InitializeComponent();
        }

        internal People Person { get => person; set => person = value; }

        private void frmAddRelatives_Load(object sender, EventArgs e)
        {
            if(person == null)
            {
                MessageBox.Show("No hay persona seleccionada");
                this.Close();
            }
            else
            {
                string[] name = person.name.Split(' ');
                lblTitle1.Text = "Parientes de " + name[0];
            }
        }

        private void btnAddDisease_Click(object sender, EventArgs e)
        {

        }
    }
}
