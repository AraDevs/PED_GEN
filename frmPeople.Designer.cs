namespace PED_GEN
{
    partial class frmPeople
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
            this.components = new System.ComponentModel.Container();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.dtpPersonBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDiseased = new System.Windows.Forms.CheckBox();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlergies = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnTree = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(24, 235);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(520, 212);
            this.dgvData.TabIndex = 16;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClean);
            this.groupBox1.Controls.Add(this.dtpPersonBirth);
            this.groupBox1.Controls.Add(this.btnAddPerson);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkDiseased);
            this.groupBox1.Controls.Add(this.txtPersonName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 158);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion general";
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(335, 111);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(77, 30);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // dtpPersonBirth
            // 
            this.dtpPersonBirth.Location = new System.Drawing.Point(23, 84);
            this.dtpPersonBirth.Name = "dtpPersonBirth";
            this.dtpPersonBirth.Size = new System.Drawing.Size(198, 20);
            this.dtpPersonBirth.TabIndex = 7;
            this.dtpPersonBirth.Value = new System.DateTime(2020, 3, 20, 0, 0, 0, 0);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.Location = new System.Drawing.Point(418, 111);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(77, 30);
            this.btnAddPerson.TabIndex = 6;
            this.btnAddPerson.Text = "Agregar";
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // chkDiseased
            // 
            this.chkDiseased.AutoSize = true;
            this.chkDiseased.Location = new System.Drawing.Point(374, 41);
            this.chkDiseased.Name = "chkDiseased";
            this.chkDiseased.Size = new System.Drawing.Size(68, 17);
            this.chkDiseased.TabIndex = 3;
            this.chkDiseased.Text = "Fallecido";
            this.chkDiseased.UseVisualStyleBackColor = true;
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(23, 41);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(198, 20);
            this.txtPersonName.TabIndex = 1;
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
            // btnAlergies
            // 
            this.btnAlergies.AutoSize = true;
            this.btnAlergies.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlergies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlergies.Location = new System.Drawing.Point(21, 43);
            this.btnAlergies.Name = "btnAlergies";
            this.btnAlergies.Size = new System.Drawing.Size(383, 15);
            this.btnAlergies.TabIndex = 14;
            this.btnAlergies.Text = "Agrega tu informacion y la de tus familiares en esta ventana";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTitle1.Location = new System.Drawing.Point(18, 11);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(413, 32);
            this.lblTitle1.TabIndex = 13;
            this.lblTitle1.Text = "Acerca de ti... y tus familiares";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(467, 453);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(77, 30);
            this.btnEnd.TabIndex = 8;
            this.btnEnd.Text = "Finalizar";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // BtnTree
            // 
            this.BtnTree.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTree.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTree.ForeColor = System.Drawing.Color.White;
            this.BtnTree.Location = new System.Drawing.Point(359, 453);
            this.BtnTree.Name = "BtnTree";
            this.BtnTree.Size = new System.Drawing.Size(77, 30);
            this.BtnTree.TabIndex = 17;
            this.BtnTree.Text = "Arbol";
            this.BtnTree.UseVisualStyleBackColor = false;
            this.BtnTree.Click += new System.EventHandler(this.BtnTree_Click);
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 488);
            this.Controls.Add(this.BtnTree);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAlergies);
            this.Controls.Add(this.lblTitle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPeople";
            this.Text = "frmPeople";
            this.Load += new System.EventHandler(this.frmPeople_Load);
            this.Enter += new System.EventHandler(this.frmPeople_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnAlergies;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.DateTimePicker dtpPersonBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDiseased;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button BtnTree;
    }
}