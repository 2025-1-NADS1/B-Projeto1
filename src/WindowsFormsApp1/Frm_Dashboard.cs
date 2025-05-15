using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Frm_Dashboard : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
(
int nLeftRect,
int nTopRect,
int nRightRect,
int nBottomRect,
int nWidthEllipse,
int nHeightEllipse

);
        public Frm_Dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Pnl_Nav.Height = Btn_Dashboard.Height;
            Pnl_Nav.Top = Btn_Dashboard.Top;
            Pnl_Nav.Left = Btn_Dashboard.Left;
            Btn_Dashboard.BackColor = Color.FromArgb(46, 51, 73);

            Lbl_Titulo.Text = "Dashboard";
            this.Pnl_carregaforms.Controls.Clear();
            Frm_Dashboard1 FrmDashboard_Vrb = new Frm_Dashboard1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_carregaforms.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }


        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {

        }

        //Esse é também é o botão do calendário
        private void button1_Click(object sender, EventArgs e)
        {
            Pnl_Nav.Height = Btn_Dashboard.Height;
            Pnl_Nav.Top = Btn_Dashboard.Top;
            Pnl_Nav.Left = Btn_Dashboard.Left;
            Btn_Dashboard.BackColor = Color.FromArgb(46, 51, 73);

            Lbl_Titulo.Text = "Calendário";
            this.Pnl_carregaforms.Controls.Clear();
            Frm_Calendario FrmDashboard_Vrb = new Frm_Calendario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_carregaforms.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();

        }

        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            Pnl_Nav.Height = Btn_Dashboard.Height;
            Pnl_Nav.Top = Btn_Dashboard.Top;
            Pnl_Nav.Left = Btn_Dashboard.Left;
            Btn_Dashboard.BackColor = Color.FromArgb(46, 51, 73);

            Lbl_Titulo.Text = "Dashboard";
            this.Pnl_carregaforms.Controls.Clear();
            Frm_Dashboard1 FrmDashboard_Vrb = new Frm_Dashboard1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_carregaforms.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void Btn_Analise_Click(object sender, EventArgs e)
        {
            Pnl_Nav.Height = Btn_Analise.Height;
            Pnl_Nav.Top = Btn_Analise.Top;
            Btn_Analise.BackColor = Color.FromArgb(46, 51, 73);

            Lbl_Titulo.Text = "Análise";
            this.Pnl_carregaforms.Controls.Clear();
            Frm_Analise FrmDashboard_Vrb = new Frm_Analise() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_carregaforms.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }


        //A private void button1_Click faz a função dele, pois apresenta erro
        private void Btn_Calendario_Click(object sender, EventArgs e)
        {
            Pnl_Nav.Height = Btn_Calendario.Height;
            Pnl_Nav.Top = Btn_Calendario.Top;
            Btn_Calendario.BackColor = Color.FromArgb(46, 51, 73);

            Lbl_Titulo.Text = "Calendário";
            this.Pnl_carregaforms.Controls.Clear();
            Frm_Calendario FrmDashboard_Vrb = new Frm_Calendario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_carregaforms.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void Btn_Gastos_Click(object sender, EventArgs e)
        {
            Pnl_Nav.Height = Btn_Gastos.Height;
            Pnl_Nav.Top = Btn_Gastos.Top;
            Btn_Gastos.BackColor = Color.FromArgb(46, 51, 73);

            Lbl_Titulo.Text = "Gastos";
            this.Pnl_carregaforms.Controls.Clear();
            Frm_Gastos FrmDashboard_Vrb = new Frm_Gastos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_carregaforms.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void Btn_Configuracoes_Click(object sender, EventArgs e)
        {
            Pnl_Nav.Height = Btn_Configuracoes.Height;
            Pnl_Nav.Top = Btn_Configuracoes.Top;
            Btn_Configuracoes.BackColor = Color.FromArgb(46, 51, 73);

            Lbl_Titulo.Text = "Configurações";
            this.Pnl_carregaforms.Controls.Clear();
            Frm_Configuracoes FrmDashboard_Vrb = new Frm_Configuracoes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_carregaforms.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void Btn_Dashboard_Leave(object sender, EventArgs e)
        {
            Btn_Dashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Btn_Analise_Leave(object sender, EventArgs e)
        {
            Btn_Analise.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Btn_Calendario_Leave(object sender, EventArgs e)
        {
            Btn_Calendario.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Btn_Gastos_Leave(object sender, EventArgs e)
        {
            Btn_Gastos.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Btn_Configuracoes_Leave(object sender, EventArgs e)
        {
            Btn_Configuracoes.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Lbl_Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Fechar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lbl_KwhAnterior_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Pnl_Comparacao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_PreencherDepois_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Procurar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_ConsumoAnterior_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_CosumoAtual_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Preencher_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_TextoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Pnl_Preencher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_KwhAtual_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Grafico_Click(object sender, EventArgs e)
        {

        }

        private void Pnl_Grafico_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_NomeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Pnl_ConsumoAnterior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnl_ConsumoAtual_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnl_PainelUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnl_PreencherDepois_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnl_carregaforms_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
