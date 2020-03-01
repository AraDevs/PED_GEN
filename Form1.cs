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
    }
}
