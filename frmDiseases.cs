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
    public partial class frmDiseases : Form
    {
        Realm realm = new RealmInstance().getRealmInstance();
        DiseasesController diseasesconController = new DiseasesController();        
        List<Diseases> allDiseases = new List<Diseases>();
        Diseases selectedDiseases;

        public frmDiseases()
        {
            InitializeComponent();
            fillData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
        private void clearForm()
        {
            txtDiseaseName.Text = "";
            txtDiseasePercentage.Text = "";
            selectedDiseases = null;
            btnAddDisease.Text = "Agregar";
        }
        private void fillData()
        {
            allDiseases = diseasesconController.getItems();
            dgvData.DataSource = null;
            dgvData.DataSource = allDiseases;
            hideColumns(4, 8); //preguntar esto
            List<String> headers = new List<string> { "Nombre", "Porcentaje", "Enfermedad cronica", "Estado"};
            renameColumns(headers);
        }
        private void addData(Diseases d)
        {
            diseasesconController.addItem(d);
        }

        private void btnAddDisease_Click(object sender, EventArgs e)
        {
            int errorCount = 0;

            if (txtDiseaseName.Text.Trim() == "")
            {
                errorProvider.SetError(txtDiseaseName, "Ingrese un nombre");
                errorCount++;
            }
            if (txtDiseasePercentage.Text.Trim() == "")
            {
                errorProvider.SetError(txtDiseaseName, "Ingrese un porcentaje númerico");
                errorCount++;
            }
            if (errorCount == 0)
            {
                if (btnAddDisease.Text == "Modificar")
                {
                    var transaction = realm.BeginWrite();
                    selectedDiseases.name = txtDiseaseName.Text;
                    selectedDiseases.percentage = Convert.ToInt32(txtDiseasePercentage.Text);
                    selectedDiseases.chronicles = chkCronic.Checked;
                    selectedDiseases.state = chkEnabled.Checked;

                    transaction.Commit();

                    errorProvider.Clear();
                    fillData();
                    clearForm();

                }
                else
                {
                    addData(new Diseases
                    {
                        name = txtDiseaseName.Text,
                        percentage = Convert.ToInt32(txtDiseasePercentage.Text),
                        chronicles = chkCronic.Checked,
                        state = chkEnabled.Checked,
                        id = System.Guid.NewGuid().ToString()
                    });

                    fillData();
                    clearForm();
                }

                errorProvider.Clear();
                errorCount = 0;
            }

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    selectedDiseases = allDiseases[index];
                    txtDiseaseName.Text = selectedDiseases.name;
                    txtDiseasePercentage.Text = selectedDiseases.percentage.ToString();
                    chkCronic.Checked = selectedDiseases.chronicles;
                    chkEnabled.Checked = selectedDiseases.state;
                    btnAddDisease.Text = "Modificar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al tratar de obtener la alergia seleccionada" + ex);
            }
        }

        private void txtDiseasePercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorProvider.SetError(txtDiseasePercentage, "Solo numero");
            } else { errorProvider.SetError(txtDiseasePercentage, ""); }
        }
    }
}
