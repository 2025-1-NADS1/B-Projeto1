namespace WindowsFormsApp1
{
    partial class Frm_Piscina
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.Pnl_Gastos = new System.Windows.Forms.Panel();
            this.Lbl_PiscinaGastos = new System.Windows.Forms.Label();
            this.Lbl_MesAtualTotalPiscina = new System.Windows.Forms.Label();
            this.Lbl_GastosPiscina = new System.Windows.Forms.Label();
            this.Pnl_Grafico = new System.Windows.Forms.Panel();
            this.Btn_GerarGraficoTotal = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Lbl_GraficoPiscina = new System.Windows.Forms.Label();
            this.Pnl_Comparacao = new System.Windows.Forms.Panel();
            this.Lbl_MesAnteriorcomparacaoPiscina = new System.Windows.Forms.Label();
            this.Cpb_comparacao = new CircularProgressBar.CircularProgressBar();
            this.Lbl_ComparacaoPiscina = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_UltimoMesPiscina = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_ConsumoAnteriorPiscina = new System.Windows.Forms.Label();
            this.Pnl_ConsumoAtual = new System.Windows.Forms.Panel();
            this.Lbl_MesAtualPiscina = new System.Windows.Forms.Label();
            this.Lbl_KwhAtualPiscina = new System.Windows.Forms.Label();
            this.Lbl_CosumoAtualPiscina = new System.Windows.Forms.Label();
            this.Pnl_Gastos.SuspendLayout();
            this.Pnl_Grafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Pnl_Comparacao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnl_ConsumoAtual.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Gastos
            // 
            this.Pnl_Gastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_Gastos.Controls.Add(this.Lbl_PiscinaGastos);
            this.Pnl_Gastos.Controls.Add(this.Lbl_MesAtualTotalPiscina);
            this.Pnl_Gastos.Controls.Add(this.Lbl_GastosPiscina);
            this.Pnl_Gastos.Location = new System.Drawing.Point(252, 12);
            this.Pnl_Gastos.Name = "Pnl_Gastos";
            this.Pnl_Gastos.Size = new System.Drawing.Size(216, 130);
            this.Pnl_Gastos.TabIndex = 32;
            // 
            // Lbl_PiscinaGastos
            // 
            this.Lbl_PiscinaGastos.AutoSize = true;
            this.Lbl_PiscinaGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.Lbl_PiscinaGastos.ForeColor = System.Drawing.Color.OrangeRed;
            this.Lbl_PiscinaGastos.Location = new System.Drawing.Point(15, 52);
            this.Lbl_PiscinaGastos.Name = "Lbl_PiscinaGastos";
            this.Lbl_PiscinaGastos.Size = new System.Drawing.Size(154, 32);
            this.Lbl_PiscinaGastos.TabIndex = 4;
            this.Lbl_PiscinaGastos.Text = "R$ 178,89";
            // 
            // Lbl_MesAtualTotalPiscina
            // 
            this.Lbl_MesAtualTotalPiscina.AutoSize = true;
            this.Lbl_MesAtualTotalPiscina.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MesAtualTotalPiscina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_MesAtualTotalPiscina.Location = new System.Drawing.Point(15, 102);
            this.Lbl_MesAtualTotalPiscina.Name = "Lbl_MesAtualTotalPiscina";
            this.Lbl_MesAtualTotalPiscina.Size = new System.Drawing.Size(66, 17);
            this.Lbl_MesAtualTotalPiscina.TabIndex = 3;
            this.Lbl_MesAtualTotalPiscina.Text = "Mês Atual";
            // 
            // Lbl_GastosPiscina
            // 
            this.Lbl_GastosPiscina.AutoSize = true;
            this.Lbl_GastosPiscina.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GastosPiscina.ForeColor = System.Drawing.Color.White;
            this.Lbl_GastosPiscina.Location = new System.Drawing.Point(13, 11);
            this.Lbl_GastosPiscina.Name = "Lbl_GastosPiscina";
            this.Lbl_GastosPiscina.Size = new System.Drawing.Size(68, 25);
            this.Lbl_GastosPiscina.TabIndex = 0;
            this.Lbl_GastosPiscina.Text = "Gastos";
            // 
            // Pnl_Grafico
            // 
            this.Pnl_Grafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_Grafico.Controls.Add(this.Btn_GerarGraficoTotal);
            this.Pnl_Grafico.Controls.Add(this.chart1);
            this.Pnl_Grafico.Controls.Add(this.Lbl_GraficoPiscina);
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
            this.Btn_GerarGraficoTotal.Click += new System.EventHandler(this.Btn_GerarGraficoTotal_Click_1);
            // 
            // chart1
            // 
            this.chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Graphics;
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(22, 51);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chart1.Size = new System.Drawing.Size(389, 205);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Grafico Consumo";
            // 
            // Lbl_GraficoPiscina
            // 
            this.Lbl_GraficoPiscina.AutoSize = true;
            this.Lbl_GraficoPiscina.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GraficoPiscina.ForeColor = System.Drawing.Color.White;
            this.Lbl_GraficoPiscina.Location = new System.Drawing.Point(13, 11);
            this.Lbl_GraficoPiscina.Name = "Lbl_GraficoPiscina";
            this.Lbl_GraficoPiscina.Size = new System.Drawing.Size(73, 25);
            this.Lbl_GraficoPiscina.TabIndex = 0;
            this.Lbl_GraficoPiscina.Text = "Gráfico";
            // 
            // Pnl_Comparacao
            // 
            this.Pnl_Comparacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_Comparacao.Controls.Add(this.Lbl_MesAnteriorcomparacaoPiscina);
            this.Pnl_Comparacao.Controls.Add(this.Cpb_comparacao);
            this.Pnl_Comparacao.Controls.Add(this.Lbl_ComparacaoPiscina);
            this.Pnl_Comparacao.Location = new System.Drawing.Point(12, 166);
            this.Pnl_Comparacao.Name = "Pnl_Comparacao";
            this.Pnl_Comparacao.Size = new System.Drawing.Size(258, 298);
            this.Pnl_Comparacao.TabIndex = 34;
            // 
            // Lbl_MesAnteriorcomparacaoPiscina
            // 
            this.Lbl_MesAnteriorcomparacaoPiscina.AutoSize = true;
            this.Lbl_MesAnteriorcomparacaoPiscina.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MesAnteriorcomparacaoPiscina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_MesAnteriorcomparacaoPiscina.Location = new System.Drawing.Point(15, 270);
            this.Lbl_MesAnteriorcomparacaoPiscina.Name = "Lbl_MesAnteriorcomparacaoPiscina";
            this.Lbl_MesAnteriorcomparacaoPiscina.Size = new System.Drawing.Size(124, 17);
            this.Lbl_MesAnteriorcomparacaoPiscina.TabIndex = 3;
            this.Lbl_MesAnteriorcomparacaoPiscina.Text = "Últimos Dois Meses";
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
            this.Cpb_comparacao.Text = "3,83%";
            this.Cpb_comparacao.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.Cpb_comparacao.Value = 68;
            // 
            // Lbl_ComparacaoPiscina
            // 
            this.Lbl_ComparacaoPiscina.AutoSize = true;
            this.Lbl_ComparacaoPiscina.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ComparacaoPiscina.ForeColor = System.Drawing.Color.White;
            this.Lbl_ComparacaoPiscina.Location = new System.Drawing.Point(13, 18);
            this.Lbl_ComparacaoPiscina.Name = "Lbl_ComparacaoPiscina";
            this.Lbl_ComparacaoPiscina.Size = new System.Drawing.Size(119, 25);
            this.Lbl_ComparacaoPiscina.TabIndex = 0;
            this.Lbl_ComparacaoPiscina.Text = "Comparação";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Lbl_UltimoMesPiscina);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Lbl_ConsumoAnteriorPiscina);
            this.panel1.Location = new System.Drawing.Point(488, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 130);
            this.panel1.TabIndex = 31;
            // 
            // Lbl_UltimoMesPiscina
            // 
            this.Lbl_UltimoMesPiscina.AutoSize = true;
            this.Lbl_UltimoMesPiscina.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UltimoMesPiscina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_UltimoMesPiscina.Location = new System.Drawing.Point(15, 102);
            this.Lbl_UltimoMesPiscina.Name = "Lbl_UltimoMesPiscina";
            this.Lbl_UltimoMesPiscina.Size = new System.Drawing.Size(75, 17);
            this.Lbl_UltimoMesPiscina.TabIndex = 2;
            this.Lbl_UltimoMesPiscina.Text = "Último Mês";
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
            this.label3.Text = "281,64 kWh";
            // 
            // Lbl_ConsumoAnteriorPiscina
            // 
            this.Lbl_ConsumoAnteriorPiscina.AutoSize = true;
            this.Lbl_ConsumoAnteriorPiscina.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ConsumoAnteriorPiscina.ForeColor = System.Drawing.Color.White;
            this.Lbl_ConsumoAnteriorPiscina.Location = new System.Drawing.Point(13, 11);
            this.Lbl_ConsumoAnteriorPiscina.Name = "Lbl_ConsumoAnteriorPiscina";
            this.Lbl_ConsumoAnteriorPiscina.Size = new System.Drawing.Size(166, 25);
            this.Lbl_ConsumoAnteriorPiscina.TabIndex = 0;
            this.Lbl_ConsumoAnteriorPiscina.Text = "Consumo Anterior";
            // 
            // Pnl_ConsumoAtual
            // 
            this.Pnl_ConsumoAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_ConsumoAtual.Controls.Add(this.Lbl_MesAtualPiscina);
            this.Pnl_ConsumoAtual.Controls.Add(this.Lbl_KwhAtualPiscina);
            this.Pnl_ConsumoAtual.Controls.Add(this.Lbl_CosumoAtualPiscina);
            this.Pnl_ConsumoAtual.Location = new System.Drawing.Point(12, 12);
            this.Pnl_ConsumoAtual.Name = "Pnl_ConsumoAtual";
            this.Pnl_ConsumoAtual.Size = new System.Drawing.Size(221, 130);
            this.Pnl_ConsumoAtual.TabIndex = 30;
            // 
            // Lbl_MesAtualPiscina
            // 
            this.Lbl_MesAtualPiscina.AutoSize = true;
            this.Lbl_MesAtualPiscina.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MesAtualPiscina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_MesAtualPiscina.Location = new System.Drawing.Point(15, 102);
            this.Lbl_MesAtualPiscina.Name = "Lbl_MesAtualPiscina";
            this.Lbl_MesAtualPiscina.Size = new System.Drawing.Size(66, 17);
            this.Lbl_MesAtualPiscina.TabIndex = 2;
            this.Lbl_MesAtualPiscina.Text = "Mês Atual";
            // 
            // Lbl_KwhAtualPiscina
            // 
            this.Lbl_KwhAtualPiscina.AutoSize = true;
            this.Lbl_KwhAtualPiscina.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_KwhAtualPiscina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.Lbl_KwhAtualPiscina.Location = new System.Drawing.Point(12, 51);
            this.Lbl_KwhAtualPiscina.Name = "Lbl_KwhAtualPiscina";
            this.Lbl_KwhAtualPiscina.Size = new System.Drawing.Size(175, 32);
            this.Lbl_KwhAtualPiscina.TabIndex = 1;
            this.Lbl_KwhAtualPiscina.Text = "271,05 kWh";
            // 
            // Lbl_CosumoAtualPiscina
            // 
            this.Lbl_CosumoAtualPiscina.AutoSize = true;
            this.Lbl_CosumoAtualPiscina.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CosumoAtualPiscina.ForeColor = System.Drawing.Color.White;
            this.Lbl_CosumoAtualPiscina.Location = new System.Drawing.Point(13, 11);
            this.Lbl_CosumoAtualPiscina.Name = "Lbl_CosumoAtualPiscina";
            this.Lbl_CosumoAtualPiscina.Size = new System.Drawing.Size(141, 25);
            this.Lbl_CosumoAtualPiscina.TabIndex = 0;
            this.Lbl_CosumoAtualPiscina.Text = "Consumo Atual";
            // 
            // Frm_Piscina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.Pnl_Gastos);
            this.Controls.Add(this.Pnl_Grafico);
            this.Controls.Add(this.Pnl_Comparacao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl_ConsumoAtual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Piscina";
            this.Text = "Frm_Configuracoes";
            this.Pnl_Gastos.ResumeLayout(false);
            this.Pnl_Gastos.PerformLayout();
            this.Pnl_Grafico.ResumeLayout(false);
            this.Pnl_Grafico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Pnl_Comparacao.ResumeLayout(false);
            this.Pnl_Comparacao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pnl_ConsumoAtual.ResumeLayout(false);
            this.Pnl_ConsumoAtual.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Gastos;
        private System.Windows.Forms.Label Lbl_PiscinaGastos;
        private System.Windows.Forms.Label Lbl_MesAtualTotalPiscina;
        private System.Windows.Forms.Label Lbl_GastosPiscina;
        private System.Windows.Forms.Panel Pnl_Grafico;
        private System.Windows.Forms.Button Btn_GerarGraficoTotal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label Lbl_GraficoPiscina;
        private System.Windows.Forms.Panel Pnl_Comparacao;
        private System.Windows.Forms.Label Lbl_MesAnteriorcomparacaoPiscina;
        private CircularProgressBar.CircularProgressBar Cpb_comparacao;
        private System.Windows.Forms.Label Lbl_ComparacaoPiscina;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_UltimoMesPiscina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_ConsumoAnteriorPiscina;
        private System.Windows.Forms.Panel Pnl_ConsumoAtual;
        private System.Windows.Forms.Label Lbl_MesAtualPiscina;
        private System.Windows.Forms.Label Lbl_KwhAtualPiscina;
        private System.Windows.Forms.Label Lbl_CosumoAtualPiscina;
    }
}