using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Frm_Cozinha : Form
    {
        public Frm_Cozinha()
        {
            InitializeComponent();
        }

        private void Frm_Cozinha_Load(object sender, EventArgs e)
        {

        }

        private void Btn_GerarGraficoTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void Gerar_Grafico()
        {
            Dictionary<int, double> potenciaSensores = new Dictionary<int, double>
    {
        { 1, 1.5 },
        { 2, 1.5 },
        { 3, 0.05 },
        { 4, 3.0 },
        { 5, 7.0 }
    };

            Dictionary<string, double> consumoPorMes = new Dictionary<string, double>
    {
        { "Janeiro", 0 },
        { "Fevereiro", 0 },
        { "Março", 0 },
        { "Abril", 0 },
        { "Maio", 0 },
        { "Junho", 0 },
        { "Julho", 0 }
    };

            string caminhoArquivo = @"BD_Casa_Inteligente_Cozinha.csv";

            List<Tuple<DateTime, int, int>> registros = new List<Tuple<DateTime, int, int>>();

            if (File.Exists(caminhoArquivo))
            {
                var linhas = File.ReadAllLines(caminhoArquivo).Skip(1);

                foreach (var linha in linhas)
                {
                    var partes = linha.Split(';'); // Troque para ',' se necessário

                    if (partes.Length < 5)
                        continue;

                    DateTime dataHora;
                    int idSensor;
                    int movimento;

                    if (!DateTime.TryParse(partes[0], out dataHora) ||
                        !int.TryParse(partes[1], out idSensor) ||
                        !int.TryParse(partes[4], out movimento))
                        continue;

                    registros.Add(new Tuple<DateTime, int, int>(dataHora, idSensor, movimento));
                }

                var registrosPorSensor = registros.GroupBy(r => r.Item2);

                foreach (var grupo in registrosPorSensor)
                {
                    int idSensor = grupo.Key;
                    var dados = grupo.OrderBy(r => r.Item1).ToList();

                    bool emUso = false;
                    DateTime inicioUso = DateTime.MinValue;

                    for (int i = 0; i < dados.Count; i++)
                    {
                        var registro = dados[i];
                        DateTime timestamp = registro.Item1;
                        int movimento = registro.Item3;

                        if (movimento == 1 && !emUso)
                        {
                            emUso = true;
                            inicioUso = timestamp;
                        }
                        else if (movimento == 0 && emUso)
                        {
                            emUso = false;

                            TimeSpan duracao = timestamp - inicioUso;
                            double horas = duracao.TotalHours;

                            if (horas > 0 && horas < 48 && potenciaSensores.ContainsKey(idSensor))
                            {
                                double consumo = potenciaSensores[idSensor] * horas;

                                int mes = inicioUso.Month;
                                string chaveMes = "";

                                if (mes == 1) chaveMes = "Janeiro";
                                else if (mes == 2) chaveMes = "Fevereiro";
                                else if (mes == 3) chaveMes = "Março";
                                else if (mes == 4) chaveMes = "Abril";
                                else if (mes == 5) chaveMes = "Maio";
                                else if (mes == 6) chaveMes = "Junho";
                                else if (mes == 7) chaveMes = "Julho";

                                if (consumoPorMes.ContainsKey(chaveMes))
                                    consumoPorMes[chaveMes] += consumo;
                            }
                        }
                    }

                    // Se terminou em "emUso", contar até o último timestamp
                    if (emUso && potenciaSensores.ContainsKey(idSensor))
                    {
                        DateTime fim = dados[dados.Count - 1].Item1;
                        TimeSpan duracao = fim - inicioUso;
                        double horas = duracao.TotalHours;

                        if (horas > 0 && horas < 48)
                        {
                            double consumo = potenciaSensores[idSensor] * horas;

                            int mes = inicioUso.Month;
                            string chaveMes = "";

                            if (mes == 1) chaveMes = "Janeiro";
                            else if (mes == 2) chaveMes = "Fevereiro";
                            else if (mes == 3) chaveMes = "Março";
                            else if (mes == 4) chaveMes = "Abril";
                            else if (mes == 5) chaveMes = "Maio";
                            else if (mes == 6) chaveMes = "Junho";
                            else if (mes == 7) chaveMes = "Julho";

                            if (consumoPorMes.ContainsKey(chaveMes))
                                consumoPorMes[chaveMes] += consumo;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo CSV não encontrado.");
                return;
            }

            // Gráfico
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();

            Title title = new Title("Consumo", Docking.Top, new Font("Arial", 14, FontStyle.Bold), Color.Orange);
            chart1.Titles.Add(title);

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mês";
            chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.White;

            chart1.ChartAreas["ChartArea1"].AxisY.Title = "kWh Mês";
            chart1.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = Color.White;

            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;

            chart1.Series.Add("Consumo");
            var serie = chart1.Series["Consumo"];
            serie.ChartType = SeriesChartType.Column;
            serie.IsValueShownAsLabel = true;
            serie.LabelForeColor = Color.Gray;
            serie.BorderWidth = 4;

            foreach (var item in consumoPorMes)
            {
                double valorDividido = item.Value / 10.0;
                serie.Points.AddXY(item.Key, Math.Round(valorDividido, 2));
            }

        }

        private void Btn_GerarGraficoCozinha_Click(object sender, EventArgs e)
        {
            Gerar_Grafico();
        }
    }
}
