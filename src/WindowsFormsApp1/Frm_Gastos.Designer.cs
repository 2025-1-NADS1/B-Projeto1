namespace WindowsFormsApp1
{
    partial class Frm_Gastos
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
            this.Lbl_GastosUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_GastosUsuario
            // 
            this.Lbl_GastosUsuario.AutoSize = true;
            this.Lbl_GastosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GastosUsuario.ForeColor = System.Drawing.Color.White;
            this.Lbl_GastosUsuario.Location = new System.Drawing.Point(22, 21);
            this.Lbl_GastosUsuario.Name = "Lbl_GastosUsuario";
            this.Lbl_GastosUsuario.Size = new System.Drawing.Size(437, 46);
            this.Lbl_GastosUsuario.TabIndex = 0;
            this.Lbl_GastosUsuario.Text = "Aqui Ficarão os Gastos";
            // 
            // Frm_Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.Lbl_GastosUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Gastos";
            this.Text = "Frm_Gastos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_GastosUsuario;
    }
}