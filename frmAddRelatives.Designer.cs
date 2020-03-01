namespace PED_GEN
{
    partial class frmAddRelatives
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPartner = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddDisease = new System.Windows.Forms.Button();
            this.btnAlergies = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.cmbSons = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(24, 266);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(520, 212);
            this.dgvData.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSons);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbPartner);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddDisease);
            this.groupBox1.Location = new System.Drawing.Point(24, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 158);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion general";
            // 
            // cmbPartner
            // 
            this.cmbPartner.FormattingEnabled = true;
            this.cmbPartner.Items.AddRange(new object[] {
            "Entorno",
            "Animal",
            "Medico"});
            this.cmbPartner.Location = new System.Drawing.Point(24, 53);
            this.cmbPartner.Name = "cmbPartner";
            this.cmbPartner.Size = new System.Drawing.Size(165, 21);
            this.cmbPartner.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Esposo/a";
            // 
            // btnAddDisease
            // 
            this.btnAddDisease.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddDisease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDisease.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDisease.ForeColor = System.Drawing.Color.White;
            this.btnAddDisease.Location = new System.Drawing.Point(419, 70);
            this.btnAddDisease.Name = "btnAddDisease";
            this.btnAddDisease.Size = new System.Drawing.Size(77, 30);
            this.btnAddDisease.TabIndex = 6;
            this.btnAddDisease.Text = "Agregar";
            this.btnAddDisease.UseVisualStyleBackColor = false;
            // 
            // btnAlergies
            // 
            this.btnAlergies.AutoSize = true;
            this.btnAlergies.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlergies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlergies.Location = new System.Drawing.Point(21, 43);
            this.btnAlergies.Name = "btnAlergies";
            this.btnAlergies.Size = new System.Drawing.Size(262, 15);
            this.btnAlergies.TabIndex = 14;
            this.btnAlergies.Text = "Los parientes cercanos de esta persona";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTitle1.Location = new System.Drawing.Point(18, 11);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(313, 32);
            this.lblTitle1.TabIndex = 13;
            this.lblTitle1.Text = "Parientes de {Nombre}";
            // 
            // cmbSons
            // 
            this.cmbSons.FormattingEnabled = true;
            this.cmbSons.Items.AddRange(new object[] {
            "Entorno",
            "Animal",
            "Medico"});
            this.cmbSons.Location = new System.Drawing.Point(24, 105);
            this.cmbSons.Name = "cmbSons";
            this.cmbSons.Size = new System.Drawing.Size(165, 21);
            this.cmbSons.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hijo";
            // 
            // frmAddRelatives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 488);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAlergies);
            this.Controls.Add(this.lblTitle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddRelatives";
            this.Text = "Agregar parientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPartner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddDisease;
        private System.Windows.Forms.Label btnAlergies;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.ComboBox cmbSons;
        private System.Windows.Forms.Label label1;
    }
}