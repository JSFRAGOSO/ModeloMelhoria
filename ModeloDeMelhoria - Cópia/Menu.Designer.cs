namespace ModeloDeMelhoria
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.áreaDeProcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metaEspecíficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metaGenéricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nívelDeCapacidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nívelDeMaturidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.práticaEspecíficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proutoDeTrabalhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloDeMelhoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.modeloDeMelhoriaToolStripMenuItem,
            this.sairStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.áreaDeProcessoToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.metaEspecíficaToolStripMenuItem,
            this.metaGenéricaToolStripMenuItem,
            this.nívelDeCapacidadeToolStripMenuItem,
            this.nívelDeMaturidadeToolStripMenuItem,
            this.práticaEspecíficaToolStripMenuItem,
            this.proutoDeTrabalhoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastros";
            // 
            // áreaDeProcessoToolStripMenuItem
            // 
            this.áreaDeProcessoToolStripMenuItem.Name = "áreaDeProcessoToolStripMenuItem";
            this.áreaDeProcessoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.áreaDeProcessoToolStripMenuItem.Text = "Área de Processo";
            this.áreaDeProcessoToolStripMenuItem.Click += new System.EventHandler(this.áreaDeProcessoToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // metaEspecíficaToolStripMenuItem
            // 
            this.metaEspecíficaToolStripMenuItem.Name = "metaEspecíficaToolStripMenuItem";
            this.metaEspecíficaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.metaEspecíficaToolStripMenuItem.Text = "Meta Específica";
            this.metaEspecíficaToolStripMenuItem.Click += new System.EventHandler(this.metaEspecíficaToolStripMenuItem_Click);
            // 
            // metaGenéricaToolStripMenuItem
            // 
            this.metaGenéricaToolStripMenuItem.Name = "metaGenéricaToolStripMenuItem";
            this.metaGenéricaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.metaGenéricaToolStripMenuItem.Text = "Meta Genérica";
            this.metaGenéricaToolStripMenuItem.Click += new System.EventHandler(this.metaGenéricaToolStripMenuItem_Click);
            // 
            // nívelDeCapacidadeToolStripMenuItem
            // 
            this.nívelDeCapacidadeToolStripMenuItem.Name = "nívelDeCapacidadeToolStripMenuItem";
            this.nívelDeCapacidadeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.nívelDeCapacidadeToolStripMenuItem.Text = "Nível de Capacidade";
            this.nívelDeCapacidadeToolStripMenuItem.Click += new System.EventHandler(this.nívelDeCapacidadeToolStripMenuItem_Click);
            // 
            // nívelDeMaturidadeToolStripMenuItem
            // 
            this.nívelDeMaturidadeToolStripMenuItem.Name = "nívelDeMaturidadeToolStripMenuItem";
            this.nívelDeMaturidadeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.nívelDeMaturidadeToolStripMenuItem.Text = "Nível de Maturidade";
            this.nívelDeMaturidadeToolStripMenuItem.Click += new System.EventHandler(this.nívelDeMaturidadeToolStripMenuItem_Click);
            // 
            // práticaEspecíficaToolStripMenuItem
            // 
            this.práticaEspecíficaToolStripMenuItem.Name = "práticaEspecíficaToolStripMenuItem";
            this.práticaEspecíficaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.práticaEspecíficaToolStripMenuItem.Text = "Prática Específica";
            this.práticaEspecíficaToolStripMenuItem.Click += new System.EventHandler(this.práticaEspecíficaToolStripMenuItem_Click);
            // 
            // proutoDeTrabalhoToolStripMenuItem
            // 
            this.proutoDeTrabalhoToolStripMenuItem.Name = "proutoDeTrabalhoToolStripMenuItem";
            this.proutoDeTrabalhoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.proutoDeTrabalhoToolStripMenuItem.Text = "Prouto de Trabalho";
            this.proutoDeTrabalhoToolStripMenuItem.Click += new System.EventHandler(this.proutoDeTrabalhoToolStripMenuItem_Click);
            // 
            // modeloDeMelhoriaToolStripMenuItem
            // 
            this.modeloDeMelhoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarToolStripMenuItem,
            this.gerarToolStripMenuItem});
            this.modeloDeMelhoriaToolStripMenuItem.Name = "modeloDeMelhoriaToolStripMenuItem";
            this.modeloDeMelhoriaToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.modeloDeMelhoriaToolStripMenuItem.Text = "Modelo de Melhoria";
            // 
            // criarToolStripMenuItem
            // 
            this.criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            this.criarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.criarToolStripMenuItem.Text = "Criar";
            this.criarToolStripMenuItem.Click += new System.EventHandler(this.criarToolStripMenuItem_Click);
            // 
            // gerarToolStripMenuItem
            // 
            this.gerarToolStripMenuItem.Name = "gerarToolStripMenuItem";
            this.gerarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gerarToolStripMenuItem.Text = "Visualizar";
            this.gerarToolStripMenuItem.Click += new System.EventHandler(this.gerarToolStripMenuItem_Click);
            // 
            // sairStripMenuItem1
            // 
            this.sairStripMenuItem1.Name = "sairStripMenuItem1";
            this.sairStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.sairStripMenuItem1.Text = "Sair";
            this.sairStripMenuItem1.Click += new System.EventHandler(this.sairStripMenuItem1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(426, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áreaDeProcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metaEspecíficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metaGenéricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nívelDeCapacidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nívelDeMaturidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proutoDeTrabalhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeloDeMelhoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem práticaEspecíficaToolStripMenuItem;
    }
}

