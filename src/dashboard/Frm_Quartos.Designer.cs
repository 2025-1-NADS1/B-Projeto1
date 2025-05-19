namespace WindowsFormsApp1
{
    partial class Frm_Quartos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_UltimoMesQuartosGastos = new System.Windows.Forms.Label();
            this.Lbl_GastosQuartos = new System.Windows.Forms.Label();
            this.Pnl_Grafico = new System.Windows.Forms.Panel();
            this.Btn_GerarGraficoTotal = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Lbl_GraficoQuartos = new System.Windows.Forms.Label();
            this.Pnl_Comparacao = new System.Windows.Forms.Panel();
            this.Lbl_ultimostrintadiascomparacaoQuartos = new System.Windows.Forms.Label();
            this.Cpb_comparacao = new CircularProgressBar.CircularProgressBar();
            this.Lbl_ComparacaoQuartos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_UltimoMesQuartos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_ConsumoAnteriorQuartos = new System.Windows.Forms.Label();
            this.Pnl_ = new System.Windows.Forms.Panel();
            this.Lbl_UltimosTrintaDiasQuartos = new System.Windows.Forms.Label();
            this.Lbl_KwhAtual = new System.Windows.Forms.Label();
            this.Lbl_CosumoAtualQuartos = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.Pnl_Grafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Pnl_Comparacao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnl_.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Lbl_UltimoMesQuartosGastos);
            this.panel2.Controls.Add(this.Lbl_GastosQuartos);
            this.panel2.Location = new System.Drawing.Point(253, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 130);
            this.panel2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "R$ 73,72";
            // 
            // Lbl_UltimoMesQuartosGastos
            // 
            this.Lbl_UltimoMesQuartosGastos.AutoSize = true;
            this.Lbl_UltimoMesQuartosGastos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UltimoMesQuartosGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_UltimoMesQuartosGastos.Location = new System.Drawing.Point(15, 102);
            this.Lbl_UltimoMesQuartosGastos.Name = "Lbl_UltimoMesQuartosGastos";
            this.Lbl_UltimoMesQuartosGastos.Size = new System.Drawing.Size(66, 17);
            this.Lbl_UltimoMesQuartosGastos.TabIndex = 3;
            this.Lbl_UltimoMesQuartosGastos.Text = "Mês Atual";
            // 
            // Lbl_GastosQuartos
            // 
            this.Lbl_GastosQuartos.AutoSize = true;
            this.Lbl_GastosQuartos.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GastosQuartos.ForeColor = System.Drawing.Color.White;
            this.Lbl_GastosQuartos.Location = new System.Drawing.Point(13, 11);
            this.Lbl_GastosQuartos.Name = "Lbl_GastosQuartos";
            this.Lbl_GastosQuartos.Size = new System.Drawing.Size(68, 25);
            this.Lbl_GastosQuartos.TabIndex = 0;
            this.Lbl_GastosQuartos.Text = "Gastos";
            // 
            // Pnl_Grafico
            // 
            this.Pnl_Grafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_Grafico.Controls.Add(this.Btn_GerarGraficoTotal);
            this.Pnl_Grafico.Controls.Add(this.chart1);
            this.Pnl_Grafico.Controls.Add(this.Lbl_GraficoQuartos);
            this.Pnl_Grafico.Location = new System.Drawing.Point(284, 166);
            this.Pnl_Grafico.Name = "Pnl_Grafico";
            this.Pnl_Grafico.Size = new System.Drawing.Size(437, 298);
            this.Pnl_Grafico.TabIndex = 33;
            // 
            // Btn_GerarGraficoTotal
            // 
            this.Btn_GerarGraficoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Btn_GerarGraficoTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GerarGraficoTotal.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_GerarGraficoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_GerarGraficoTotal.Location = new System.Drawing.Point(22, 262);
            this.Btn_GerarGraficoTotal.Name = "Btn_GerarGraficoTotal";
            this.Btn_GerarGraficoTotal.Size = new System.Drawing.Size(131, 25);
            this.Btn_GerarGraficoTotal.TabIndex = 31;
            this.Btn_GerarGraficoTotal.Text = "Gerar Gráfico";
            this.Btn_GerarGraficoTotal.UseVisualStyleBackColor = false;
            this.Btn_GerarGraficoTotal.Click += new System.EventHandler(this.Btn_GerarGraficoTotal_Click);
            // 
            // chart1
            // 
            this.chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Graphics;
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.Location = new System.Drawing.Point(22, 51);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chart1.Size = new System.Drawing.Size(389, 205);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Grafico Consumo";
            // 
            // Lbl_GraficoQuartos
            // 
            this.Lbl_GraficoQuartos.AutoSize = true;
            this.Lbl_GraficoQuartos.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GraficoQuartos.ForeColor = System.Drawing.Color.White;
            this.Lbl_GraficoQuartos.Location = new System.Drawing.Point(13, 11);
            this.Lbl_GraficoQuartos.Name = "Lbl_GraficoQuartos";
            this.Lbl_GraficoQuartos.Size = new System.Drawing.Size(73, 25);
            this.Lbl_GraficoQuartos.TabIndex = 0;
            this.Lbl_GraficoQuartos.Text = "Gráfico";
            // 
            // Pnl_Comparacao
            // 
            this.Pnl_Comparacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_Comparacao.Controls.Add(this.Lbl_ultimostrintadiascomparacaoQuartos);
            this.Pnl_Comparacao.Controls.Add(this.Cpb_comparacao);
            this.Pnl_Comparacao.Controls.Add(this.Lbl_ComparacaoQuartos);
            this.Pnl_Comparacao.Location = new System.Drawing.Point(12, 166);
            this.Pnl_Comparacao.Name = "Pnl_Comparacao";
            this.Pnl_Comparacao.Size = new System.Drawing.Size(258, 298);
            this.Pnl_Comparacao.TabIndex = 34;
            // 
            // Lbl_ultimostrintadiascomparacaoQuartos
            // 
            this.Lbl_ultimostrintadiascomparacaoQuartos.AutoSize = true;
            this.Lbl_ultimostrintadiascomparacaoQuartos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ultimostrintadiascomparacaoQuartos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_ultimostrintadiascomparacaoQuartos.Location = new System.Drawing.Point(15, 270);
            this.Lbl_ultimostrintadiascomparacaoQuartos.Name = "Lbl_ultimostrintadiascomparacaoQuartos";
            this.Lbl_ultimostrintadiascomparacaoQuartos.Size = new System.Drawing.Size(124, 17);
            this.Lbl_ultimostrintadiascomparacaoQuartos.TabIndex = 3;
            this.Lbl_ultimostrintadiascomparacaoQuartos.Text = "Últimos Dois Meses";
            // 
            // Cpb_comparacao
            // 
            this.Cpb_comparacao.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Cpb_comparacao.AnimationSpeed = 500;
            this.Cpb_comparacao.BackColor = System.Drawing.Color.Transparent;
            this.Cpb_comparacao.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Cpb_comparacao.ProgressColor = System.Drawing.Color.Red;
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
            this.Cpb_comparacao.Text = "3,40%";
            this.Cpb_comparacao.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.Cpb_comparacao.Value = 68;
            // 
            // Lbl_ComparacaoQuartos
            // 
            this.Lbl_ComparacaoQuartos.AutoSize = true;
            this.Lbl_ComparacaoQuartos.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ComparacaoQuartos.ForeColor = System.Drawing.Color.White;
            this.Lbl_ComparacaoQuartos.Location = new System.Drawing.Point(13, 18);
            this.Lbl_ComparacaoQuartos.Name = "Lbl_ComparacaoQuartos";
            this.Lbl_ComparacaoQuartos.Size = new System.Drawing.Size(119, 25);
            this.Lbl_ComparacaoQuartos.TabIndex = 0;
            this.Lbl_ComparacaoQuartos.Text = "Comparação";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Lbl_UltimoMesQuartos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Lbl_ConsumoAnteriorQuartos);
            this.panel1.Location = new System.Drawing.Point(488, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 130);
            this.panel1.TabIndex = 31;
            // 
            // Lbl_UltimoMesQuartos
            // 
            this.Lbl_UltimoMesQuartos.AutoSize = true;
            this.Lbl_UltimoMesQuartos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UltimoMesQuartos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_UltimoMesQuartos.Location = new System.Drawing.Point(15, 102);
            this.Lbl_UltimoMesQuartos.Name = "Lbl_UltimoMesQuartos";
            this.Lbl_UltimoMesQuartos.Size = new System.Drawing.Size(75, 17);
            this.Lbl_UltimoMesQuartos.TabIndex = 2;
            this.Lbl_UltimoMesQuartos.Text = "Último Mês";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "107,97 kWh";
            // 
            // Lbl_ConsumoAnteriorQuartos
            // 
            this.Lbl_ConsumoAnteriorQuartos.AutoSize = true;
            this.Lbl_ConsumoAnteriorQuartos.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ConsumoAnteriorQuartos.ForeColor = System.Drawing.Color.White;
            this.Lbl_ConsumoAnteriorQuartos.Location = new System.Drawing.Point(13, 11);
            this.Lbl_ConsumoAnteriorQuartos.Name = "Lbl_ConsumoAnteriorQuartos";
            this.Lbl_ConsumoAnteriorQuartos.Size = new System.Drawing.Size(166, 25);
            this.Lbl_ConsumoAnteriorQuartos.TabIndex = 0;
            this.Lbl_ConsumoAnteriorQuartos.Text = "Consumo Anterior";
            // 
            // Pnl_
            // 
            this.Pnl_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_.Controls.Add(this.Lbl_UltimosTrintaDiasQuartos);
            this.Pnl_.Controls.Add(this.Lbl_KwhAtual);
            this.Pnl_.Controls.Add(this.Lbl_CosumoAtualQuartos);
            this.Pnl_.Location = new System.Drawing.Point(12, 12);
            this.Pnl_.Name = "Pnl_";
            this.Pnl_.Size = new System.Drawing.Size(221, 130);
            this.Pnl_.TabIndex = 30;
            // 
            // Lbl_UltimosTrintaDiasQuartos
            // 
            this.Lbl_UltimosTrintaDiasQuartos.AutoSize = true;
            this.Lbl_UltimosTrintaDiasQuartos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UltimosTrintaDiasQuartos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_UltimosTrintaDiasQuartos.Location = new System.Drawing.Point(15, 102);
            this.Lbl_UltimosTrintaDiasQuartos.Name = "Lbl_UltimosTrintaDiasQuartos";
            this.Lbl_UltimosTrintaDiasQuartos.Size = new System.Drawing.Size(66, 17);
            this.Lbl_UltimosTrintaDiasQuartos.TabIndex = 2;
            this.Lbl_UltimosTrintaDiasQuartos.Text = "Mês Atual";
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
            this.Lbl_KwhAtual.Text = "111,7 kWh";
            // 
            // Lbl_CosumoAtualQuartos
            // 
            this.Lbl_CosumoAtualQuartos.AutoSize = true;
            this.Lbl_CosumoAtualQuartos.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CosumoAtualQuartos.ForeColor = System.Drawing.Color.White;
            this.Lbl_CosumoAtualQuartos.Location = new System.Drawing.Point(13, 11);
            this.Lbl_CosumoAtualQuartos.Name = "Lbl_CosumoAtualQuartos";
            this.Lbl_CosumoAtualQuartos.Size = new System.Drawing.Size(141, 25);
            this.Lbl_CosumoAtualQuartos.TabIndex = 0;
            this.Lbl_CosumoAtualQuartos.Text = "Consumo Atual";
            // 
            // Frm_Quartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pnl_Grafico);
            this.Controls.Add(this.Pnl_Comparacao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Quartos";
            this.Text = "Frm_Calendario";
            this.Load += new System.EventHandler(this.Frm_Quartos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Pnl_Grafico.ResumeLayout(false);
            this.Pnl_Grafico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_UltimoMesQuartosGastos;
        private System.Windows.Forms.Label Lbl_GastosQuartos;
        private System.Windows.Forms.Panel Pnl_Grafico;
        private System.Windows.Forms.Button Btn_GerarGraficoTotal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label Lbl_GraficoQuartos;
        private System.Windows.Forms.Panel Pnl_Comparacao;
        private System.Windows.Forms.Label Lbl_ultimostrintadiascomparacaoQuartos;
        private CircularProgressBar.CircularProgressBar Cpb_comparacao;
        private System.Windows.Forms.Label Lbl_ComparacaoQuartos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_UltimoMesQuartos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_ConsumoAnteriorQuartos;
        private System.Windows.Forms.Panel Pnl_;
        private System.Windows.Forms.Label Lbl_UltimosTrintaDiasQuartos;
        private System.Windows.Forms.Label Lbl_KwhAtual;
        private System.Windows.Forms.Label Lbl_CosumoAtualQuartos;
    }
}