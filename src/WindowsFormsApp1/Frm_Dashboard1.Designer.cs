namespace WindowsFormsApp1
{
    partial class Frm_Dashboard1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_Preencher = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_TerminarDepois = new System.Windows.Forms.Label();
            this.Pnl_Grafico = new System.Windows.Forms.Panel();
            this.Lbl_Grafico = new System.Windows.Forms.Label();
            this.Pnl_Comparacao = new System.Windows.Forms.Panel();
            this.Lbl_ultimostrintadiascomparacao = new System.Windows.Forms.Label();
            this.Cpb_comparacao = new CircularProgressBar.CircularProgressBar();
            this.Lbl_Comparacao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_ConsumoAnterior = new System.Windows.Forms.Label();
            this.Pnl_ = new System.Windows.Forms.Panel();
            this.Lbl_UltimosTrintaDias = new System.Windows.Forms.Label();
            this.Lbl_KwhAtual = new System.Windows.Forms.Label();
            this.Lbl_CosumoAtual = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Pnl_Grafico.SuspendLayout();
            this.Pnl_Comparacao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnl_.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Lbl_Preencher);
            this.panel2.Location = new System.Drawing.Point(575, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 130);
            this.panel2.TabIndex = 8;
            // 
            // Lbl_Preencher
            // 
            this.Lbl_Preencher.AutoSize = true;
            this.Lbl_Preencher.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Preencher.ForeColor = System.Drawing.Color.White;
            this.Lbl_Preencher.Location = new System.Drawing.Point(13, 11);
            this.Lbl_Preencher.Name = "Lbl_Preencher";
            this.Lbl_Preencher.Size = new System.Drawing.Size(98, 25);
            this.Lbl_Preencher.TabIndex = 0;
            this.Lbl_Preencher.Text = "Preencher";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.Lbl_TerminarDepois);
            this.panel4.Location = new System.Drawing.Point(293, 387);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(437, 75);
            this.panel4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Último Mês";
            // 
            // Lbl_TerminarDepois
            // 
            this.Lbl_TerminarDepois.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.Lbl_TerminarDepois.AutoSize = true;
            this.Lbl_TerminarDepois.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TerminarDepois.ForeColor = System.Drawing.Color.White;
            this.Lbl_TerminarDepois.Location = new System.Drawing.Point(13, 11);
            this.Lbl_TerminarDepois.Name = "Lbl_TerminarDepois";
            this.Lbl_TerminarDepois.Size = new System.Drawing.Size(166, 25);
            this.Lbl_TerminarDepois.TabIndex = 0;
            this.Lbl_TerminarDepois.Text = "Preencher Depois ";
            // 
            // Pnl_Grafico
            // 
            this.Pnl_Grafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_Grafico.Controls.Add(this.Lbl_Grafico);
            this.Pnl_Grafico.Location = new System.Drawing.Point(293, 164);
            this.Pnl_Grafico.Name = "Pnl_Grafico";
            this.Pnl_Grafico.Size = new System.Drawing.Size(437, 206);
            this.Pnl_Grafico.TabIndex = 10;
            // 
            // Lbl_Grafico
            // 
            this.Lbl_Grafico.AutoSize = true;
            this.Lbl_Grafico.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Grafico.ForeColor = System.Drawing.Color.White;
            this.Lbl_Grafico.Location = new System.Drawing.Point(13, 11);
            this.Lbl_Grafico.Name = "Lbl_Grafico";
            this.Lbl_Grafico.Size = new System.Drawing.Size(73, 25);
            this.Lbl_Grafico.TabIndex = 0;
            this.Lbl_Grafico.Text = "Gráfico";
            // 
            // Pnl_Comparacao
            // 
            this.Pnl_Comparacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_Comparacao.Controls.Add(this.Lbl_ultimostrintadiascomparacao);
            this.Pnl_Comparacao.Controls.Add(this.Cpb_comparacao);
            this.Pnl_Comparacao.Controls.Add(this.Lbl_Comparacao);
            this.Pnl_Comparacao.Location = new System.Drawing.Point(12, 164);
            this.Pnl_Comparacao.Name = "Pnl_Comparacao";
            this.Pnl_Comparacao.Size = new System.Drawing.Size(258, 298);
            this.Pnl_Comparacao.TabIndex = 11;
            // 
            // Lbl_ultimostrintadiascomparacao
            // 
            this.Lbl_ultimostrintadiascomparacao.AutoSize = true;
            this.Lbl_ultimostrintadiascomparacao.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ultimostrintadiascomparacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_ultimostrintadiascomparacao.Location = new System.Drawing.Point(15, 270);
            this.Lbl_ultimostrintadiascomparacao.Name = "Lbl_ultimostrintadiascomparacao";
            this.Lbl_ultimostrintadiascomparacao.Size = new System.Drawing.Size(99, 17);
            this.Lbl_ultimostrintadiascomparacao.TabIndex = 3;
            this.Lbl_ultimostrintadiascomparacao.Text = "Últimos 30 Dias";
            this.Lbl_ultimostrintadiascomparacao.Click += new System.EventHandler(this.Lbl_ultimostrintadiascomparacao_Click);
            // 
            // Cpb_comparacao
            // 
            this.Cpb_comparacao.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Cpb_comparacao.AnimationSpeed = 500;
            this.Cpb_comparacao.BackColor = System.Drawing.Color.Transparent;
            this.Cpb_comparacao.Font = new System.Drawing.Font("Microsoft YaHei", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpb_comparacao.ForeColor = System.Drawing.Color.White;
            this.Cpb_comparacao.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Cpb_comparacao.InnerMargin = 2;
            this.Cpb_comparacao.InnerWidth = -1;
            this.Cpb_comparacao.Location = new System.Drawing.Point(35, 73);
            this.Cpb_comparacao.MarqueeAnimationSpeed = 2000;
            this.Cpb_comparacao.Name = "Cpb_comparacao";
            this.Cpb_comparacao.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cpb_comparacao.OuterMargin = -25;
            this.Cpb_comparacao.OuterWidth = 26;
            this.Cpb_comparacao.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(249)))));
            this.Cpb_comparacao.ProgressWidth = 7;
            this.Cpb_comparacao.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Cpb_comparacao.Size = new System.Drawing.Size(174, 173);
            this.Cpb_comparacao.StartAngle = 270;
            this.Cpb_comparacao.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Cpb_comparacao.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Cpb_comparacao.SubscriptText = "";
            this.Cpb_comparacao.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Cpb_comparacao.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Cpb_comparacao.SuperscriptText = "";
            this.Cpb_comparacao.TabIndex = 1;
            this.Cpb_comparacao.Text = "67%";
            this.Cpb_comparacao.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.Cpb_comparacao.Value = 68;
            // 
            // Lbl_Comparacao
            // 
            this.Lbl_Comparacao.AutoSize = true;
            this.Lbl_Comparacao.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Comparacao.ForeColor = System.Drawing.Color.White;
            this.Lbl_Comparacao.Location = new System.Drawing.Point(13, 18);
            this.Lbl_Comparacao.Name = "Lbl_Comparacao";
            this.Lbl_Comparacao.Size = new System.Drawing.Size(119, 25);
            this.Lbl_Comparacao.TabIndex = 0;
            this.Lbl_Comparacao.Text = "Comparação";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Lbl_ConsumoAnterior);
            this.panel1.Location = new System.Drawing.Point(293, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 130);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(15, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Último Mês";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "168,1 kWh";
            // 
            // Lbl_ConsumoAnterior
            // 
            this.Lbl_ConsumoAnterior.AutoSize = true;
            this.Lbl_ConsumoAnterior.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ConsumoAnterior.ForeColor = System.Drawing.Color.White;
            this.Lbl_ConsumoAnterior.Location = new System.Drawing.Point(13, 11);
            this.Lbl_ConsumoAnterior.Name = "Lbl_ConsumoAnterior";
            this.Lbl_ConsumoAnterior.Size = new System.Drawing.Size(166, 25);
            this.Lbl_ConsumoAnterior.TabIndex = 0;
            this.Lbl_ConsumoAnterior.Text = "Consumo Anterior";
            // 
            // Pnl_
            // 
            this.Pnl_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_.Controls.Add(this.Lbl_UltimosTrintaDias);
            this.Pnl_.Controls.Add(this.Lbl_KwhAtual);
            this.Pnl_.Controls.Add(this.Lbl_CosumoAtual);
            this.Pnl_.Location = new System.Drawing.Point(12, 12);
            this.Pnl_.Name = "Pnl_";
            this.Pnl_.Size = new System.Drawing.Size(258, 130);
            this.Pnl_.TabIndex = 6;
            // 
            // Lbl_UltimosTrintaDias
            // 
            this.Lbl_UltimosTrintaDias.AutoSize = true;
            this.Lbl_UltimosTrintaDias.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UltimosTrintaDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_UltimosTrintaDias.Location = new System.Drawing.Point(15, 102);
            this.Lbl_UltimosTrintaDias.Name = "Lbl_UltimosTrintaDias";
            this.Lbl_UltimosTrintaDias.Size = new System.Drawing.Size(99, 17);
            this.Lbl_UltimosTrintaDias.TabIndex = 2;
            this.Lbl_UltimosTrintaDias.Text = "Últimos 30 Dias";
            // 
            // Lbl_KwhAtual
            // 
            this.Lbl_KwhAtual.AutoSize = true;
            this.Lbl_KwhAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_KwhAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.Lbl_KwhAtual.Location = new System.Drawing.Point(12, 51);
            this.Lbl_KwhAtual.Name = "Lbl_KwhAtual";
            this.Lbl_KwhAtual.Size = new System.Drawing.Size(158, 32);
            this.Lbl_KwhAtual.TabIndex = 1;
            this.Lbl_KwhAtual.Text = "152,2 kWh";
            // 
            // Lbl_CosumoAtual
            // 
            this.Lbl_CosumoAtual.AutoSize = true;
            this.Lbl_CosumoAtual.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CosumoAtual.ForeColor = System.Drawing.Color.White;
            this.Lbl_CosumoAtual.Location = new System.Drawing.Point(13, 11);
            this.Lbl_CosumoAtual.Name = "Lbl_CosumoAtual";
            this.Lbl_CosumoAtual.Size = new System.Drawing.Size(141, 25);
            this.Lbl_CosumoAtual.TabIndex = 0;
            this.Lbl_CosumoAtual.Text = "Consumo Atual";
            // 
            // Frm_Dashboard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(768, 532);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Pnl_Grafico);
            this.Controls.Add(this.Pnl_Comparacao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Dashboard1";
            this.Text = "Frm_Dashboard1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Pnl_Grafico.ResumeLayout(false);
            this.Pnl_Grafico.PerformLayout();
            this.Pnl_Comparacao.ResumeLayout(false);
            this.Pnl_Comparacao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pnl_.ResumeLayout(false);
            this.Pnl_.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_Preencher;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_TerminarDepois;
        private System.Windows.Forms.Panel Pnl_Grafico;
        private System.Windows.Forms.Label Lbl_Grafico;
        private System.Windows.Forms.Panel Pnl_Comparacao;
        private System.Windows.Forms.Label Lbl_ultimostrintadiascomparacao;
        private CircularProgressBar.CircularProgressBar Cpb_comparacao;
        private System.Windows.Forms.Label Lbl_Comparacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_ConsumoAnterior;
        private System.Windows.Forms.Panel Pnl_;
        private System.Windows.Forms.Label Lbl_UltimosTrintaDias;
        private System.Windows.Forms.Label Lbl_KwhAtual;
        private System.Windows.Forms.Label Lbl_CosumoAtual;
    }
}