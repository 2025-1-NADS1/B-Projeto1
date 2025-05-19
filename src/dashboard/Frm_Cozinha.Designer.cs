namespace WindowsFormsApp1
{
    partial class Frm_Cozinha
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.Pnl_Gastos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_MesAtualCozinhaGastos = new System.Windows.Forms.Label();
            this.Lbl_GastosCozinha = new System.Windows.Forms.Label();
            this.Pnl_Grafico = new System.Windows.Forms.Panel();
            this.Btn_GerarGraficoCozinha = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Lbl_GraficoCozinha = new System.Windows.Forms.Label();
            this.Pnl_Comparacao = new System.Windows.Forms.Panel();
            this.Lbl_MesAnteriorcomparacaoCozinha = new System.Windows.Forms.Label();
            this.Cpb_comparacao = new CircularProgressBar.CircularProgressBar();
            this.Lbl_ComparacaoCozinha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_UltimoMesCozinha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_ConsumoAnteriorCozinha = new System.Windows.Forms.Label();
            this.Pnl_ConsumoAtual = new System.Windows.Forms.Panel();
            this.Lbl_MesAtualCozinha = new System.Windows.Forms.Label();
            this.Lbl_KwhAtualCozinha = new System.Windows.Forms.Label();
            this.Lbl_CosumoAtualCozinha = new System.Windows.Forms.Label();
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
            this.Pnl_Gastos.Controls.Add(this.Lbl_MesAtualCozinhaGastos);
            this.Pnl_Gastos.Controls.Add(this.Lbl_GastosCozinha);
            this.Pnl_Gastos.Location = new System.Drawing.Point(252, 12);
            this.Pnl_Gastos.Name = "Pnl_Gastos";
            this.Pnl_Gastos.Size = new System.Drawing.Size(216, 130);
            this.Pnl_Gastos.TabIndex = 32;
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
            this.label1.Text = "R$ 68,73";
            // 
            // Lbl_MesAtualCozinhaGastos
            // 
            this.Lbl_MesAtualCozinhaGastos.AutoSize = true;
            this.Lbl_MesAtualCozinhaGastos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MesAtualCozinhaGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_MesAtualCozinhaGastos.Location = new System.Drawing.Point(15, 102);
            this.Lbl_MesAtualCozinhaGastos.Name = "Lbl_MesAtualCozinhaGastos";
            this.Lbl_MesAtualCozinhaGastos.Size = new System.Drawing.Size(66, 17);
            this.Lbl_MesAtualCozinhaGastos.TabIndex = 3;
            this.Lbl_MesAtualCozinhaGastos.Text = "Mês Atual";
            // 
            // Lbl_GastosCozinha
            // 
            this.Lbl_GastosCozinha.AutoSize = true;
            this.Lbl_GastosCozinha.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GastosCozinha.ForeColor = System.Drawing.Color.White;
            this.Lbl_GastosCozinha.Location = new System.Drawing.Point(13, 11);
            this.Lbl_GastosCozinha.Name = "Lbl_GastosCozinha";
            this.Lbl_GastosCozinha.Size = new System.Drawing.Size(68, 25);
            this.Lbl_GastosCozinha.TabIndex = 0;
            this.Lbl_GastosCozinha.Text = "Gastos";
            // 
            // Pnl_Grafico
            // 
            this.Pnl_Grafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_Grafico.Controls.Add(this.Btn_GerarGraficoCozinha);
            this.Pnl_Grafico.Controls.Add(this.chart1);
            this.Pnl_Grafico.Controls.Add(this.Lbl_GraficoCozinha);
            this.Pnl_Grafico.Location = new System.Drawing.Point(284, 166);
            this.Pnl_Grafico.Name = "Pnl_Grafico";
            this.Pnl_Grafico.Size = new System.Drawing.Size(437, 298);
            this.Pnl_Grafico.TabIndex = 33;
            // 
            // Btn_GerarGraficoCozinha
            // 
            this.Btn_GerarGraficoCozinha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Btn_GerarGraficoCozinha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GerarGraficoCozinha.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_GerarGraficoCozinha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_GerarGraficoCozinha.Location = new System.Drawing.Point(22, 262);
            this.Btn_GerarGraficoCozinha.Name = "Btn_GerarGraficoCozinha";
            this.Btn_GerarGraficoCozinha.Size = new System.Drawing.Size(131, 25);
            this.Btn_GerarGraficoCozinha.TabIndex = 31;
            this.Btn_GerarGraficoCozinha.Text = "Gerar Gráfico";
            this.Btn_GerarGraficoCozinha.UseVisualStyleBackColor = false;
            this.Btn_GerarGraficoCozinha.Click += new System.EventHandler(this.Btn_GerarGraficoCozinha_Click);
            // 
            // chart1
            // 
            this.chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Graphics;
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(22, 51);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chart1.Size = new System.Drawing.Size(389, 205);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Grafico Consumo";
            // 
            // Lbl_GraficoCozinha
            // 
            this.Lbl_GraficoCozinha.AutoSize = true;
            this.Lbl_GraficoCozinha.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GraficoCozinha.ForeColor = System.Drawing.Color.White;
            this.Lbl_GraficoCozinha.Location = new System.Drawing.Point(13, 11);
            this.Lbl_GraficoCozinha.Name = "Lbl_GraficoCozinha";
            this.Lbl_GraficoCozinha.Size = new System.Drawing.Size(73, 25);
            this.Lbl_GraficoCozinha.TabIndex = 0;
            this.Lbl_GraficoCozinha.Text = "Gráfico";
            // 
            // Pnl_Comparacao
            // 
            this.Pnl_Comparacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_Comparacao.Controls.Add(this.Lbl_MesAnteriorcomparacaoCozinha);
            this.Pnl_Comparacao.Controls.Add(this.Cpb_comparacao);
            this.Pnl_Comparacao.Controls.Add(this.Lbl_ComparacaoCozinha);
            this.Pnl_Comparacao.Location = new System.Drawing.Point(12, 166);
            this.Pnl_Comparacao.Name = "Pnl_Comparacao";
            this.Pnl_Comparacao.Size = new System.Drawing.Size(258, 298);
            this.Pnl_Comparacao.TabIndex = 34;
            // 
            // Lbl_MesAnteriorcomparacaoCozinha
            // 
            this.Lbl_MesAnteriorcomparacaoCozinha.AutoSize = true;
            this.Lbl_MesAnteriorcomparacaoCozinha.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MesAnteriorcomparacaoCozinha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_MesAnteriorcomparacaoCozinha.Location = new System.Drawing.Point(15, 270);
            this.Lbl_MesAnteriorcomparacaoCozinha.Name = "Lbl_MesAnteriorcomparacaoCozinha";
            this.Lbl_MesAnteriorcomparacaoCozinha.Size = new System.Drawing.Size(124, 17);
            this.Lbl_MesAnteriorcomparacaoCozinha.TabIndex = 3;
            this.Lbl_MesAnteriorcomparacaoCozinha.Text = "Últimos Dois Meses";
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
            this.Cpb_comparacao.Text = "11,83%";
            this.Cpb_comparacao.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.Cpb_comparacao.Value = 68;
            // 
            // Lbl_ComparacaoCozinha
            // 
            this.Lbl_ComparacaoCozinha.AutoSize = true;
            this.Lbl_ComparacaoCozinha.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ComparacaoCozinha.ForeColor = System.Drawing.Color.White;
            this.Lbl_ComparacaoCozinha.Location = new System.Drawing.Point(13, 18);
            this.Lbl_ComparacaoCozinha.Name = "Lbl_ComparacaoCozinha";
            this.Lbl_ComparacaoCozinha.Size = new System.Drawing.Size(119, 25);
            this.Lbl_ComparacaoCozinha.TabIndex = 0;
            this.Lbl_ComparacaoCozinha.Text = "Comparação";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Lbl_UltimoMesCozinha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Lbl_ConsumoAnteriorCozinha);
            this.panel1.Location = new System.Drawing.Point(488, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 130);
            this.panel1.TabIndex = 31;
            // 
            // Lbl_UltimoMesCozinha
            // 
            this.Lbl_UltimoMesCozinha.AutoSize = true;
            this.Lbl_UltimoMesCozinha.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UltimoMesCozinha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_UltimoMesCozinha.Location = new System.Drawing.Point(15, 102);
            this.Lbl_UltimoMesCozinha.Name = "Lbl_UltimoMesCozinha";
            this.Lbl_UltimoMesCozinha.Size = new System.Drawing.Size(75, 17);
            this.Lbl_UltimoMesCozinha.TabIndex = 2;
            this.Lbl_UltimoMesCozinha.Text = "Último Mês";
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
            this.label3.Text = "117,24 kWh";
            // 
            // Lbl_ConsumoAnteriorCozinha
            // 
            this.Lbl_ConsumoAnteriorCozinha.AutoSize = true;
            this.Lbl_ConsumoAnteriorCozinha.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ConsumoAnteriorCozinha.ForeColor = System.Drawing.Color.White;
            this.Lbl_ConsumoAnteriorCozinha.Location = new System.Drawing.Point(13, 11);
            this.Lbl_ConsumoAnteriorCozinha.Name = "Lbl_ConsumoAnteriorCozinha";
            this.Lbl_ConsumoAnteriorCozinha.Size = new System.Drawing.Size(166, 25);
            this.Lbl_ConsumoAnteriorCozinha.TabIndex = 0;
            this.Lbl_ConsumoAnteriorCozinha.Text = "Consumo Anterior";
            // 
            // Pnl_ConsumoAtual
            // 
            this.Pnl_ConsumoAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_ConsumoAtual.Controls.Add(this.Lbl_MesAtualCozinha);
            this.Pnl_ConsumoAtual.Controls.Add(this.Lbl_KwhAtualCozinha);
            this.Pnl_ConsumoAtual.Controls.Add(this.Lbl_CosumoAtualCozinha);
            this.Pnl_ConsumoAtual.Location = new System.Drawing.Point(12, 12);
            this.Pnl_ConsumoAtual.Name = "Pnl_ConsumoAtual";
            this.Pnl_ConsumoAtual.Size = new System.Drawing.Size(221, 130);
            this.Pnl_ConsumoAtual.TabIndex = 30;
            // 
            // Lbl_MesAtualCozinha
            // 
            this.Lbl_MesAtualCozinha.AutoSize = true;
            this.Lbl_MesAtualCozinha.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MesAtualCozinha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_MesAtualCozinha.Location = new System.Drawing.Point(15, 102);
            this.Lbl_MesAtualCozinha.Name = "Lbl_MesAtualCozinha";
            this.Lbl_MesAtualCozinha.Size = new System.Drawing.Size(66, 17);
            this.Lbl_MesAtualCozinha.TabIndex = 2;
            this.Lbl_MesAtualCozinha.Text = "Mês Atual";
            // 
            // Lbl_KwhAtualCozinha
            // 
            this.Lbl_KwhAtualCozinha.AutoSize = true;
            this.Lbl_KwhAtualCozinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_KwhAtualCozinha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.Lbl_KwhAtualCozinha.Location = new System.Drawing.Point(12, 51);
            this.Lbl_KwhAtualCozinha.Name = "Lbl_KwhAtualCozinha";
            this.Lbl_KwhAtualCozinha.Size = new System.Drawing.Size(175, 32);
            this.Lbl_KwhAtualCozinha.TabIndex = 1;
            this.Lbl_KwhAtualCozinha.Text = "104,14 kWh";
            // 
            // Lbl_CosumoAtualCozinha
            // 
            this.Lbl_CosumoAtualCozinha.AutoSize = true;
            this.Lbl_CosumoAtualCozinha.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CosumoAtualCozinha.ForeColor = System.Drawing.Color.White;
            this.Lbl_CosumoAtualCozinha.Location = new System.Drawing.Point(13, 11);
            this.Lbl_CosumoAtualCozinha.Name = "Lbl_CosumoAtualCozinha";
            this.Lbl_CosumoAtualCozinha.Size = new System.Drawing.Size(141, 25);
            this.Lbl_CosumoAtualCozinha.TabIndex = 0;
            this.Lbl_CosumoAtualCozinha.Text = "Consumo Atual";
            // 
            // Frm_Cozinha
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
            this.Name = "Frm_Cozinha";
            this.Text = "Frm_Cozinha";
            this.Load += new System.EventHandler(this.Frm_Cozinha_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_MesAtualCozinhaGastos;
        private System.Windows.Forms.Label Lbl_GastosCozinha;
        private System.Windows.Forms.Panel Pnl_Grafico;
        private System.Windows.Forms.Button Btn_GerarGraficoCozinha;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label Lbl_GraficoCozinha;
        private System.Windows.Forms.Panel Pnl_Comparacao;
        private System.Windows.Forms.Label Lbl_MesAnteriorcomparacaoCozinha;
        private CircularProgressBar.CircularProgressBar Cpb_comparacao;
        private System.Windows.Forms.Label Lbl_ComparacaoCozinha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_UltimoMesCozinha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_ConsumoAnteriorCozinha;
        private System.Windows.Forms.Panel Pnl_ConsumoAtual;
        private System.Windows.Forms.Label Lbl_MesAtualCozinha;
        private System.Windows.Forms.Label Lbl_KwhAtualCozinha;
        private System.Windows.Forms.Label Lbl_CosumoAtualCozinha;
    }
}