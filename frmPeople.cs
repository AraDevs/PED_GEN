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
        public frmPeople()
        {
            InitializeComponent();
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                new frmAddRelatives().Show();
            }
            if (e.ColumnIndex == 4)
            {
                new frmAddAllergies().Show();
            }
            if (e.ColumnIndex == 5)
            {
                new frmAddDiseases().Show();
            }
        }
    }
}
