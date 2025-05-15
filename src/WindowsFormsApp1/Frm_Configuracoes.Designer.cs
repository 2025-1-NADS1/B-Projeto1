namespace WindowsFormsApp1
{
    partial class Frm_Configuracoes
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
            this.Lbl_ConfiguracoesUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_ConfiguracoesUsuario
            // 
            this.Lbl_ConfiguracoesUsuario.AutoSize = true;
            this.Lbl_ConfiguracoesUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ConfiguracoesUsuario.ForeColor = System.Drawing.Color.White;
            this.Lbl_ConfiguracoesUsuario.Location = new System.Drawing.Point(29, 25);
            this.Lbl_ConfiguracoesUsuario.Name = "Lbl_ConfiguracoesUsuario";
            this.Lbl_ConfiguracoesUsuario.Size = new System.Drawing.Size(530, 46);
            this.Lbl_ConfiguracoesUsuario.TabIndex = 0;
            this.Lbl_ConfiguracoesUsuario.Text = "Aqui ficam as Configurações";
            // 
            // Frm_Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(717, 438);
            this.Controls.Add(this.Lbl_ConfiguracoesUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Configuracoes";
            this.Text = "Frm_Configuracoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ConfiguracoesUsuario;
    }
}