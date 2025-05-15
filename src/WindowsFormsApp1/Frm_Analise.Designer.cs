namespace WindowsFormsApp1
{
    partial class Frm_Analise
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
            this.Lbl_AnalisesUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_AnalisesUsuario
            // 
            this.Lbl_AnalisesUsuario.AutoSize = true;
            this.Lbl_AnalisesUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AnalisesUsuario.ForeColor = System.Drawing.Color.White;
            this.Lbl_AnalisesUsuario.Location = new System.Drawing.Point(90, 20);
            this.Lbl_AnalisesUsuario.Name = "Lbl_AnalisesUsuario";
            this.Lbl_AnalisesUsuario.Size = new System.Drawing.Size(564, 46);
            this.Lbl_AnalisesUsuario.TabIndex = 0;
            this.Lbl_AnalisesUsuario.Text = "Análises Ficarão Nesse Forms";
            // 
            // Frm_Analise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.Lbl_AnalisesUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Analise";
            this.Text = "Frm_Analise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_AnalisesUsuario;
    }
}