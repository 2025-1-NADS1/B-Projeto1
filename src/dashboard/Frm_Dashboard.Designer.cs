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
            this.Btn_Piscina = new System.Windows.Forms.Button();
            this.Btn_Cozinha = new System.Windows.Forms.Button();
            this.Btn_Sala = new System.Windows.Forms.Button();
            this.Btn_Quartos = new System.Windows.Forms.Button();
            this.Btn_Dashboard = new System.Windows.Forms.Button();
            this.Pnl_PainelTopo = new System.Windows.Forms.Panel();
            this.Lbl_TextoUsuario = new System.Windows.Forms.Label();
            this.Lbl_NomeUsuario = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Pnl_carregaforms = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Ranking = new System.Windows.Forms.Button();
            this.Pnl_PainelEsquerda.SuspendLayout();
            this.Pnl_PainelTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_PainelEsquerda
            // 
            this.Pnl_PainelEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Pnl_PainelEsquerda.Controls.Add(this.Btn_Ranking);
            this.Pnl_PainelEsquerda.Controls.Add(this.Pnl_Nav);
            this.Pnl_PainelEsquerda.Controls.Add(this.Btn_Piscina);
            this.Pnl_PainelEsquerda.Controls.Add(this.Btn_Cozinha);
            this.Pnl_PainelEsquerda.Controls.Add(this.Btn_Sala);
            this.Pnl_PainelEsquerda.Controls.Add(this.Btn_Quartos);
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
            // Btn_Piscina
            // 
            this.Btn_Piscina.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Piscina.FlatAppearance.BorderSize = 0;
            this.Btn_Piscina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Piscina.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Piscina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Piscina.Location = new System.Drawing.Point(0, 312);
            this.Btn_Piscina.Name = "Btn_Piscina";
            this.Btn_Piscina.Size = new System.Drawing.Size(186, 42);
            this.Btn_Piscina.TabIndex = 6;
            this.Btn_Piscina.Text = "Piscina";
            this.Btn_Piscina.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Piscina.UseVisualStyleBackColor = true;
            this.Btn_Piscina.Click += new System.EventHandler(this.Btn_Piscina_Click);
            this.Btn_Piscina.Leave += new System.EventHandler(this.Btn_Piscina_Leave);
            // 
            // Btn_Cozinha
            // 
            this.Btn_Cozinha.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Cozinha.FlatAppearance.BorderSize = 0;
            this.Btn_Cozinha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cozinha.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cozinha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Cozinha.Location = new System.Drawing.Point(0, 270);
            this.Btn_Cozinha.Name = "Btn_Cozinha";
            this.Btn_Cozinha.Size = new System.Drawing.Size(186, 42);
            this.Btn_Cozinha.TabIndex = 5;
            this.Btn_Cozinha.Text = "Cozinha";
            this.Btn_Cozinha.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Cozinha.UseVisualStyleBackColor = true;
            this.Btn_Cozinha.Click += new System.EventHandler(this.Btn_Cozinha_Click);
            this.Btn_Cozinha.Leave += new System.EventHandler(this.Btn_Cozinha_Leave);
            // 
            // Btn_Sala
            // 
            this.Btn_Sala.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Sala.FlatAppearance.BorderSize = 0;
            this.Btn_Sala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sala.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Sala.Location = new System.Drawing.Point(0, 228);
            this.Btn_Sala.Name = "Btn_Sala";
            this.Btn_Sala.Size = new System.Drawing.Size(186, 42);
            this.Btn_Sala.TabIndex = 4;
            this.Btn_Sala.Text = "Sala";
            this.Btn_Sala.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Sala.UseVisualStyleBackColor = true;
            this.Btn_Sala.Click += new System.EventHandler(this.Btn_Sala_Click);
            this.Btn_Sala.Leave += new System.EventHandler(this.Btn_Sala_Leave);
            // 
            // Btn_Quartos
            // 
            this.Btn_Quartos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Quartos.FlatAppearance.BorderSize = 0;
            this.Btn_Quartos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Quartos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Quartos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Quartos.Location = new System.Drawing.Point(0, 186);
            this.Btn_Quartos.Name = "Btn_Quartos";
            this.Btn_Quartos.Size = new System.Drawing.Size(186, 42);
            this.Btn_Quartos.TabIndex = 3;
            this.Btn_Quartos.Text = "Quartos";
            this.Btn_Quartos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Quartos.UseVisualStyleBackColor = true;
            this.Btn_Quartos.Click += new System.EventHandler(this.button1_Click);
            this.Btn_Quartos.Leave += new System.EventHandler(this.Btn_Quartos_Leave);
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
            this.Pnl_PainelTopo.Controls.Add(this.pictureBox1);
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
            this.Lbl_TextoUsuario.Location = new System.Drawing.Point(19, 129);
            this.Lbl_TextoUsuario.Name = "Lbl_TextoUsuario";
            this.Lbl_TextoUsuario.Size = new System.Drawing.Size(43, 12);
            this.Lbl_TextoUsuario.TabIndex = 2;
            this.Lbl_TextoUsuario.Text = "Gaúcho";
            this.Lbl_TextoUsuario.Click += new System.EventHandler(this.Lbl_TextoUsuario_Click);
            // 
            // Lbl_NomeUsuario
            // 
            this.Lbl_NomeUsuario.AutoSize = true;
            this.Lbl_NomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.Lbl_NomeUsuario.Location = new System.Drawing.Point(18, 113);
            this.Lbl_NomeUsuario.Name = "Lbl_NomeUsuario";
            this.Lbl_NomeUsuario.Size = new System.Drawing.Size(66, 16);
            this.Lbl_NomeUsuario.TabIndex = 1;
            this.Lbl_NomeUsuario.Text = "Ronaldo";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.ChatGPT_Image_18_de_mai__de_2025__20_08_35;
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Ranking
            // 
            this.Btn_Ranking.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Ranking.FlatAppearance.BorderSize = 0;
            this.Btn_Ranking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ranking.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ranking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Ranking.Location = new System.Drawing.Point(0, 535);
            this.Btn_Ranking.Name = "Btn_Ranking";
            this.Btn_Ranking.Size = new System.Drawing.Size(186, 42);
            this.Btn_Ranking.TabIndex = 7;
            this.Btn_Ranking.Text = "Ranking";
            this.Btn_Ranking.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Ranking.UseVisualStyleBackColor = true;
            this.Btn_Ranking.Click += new System.EventHandler(this.Btn_Ranking_Click);
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.Pnl_carregaforms);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Pnl_PainelEsquerda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Dashboard_Load);
            this.Pnl_PainelEsquerda.ResumeLayout(false);
            this.Pnl_PainelTopo.ResumeLayout(false);
            this.Pnl_PainelTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_PainelEsquerda;
        private System.Windows.Forms.Panel Pnl_PainelTopo;
        private System.Windows.Forms.Label Lbl_NomeUsuario;
        private System.Windows.Forms.Label Lbl_TextoUsuario;
        private System.Windows.Forms.Button Btn_Dashboard;
        private System.Windows.Forms.Button Btn_Sala;
        private System.Windows.Forms.Button Btn_Quartos;
        private System.Windows.Forms.Button Btn_Piscina;
        private System.Windows.Forms.Button Btn_Cozinha;
        private System.Windows.Forms.Panel Pnl_Nav;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Pnl_carregaforms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Ranking;
    }
}

