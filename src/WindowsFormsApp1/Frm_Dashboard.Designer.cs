namespace WindowsFormsApp1
{
    partial class Frm_Dashboard
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pnl_PainelEsquerda = new System.Windows.Forms.Panel();
            this.Pnl_Nav = new System.Windows.Forms.Panel();
            this.Btn_Configuracoes = new System.Windows.Forms.Button();
            this.Btn_Gastos = new System.Windows.Forms.Button();
            this.Btn_Analise = new System.Windows.Forms.Button();
            this.Btn_Calendario = new System.Windows.Forms.Button();
            this.Btn_Dashboard = new System.Windows.Forms.Button();
            this.Pnl_PainelTopo = new System.Windows.Forms.Panel();
            this.Lbl_TextoUsuario = new System.Windows.Forms.Label();
            this.Lbl_NomeUsuario = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Txt_Procurar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Pnl_carregaforms = new System.Windows.Forms.Panel();
            this.Pnl_PainelEsquerda.SuspendLayout();
            this.Pnl_PainelTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_PainelEsquerda
            // 
            this.Pnl_PainelEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Pnl_PainelEsquerda.Controls.Add(this.Pnl_Nav);
            this.Pnl_PainelEsquerda.Controls.Add(this.Btn_Configuracoes);
            this.Pnl_PainelEsquerda.Controls.Add(this.Btn_Gastos);
            this.Pnl_PainelEsquerda.Controls.Add(this.Btn_Analise);
            this.Pnl_PainelEsquerda.Controls.Add(this.Btn_Calendario);
            this.Pnl_PainelEsquerda.Controls.Add(this.Btn_Dashboard);
            this.Pnl_PainelEsquerda.Controls.Add(this.Pnl_PainelTopo);
            this.Pnl_PainelEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_PainelEsquerda.Location = new System.Drawing.Point(0, 0);
            this.Pnl_PainelEsquerda.Name = "Pnl_PainelEsquerda";
            this.Pnl_PainelEsquerda.Size = new System.Drawing.Size(186, 577);
            this.Pnl_PainelEsquerda.TabIndex = 0;
            // 
            // Pnl_Nav
            // 
            this.Pnl_Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Pnl_Nav.Location = new System.Drawing.Point(1, 193);
            this.Pnl_Nav.Name = "Pnl_Nav";
            this.Pnl_Nav.Size = new System.Drawing.Size(1, 100);
            this.Pnl_Nav.TabIndex = 3;
            // 
            // Btn_Configuracoes
            // 
            this.Btn_Configuracoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Configuracoes.FlatAppearance.BorderSize = 0;
            this.Btn_Configuracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Configuracoes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Configuracoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Configuracoes.Location = new System.Drawing.Point(0, 535);
            this.Btn_Configuracoes.Name = "Btn_Configuracoes";
            this.Btn_Configuracoes.Size = new System.Drawing.Size(186, 42);
            this.Btn_Configuracoes.TabIndex = 6;
            this.Btn_Configuracoes.Text = "Configurações";
            this.Btn_Configuracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Configuracoes.UseVisualStyleBackColor = true;
            this.Btn_Configuracoes.Click += new System.EventHandler(this.Btn_Configuracoes_Click);
            this.Btn_Configuracoes.Leave += new System.EventHandler(this.Btn_Configuracoes_Leave);
            // 
            // Btn_Gastos
            // 
            this.Btn_Gastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Gastos.FlatAppearance.BorderSize = 0;
            this.Btn_Gastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Gastos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Gastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Gastos.Location = new System.Drawing.Point(0, 270);
            this.Btn_Gastos.Name = "Btn_Gastos";
            this.Btn_Gastos.Size = new System.Drawing.Size(186, 42);
            this.Btn_Gastos.TabIndex = 5;
            this.Btn_Gastos.Text = "Gastos";
            this.Btn_Gastos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Gastos.UseVisualStyleBackColor = true;
            this.Btn_Gastos.Click += new System.EventHandler(this.Btn_Gastos_Click);
            this.Btn_Gastos.Leave += new System.EventHandler(this.Btn_Gastos_Leave);
            // 
            // Btn_Analise
            // 
            this.Btn_Analise.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Analise.FlatAppearance.BorderSize = 0;
            this.Btn_Analise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Analise.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Analise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Analise.Location = new System.Drawing.Point(0, 228);
            this.Btn_Analise.Name = "Btn_Analise";
            this.Btn_Analise.Size = new System.Drawing.Size(186, 42);
            this.Btn_Analise.TabIndex = 4;
            this.Btn_Analise.Text = "Análise";
            this.Btn_Analise.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Analise.UseVisualStyleBackColor = true;
            this.Btn_Analise.Click += new System.EventHandler(this.Btn_Analise_Click);
            this.Btn_Analise.Leave += new System.EventHandler(this.Btn_Analise_Leave);
            // 
            // Btn_Calendario
            // 
            this.Btn_Calendario.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Calendario.FlatAppearance.BorderSize = 0;
            this.Btn_Calendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Calendario.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Calendario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Calendario.Location = new System.Drawing.Point(0, 186);
            this.Btn_Calendario.Name = "Btn_Calendario";
            this.Btn_Calendario.Size = new System.Drawing.Size(186, 42);
            this.Btn_Calendario.TabIndex = 3;
            this.Btn_Calendario.Text = "Caléndario";
            this.Btn_Calendario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Calendario.UseVisualStyleBackColor = true;
            this.Btn_Calendario.Click += new System.EventHandler(this.button1_Click);
            this.Btn_Calendario.Leave += new System.EventHandler(this.Btn_Calendario_Leave);
            // 
            // Btn_Dashboard
            // 
            this.Btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.Btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Dashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Dashboard.Location = new System.Drawing.Point(0, 144);
            this.Btn_Dashboard.Name = "Btn_Dashboard";
            this.Btn_Dashboard.Size = new System.Drawing.Size(186, 42);
            this.Btn_Dashboard.TabIndex = 2;
            this.Btn_Dashboard.Text = "Dashboard";
            this.Btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Dashboard.UseVisualStyleBackColor = true;
            this.Btn_Dashboard.Click += new System.EventHandler(this.Btn_Dashboard_Click);
            this.Btn_Dashboard.Leave += new System.EventHandler(this.Btn_Dashboard_Leave);
            // 
            // Pnl_PainelTopo
            // 
            this.Pnl_PainelTopo.Controls.Add(this.Lbl_TextoUsuario);
            this.Pnl_PainelTopo.Controls.Add(this.Lbl_NomeUsuario);
            this.Pnl_PainelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_PainelTopo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_PainelTopo.Name = "Pnl_PainelTopo";
            this.Pnl_PainelTopo.Size = new System.Drawing.Size(186, 144);
            this.Pnl_PainelTopo.TabIndex = 1;
            this.Pnl_PainelTopo.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_PainelUsuario_Paint);
            // 
            // Lbl_TextoUsuario
            // 
            this.Lbl_TextoUsuario.AutoSize = true;
            this.Lbl_TextoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TextoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.Lbl_TextoUsuario.Location = new System.Drawing.Point(41, 118);
            this.Lbl_TextoUsuario.Name = "Lbl_TextoUsuario";
            this.Lbl_TextoUsuario.Size = new System.Drawing.Size(90, 12);
            this.Lbl_TextoUsuario.TabIndex = 2;
            this.Lbl_TextoUsuario.Text = "Texto do Usuário";
            this.Lbl_TextoUsuario.Click += new System.EventHandler(this.Lbl_TextoUsuario_Click);
            // 
            // Lbl_NomeUsuario
            // 
            this.Lbl_NomeUsuario.AutoSize = true;
            this.Lbl_NomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.Lbl_NomeUsuario.Location = new System.Drawing.Point(40, 102);
            this.Lbl_NomeUsuario.Name = "Lbl_NomeUsuario";
            this.Lbl_NomeUsuario.Size = new System.Drawing.Size(128, 16);
            this.Lbl_NomeUsuario.TabIndex = 1;
            this.Lbl_NomeUsuario.Text = "Nome do Usuário";
            this.Lbl_NomeUsuario.Click += new System.EventHandler(this.Lbl_NomeUsuario_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Lbl_Titulo.Location = new System.Drawing.Point(192, 9);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(162, 32);
            this.Lbl_Titulo.TabIndex = 1;
            this.Lbl_Titulo.Text = "Dashboard";
            this.Lbl_Titulo.Click += new System.EventHandler(this.Lbl_Dashboard_Click);
            // 
            // Txt_Procurar
            // 
            this.Txt_Procurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Txt_Procurar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Procurar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Procurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Txt_Procurar.Location = new System.Drawing.Point(584, 20);
            this.Txt_Procurar.Multiline = true;
            this.Txt_Procurar.Name = "Txt_Procurar";
            this.Txt_Procurar.Size = new System.Drawing.Size(292, 20);
            this.Txt_Procurar.TabIndex = 1;
            this.Txt_Procurar.Text = "Procurar";
            this.Txt_Procurar.TextChanged += new System.EventHandler(this.Txt_Procurar_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(901, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_Fechar);
            // 
            // Pnl_carregaforms
            // 
            this.Pnl_carregaforms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_carregaforms.Location = new System.Drawing.Point(186, 74);
            this.Pnl_carregaforms.Name = "Pnl_carregaforms";
            this.Pnl_carregaforms.Size = new System.Drawing.Size(765, 503);
            this.Pnl_carregaforms.TabIndex = 3;
            this.Pnl_carregaforms.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_carregaforms_Paint);
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.Pnl_carregaforms);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_Procurar);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Pnl_PainelEsquerda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Dashboard_Load);
            this.Pnl_PainelEsquerda.ResumeLayout(false);
            this.Pnl_PainelTopo.ResumeLayout(false);
            this.Pnl_PainelTopo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_PainelEsquerda;
        private System.Windows.Forms.Panel Pnl_PainelTopo;
        private System.Windows.Forms.Label Lbl_NomeUsuario;
        private System.Windows.Forms.Label Lbl_TextoUsuario;
        private System.Windows.Forms.Button Btn_Dashboard;
        private System.Windows.Forms.Button Btn_Analise;
        private System.Windows.Forms.Button Btn_Calendario;
        private System.Windows.Forms.Button Btn_Configuracoes;
        private System.Windows.Forms.Button Btn_Gastos;
        private System.Windows.Forms.Panel Pnl_Nav;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.TextBox Txt_Procurar;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel Pnl_carregaforms;
    }
}

