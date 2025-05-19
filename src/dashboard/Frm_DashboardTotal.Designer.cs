namespace WindowsFormsApp1
{
    partial class Frm_DashboardTotal
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_MesAtualTotalGastos = new System.Windows.Forms.Label();
            this.Lbl_GastosTotal = new System.Windows.Forms.Label();
            this.Pnl_Grafico = new System.Windows.Forms.Panel();
            this.Btn_GerarGraficoTotal = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Lbl_GraficoTotal = new System.Windows.Forms.Label();
            this.Pnl_Comparacao = new System.Windows.Forms.Panel();
            this.Lbl_MesAnteriorcomparacaoTotal = new System.Windows.Forms.Label();
            this.Cpb_comparacao = new CircularProgressBar.CircularProgressBar();
            this.Lbl_ComparacaoTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_UltimoMesTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_ConsumoAnteriorTotal = new System.Windows.Forms.Label();
            this.Pnl_ConsumoAtual = new System.Windows.Forms.Panel();
            this.Lbl_MesAtualTotal = new System.Windows.Forms.Label();
            this.Lbl_KwhAtualTotal = new System.Windows.Forms.Label();
            this.Lbl_CosumoAtualTotal = new System.Windows.Forms.Label();
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
            this.Pnl_Gastos.Controls.Add(this.label1);
            this.Pnl_Gastos.Controls.Add(this.Lbl_MesAtualTotalGastos);
            this.Pnl_Gastos.Controls.Add(this.Lbl_GastosTotal);
            this.Pnl_Gastos.Location = new System.Drawing.Point(252, 12);
            this.Pnl_Gastos.Name = "Pnl_Gastos";
            this.Pnl_Gastos.Size = new System.Drawing.Size(216, 130);
            this.Pnl_Gastos.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "R$ 322,42";
            // 
            // Lbl_MesAtualTotalGastos
            // 
            this.Lbl_MesAtualTotalGastos.AutoSize = true;
            this.Lbl_MesAtualTotalGastos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MesAtualTotalGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_MesAtualTotalGastos.Location = new System.Drawing.Point(15, 102);
            this.Lbl_MesAtualTotalGastos.Name = "Lbl_MesAtualTotalGastos";
            this.Lbl_MesAtualTotalGastos.Size = new System.Drawing.Size(66, 17);
            this.Lbl_MesAtualTotalGastos.TabIndex = 3;
            this.Lbl_MesAtualTotalGastos.Text = "Mês Atual";
            this.Lbl_MesAtualTotalGastos.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_GastosTotal
            // 
            this.Lbl_GastosTotal.AutoSize = true;
            this.Lbl_GastosTotal.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GastosTotal.ForeColor = System.Drawing.Color.White;
            this.Lbl_GastosTotal.Location = new System.Drawing.Point(13, 11);
            this.Lbl_GastosTotal.Name = "Lbl_GastosTotal";
            this.Lbl_GastosTotal.Size = new System.Drawing.Size(68, 25);
            this.Lbl_GastosTotal.TabIndex = 0;
            this.Lbl_GastosTotal.Text = "Gastos";
            // 
            // Pnl_Grafico
            // 
            this.Pnl_Grafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_Grafico.Controls.Add(this.Btn_GerarGraficoTotal);
            this.Pnl_Grafico.Controls.Add(this.chart1);
            this.Pnl_Grafico.Controls.Add(this.Lbl_GraficoTotal);
            this.Pnl_Grafico.Location = new System.Drawing.Point(284, 166);
            this.Pnl_Grafico.Name = "Pnl_Grafico";
            this.Pnl_Grafico.Size = new System.Drawing.Size(437, 298);
            this.Pnl_Grafico.TabIndex = 28;
            this.Pnl_Grafico.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Grafico_Paint);
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
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(22, 51);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chart1.Size = new System.Drawing.Size(389, 205);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Grafico Consumo";
            // 
            // Lbl_GraficoTotal
            // 
            this.Lbl_GraficoTotal.AutoSize = true;
            this.Lbl_GraficoTotal.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GraficoTotal.ForeColor = System.Drawing.Color.White;
            this.Lbl_GraficoTotal.Location = new System.Drawing.Point(13, 11);
            this.Lbl_GraficoTotal.Name = "Lbl_GraficoTotal";
            this.Lbl_GraficoTotal.Size = new System.Drawing.Size(73, 25);
            this.Lbl_GraficoTotal.TabIndex = 0;
            this.Lbl_GraficoTotal.Text = "Gráfico";
            this.Lbl_GraficoTotal.Click += new System.EventHandler(this.Lbl_GraficoTotal_Click);
            // 
            // Pnl_Comparacao
            // 
            this.Pnl_Comparacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_Comparacao.Controls.Add(this.Lbl_MesAnteriorcomparacaoTotal);
            this.Pnl_Comparacao.Controls.Add(this.Cpb_comparacao);
            this.Pnl_Comparacao.Controls.Add(this.Lbl_ComparacaoTotal);
            this.Pnl_Comparacao.Location = new System.Drawing.Point(12, 166);
            this.Pnl_Comparacao.Name = "Pnl_Comparacao";
            this.Pnl_Comparacao.Size = new System.Drawing.Size(258, 298);
            this.Pnl_Comparacao.TabIndex = 29;
            // 
            // Lbl_MesAnteriorcomparacaoTotal
            // 
            this.Lbl_MesAnteriorcomparacaoTotal.AutoSize = true;
            this.Lbl_MesAnteriorcomparacaoTotal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MesAnteriorcomparacaoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_MesAnteriorcomparacaoTotal.Location = new System.Drawing.Point(15, 270);
            this.Lbl_MesAnteriorcomparacaoTotal.Name = "Lbl_MesAnteriorcomparacaoTotal";
            this.Lbl_MesAnteriorcomparacaoTotal.Size = new System.Drawing.Size(124, 17);
            this.Lbl_MesAnteriorcomparacaoTotal.TabIndex = 3;
            this.Lbl_MesAnteriorcomparacaoTotal.Text = "Últimos Dois Meses";
            // 
            // Cpb_comparacao
            // 
            this.Cpb_comparacao.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Cpb_comparacao.AnimationSpeed = 500;
            this.Cpb_comparacao.BackColor = System.Drawing.Color.Transparent;
            this.Cpb_comparacao.Font = new System.Drawing.Font("Microsoft YaHei", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Cpb_comparacao.Text = "4,04%";
            this.Cpb_comparacao.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.Cpb_comparacao.Value = 68;
            // 
            // Lbl_ComparacaoTotal
            // 
            this.Lbl_ComparacaoTotal.AutoSize = true;
            this.Lbl_ComparacaoTotal.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ComparacaoTotal.ForeColor = System.Drawing.Color.White;
            this.Lbl_ComparacaoTotal.Location = new System.Drawing.Point(13, 18);
            this.Lbl_ComparacaoTotal.Name = "Lbl_ComparacaoTotal";
            this.Lbl_ComparacaoTotal.Size = new System.Drawing.Size(119, 25);
            this.Lbl_ComparacaoTotal.TabIndex = 0;
            this.Lbl_ComparacaoTotal.Text = "Comparação";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Lbl_UltimoMesTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Lbl_ConsumoAnteriorTotal);
            this.panel1.Location = new System.Drawing.Point(488, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 130);
            this.panel1.TabIndex = 25;
            // 
            // Lbl_UltimoMesTotal
            // 
            this.Lbl_UltimoMesTotal.AutoSize = true;
            this.Lbl_UltimoMesTotal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UltimoMesTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_UltimoMesTotal.Location = new System.Drawing.Point(15, 102);
            this.Lbl_UltimoMesTotal.Name = "Lbl_UltimoMesTotal";
            this.Lbl_UltimoMesTotal.Size = new System.Drawing.Size(75, 17);
            this.Lbl_UltimoMesTotal.TabIndex = 2;
            this.Lbl_UltimoMesTotal.Text = "Último Mês";
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
            this.label3.Text = "508,67 kWh";
            // 
            // Lbl_ConsumoAnteriorTotal
            // 
            this.Lbl_ConsumoAnteriorTotal.AutoSize = true;
            this.Lbl_ConsumoAnteriorTotal.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ConsumoAnteriorTotal.ForeColor = System.Drawing.Color.White;
            this.Lbl_ConsumoAnteriorTotal.Location = new System.Drawing.Point(13, 11);
            this.Lbl_ConsumoAnteriorTotal.Name = "Lbl_ConsumoAnteriorTotal";
            this.Lbl_ConsumoAnteriorTotal.Size = new System.Drawing.Size(166, 25);
            this.Lbl_ConsumoAnteriorTotal.TabIndex = 0;
            this.Lbl_ConsumoAnteriorTotal.Text = "Consumo Anterior";
            // 
            // Pnl_ConsumoAtual
            // 
            this.Pnl_ConsumoAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_ConsumoAtual.Controls.Add(this.Lbl_MesAtualTotal);
            this.Pnl_ConsumoAtual.Controls.Add(this.Lbl_KwhAtualTotal);
            this.Pnl_ConsumoAtual.Controls.Add(this.Lbl_CosumoAtualTotal);
            this.Pnl_ConsumoAtual.Location = new System.Drawing.Point(12, 12);
            this.Pnl_ConsumoAtual.Name = "Pnl_ConsumoAtual";
            this.Pnl_ConsumoAtual.Size = new System.Drawing.Size(221, 130);
            this.Pnl_ConsumoAtual.TabIndex = 24;
            // 
            // Lbl_MesAtualTotal
            // 
            this.Lbl_MesAtualTotal.AutoSize = true;
            this.Lbl_MesAtualTotal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MesAtualTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_MesAtualTotal.Location = new System.Drawing.Point(15, 102);
            this.Lbl_MesAtualTotal.Name = "Lbl_MesAtualTotal";
            this.Lbl_MesAtualTotal.Size = new System.Drawing.Size(66, 17);
            this.Lbl_MesAtualTotal.TabIndex = 2;
            this.Lbl_MesAtualTotal.Text = "Mês Atual";
            // 
            // Lbl_KwhAtualTotal
            // 
            this.Lbl_KwhAtualTotal.AutoSize = true;
            this.Lbl_KwhAtualTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_KwhAtualTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.Lbl_KwhAtualTotal.Location = new System.Drawing.Point(12, 51);
            this.Lbl_KwhAtualTotal.Name = "Lbl_KwhAtualTotal";
            this.Lbl_KwhAtualTotal.Size = new System.Drawing.Size(175, 32);
            this.Lbl_KwhAtualTotal.TabIndex = 1;
            this.Lbl_KwhAtualTotal.Text = "488,52 kWh";
            this.Lbl_KwhAtualTotal.Click += new System.EventHandler(this.Lbl_KwhAtualTotal_Click);
            // 
            // Lbl_CosumoAtualTotal
            // 
            this.Lbl_CosumoAtualTotal.AutoSize = true;
            this.Lbl_CosumoAtualTotal.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CosumoAtualTotal.ForeColor = System.Drawing.Color.White;
            this.Lbl_CosumoAtualTotal.Location = new System.Drawing.Point(13, 11);
            this.Lbl_CosumoAtualTotal.Name = "Lbl_CosumoAtualTotal";
            this.Lbl_CosumoAtualTotal.Size = new System.Drawing.Size(141, 25);
            this.Lbl_CosumoAtualTotal.TabIndex = 0;
            this.Lbl_CosumoAtualTotal.Text = "Consumo Atual";
            // 
            // Frm_DashboardTotal
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
            this.Name = "Frm_DashboardTotal";
            this.Text = "Frm_DashboardTotal";
            this.Load += new System.EventHandler(this.Frm_DashboardTotal_Load);
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
        private System.Windows.Forms.Label Lbl_GastosTotal;
        private System.Windows.Forms.Panel Pnl_Grafico;
        private System.Windows.Forms.Label Lbl_GraficoTotal;
        private System.Windows.Forms.Panel Pnl_Comparacao;
        private System.Windows.Forms.Label Lbl_MesAnteriorcomparacaoTotal;
        private CircularProgressBar.CircularProgressBar Cpb_comparacao;
        private System.Windows.Forms.Label Lbl_ComparacaoTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_UltimoMesTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_ConsumoAnteriorTotal;
        private System.Windows.Forms.Panel Pnl_ConsumoAtual;
        private System.Windows.Forms.Label Lbl_MesAtualTotal;
        private System.Windows.Forms.Label Lbl_KwhAtualTotal;
        private System.Windows.Forms.Label Lbl_CosumoAtualTotal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Btn_GerarGraficoTotal;
        private System.Windows.Forms.Label Lbl_MesAtualTotalGastos;
        private System.Windows.Forms.Label label1;
    }
}