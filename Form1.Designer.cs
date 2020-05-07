namespace PED_GEN
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Label();
            this.btnDiseases = new System.Windows.Forms.Label();
            this.btnAlergies = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnDiseases);
            this.panel1.Controls.Add(this.btnAlergies);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.lblTitle2);
            this.panel1.Controls.Add(this.lblTitle1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 530);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Location = new System.Drawing.Point(21, 491);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 15);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Salir ";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.AutoSize = true;
            this.btnAbout.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbout.Location = new System.Drawing.Point(21, 460);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(70, 15);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "Acerca de";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnDiseases
            // 
            this.btnDiseases.AutoSize = true;
            this.btnDiseases.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiseases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDiseases.Location = new System.Drawing.Point(21, 227);
            this.btnDiseases.Name = "btnDiseases";
            this.btnDiseases.Size = new System.Drawing.Size(151, 15);
            this.btnDiseases.TabIndex = 5;
            this.btnDiseases.Text = "Agregar enfermedades";
            this.btnDiseases.Click += new System.EventHandler(this.btnDiseases_Click);
            // 
            // btnAlergies
            // 
            this.btnAlergies.AutoSize = true;
            this.btnAlergies.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlergies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlergies.Location = new System.Drawing.Point(21, 189);
            this.btnAlergies.Name = "btnAlergies";
            this.btnAlergies.Size = new System.Drawing.Size(109, 15);
            this.btnAlergies.TabIndex = 4;
            this.btnAlergies.Text = "Agregar alergias";
            this.btnAlergies.Click += new System.EventHandler(this.btnAlergies_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(24, 120);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(174, 30);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Historial familiar";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle2.Location = new System.Drawing.Point(18, 52);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(118, 32);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "Medico.";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle1.Location = new System.Drawing.Point(18, 18);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(140, 32);
            this.lblTitle1.TabIndex = 1;
            this.lblTitle1.Text = "Historial ";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pictureBox1);
            this.pnlContent.Location = new System.Drawing.Point(224, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(579, 527);
            this.pnlContent.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PED_GEN.Properties.Resources.informe_medico_ilustracion_diseno_plano_1223_169;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(803, 530);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial medico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Label btnAbout;
        private System.Windows.Forms.Label btnDiseases;
        private System.Windows.Forms.Label btnAlergies;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

