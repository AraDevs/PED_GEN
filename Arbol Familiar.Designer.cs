namespace PED_GEN
{
    partial class Arbol_Familiar
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
            this.Pizarra = new System.Windows.Forms.Panel();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pizarra
            // 
            this.Pizarra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pizarra.Location = new System.Drawing.Point(0, 48);
            this.Pizarra.Name = "Pizarra";
            this.Pizarra.Size = new System.Drawing.Size(844, 478);
            this.Pizarra.TabIndex = 9;
            this.Pizarra.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle1.Location = new System.Drawing.Point(325, 9);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(207, 32);
            this.lblTitle1.TabIndex = 10;
            this.lblTitle1.Text = "Árbol Familiar";
            // 
            // Arbol_Familiar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 526);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.Pizarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Arbol_Familiar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbol_Familiar";
            this.Load += new System.EventHandler(this.Arbol_Familiar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Pizarra;
        private System.Windows.Forms.Label lblTitle1;
    }
}