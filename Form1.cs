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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ShowChildForm(object frm)
        {
            if (this.pnlContent.Controls.Count > 0)
            {
                this.pnlContent.Controls.RemoveAt(0);
            }
            Form form = frm as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(form);
            this.pnlContent.Tag = form;
            form.Show();
        }

        private void btnDiseases_Click(object sender, EventArgs e)
        {
            ShowChildForm(new frmDiseases());
        }

        private void btnAlergies_Click(object sender, EventArgs e)
        {
            ShowChildForm(new frmAlergies());
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowChildForm(new frmPeople());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            string output = "";
            output += "Herramienta de historial medico familiar\n\n";
            output += "Desarrollada por: \n";
            output += "Herrera Guardado, Carlos David - HG190072\n";
            output += "Abrego Herrera, Giovanny Misael - AH132090\n";
            output += "Méndez Argueta, Oscar Ernesto - MA171622\n";
            output += "Sura Jiménez, Victoria Margarita - SJ190060\n";
            output += "Rivas Cerón, Rodrigo Fernando - RC180650\n\n";
            output += "-------------------------------------------------------------\n";
            output += "Universidad Don Bosco, Ing. C.C 2020";

            MessageBox.Show(output);

        }
    }
}
