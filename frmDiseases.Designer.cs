namespace PED_GEN
{
    partial class frmDiseases
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAlergies = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiseaseName = new System.Windows.Forms.TextBox();
            this.chkCronic = new System.Windows.Forms.CheckBox();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.txtDiseasePercentage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddDisease = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlergies
            // 
            this.btnAlergies.AutoSize = true;
            this.btnAlergies.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlergies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlergies.Location = new System.Drawing.Point(15, 41);
            this.btnAlergies.Name = "btnAlergies";
            this.btnAlergies.Size = new System.Drawing.Size(333, 15);
            this.btnAlergies.TabIndex = 6;
            this.btnAlergies.Text = "Si la enfermedad que buscas no esta, agregala aqui.";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTitle1.Location = new System.Drawing.Point(12, 9);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(203, 32);
            this.lblTitle1.TabIndex = 5;
            this.lblTitle1.Text = "Enfermedades";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddDisease);
            this.groupBox1.Controls.Add(this.txtDiseasePercentage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkEnabled);
            this.groupBox1.Controls.Add(this.chkCronic);
            this.groupBox1.Controls.Add(this.txtDiseaseName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 158);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion general";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtDiseaseName
            // 
            this.txtDiseaseName.Location = new System.Drawing.Point(23, 41);
            this.txtDiseaseName.Name = "txtDiseaseName";
            this.txtDiseaseName.Size = new System.Drawing.Size(165, 20);
            this.txtDiseaseName.TabIndex = 1;
            // 
            // chkCronic
            // 
            this.chkCronic.AutoSize = true;
            this.chkCronic.Location = new System.Drawing.Point(374, 41);
            this.chkCronic.Name = "chkCronic";
            this.chkCronic.Size = new System.Drawing.Size(121, 17);
            this.chkCronic.TabIndex = 2;
            this.chkCronic.Text = "Enfermedad cronica";
            this.chkCronic.UseVisualStyleBackColor = true;
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Location = new System.Drawing.Point(374, 77);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(56, 17);
            this.chkEnabled.TabIndex = 3;
            this.chkEnabled.Text = "Activa";
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // txtDiseasePercentage
            // 
            this.txtDiseasePercentage.Location = new System.Drawing.Point(23, 81);
            this.txtDiseasePercentage.Name = "txtDiseasePercentage";
            this.txtDiseasePercentage.Size = new System.Drawing.Size(165, 20);
            this.txtDiseasePercentage.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Porcentaje contagio";
            // 
            // btnAddDisease
            // 
            this.btnAddDisease.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddDisease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDisease.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDisease.ForeColor = System.Drawing.Color.White;
            this.btnAddDisease.Location = new System.Drawing.Point(418, 111);
            this.btnAddDisease.Name = "btnAddDisease";
            this.btnAddDisease.Size = new System.Drawing.Size(77, 30);
            this.btnAddDisease.TabIndex = 6;
            this.btnAddDisease.Text = "Agregar";
            this.btnAddDisease.UseVisualStyleBackColor = false;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(18, 264);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(520, 212);
            this.dgvData.TabIndex = 8;
            // 
            // frmDiseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 488);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAlergies);
            this.Controls.Add(this.lblTitle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDiseases";
            this.Text = "frmDiseases";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnAlergies;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiseasePercentage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.CheckBox chkCronic;
        private System.Windows.Forms.TextBox txtDiseaseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDisease;
        private System.Windows.Forms.DataGridView dgvData;
    }
}