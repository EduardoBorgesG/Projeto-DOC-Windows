namespace DOC_Projeto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuNascimento = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCasamento = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuObito = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNascimento,
            this.MenuCasamento,
            this.MenuObito,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuNascimento
            // 
            this.MenuNascimento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.MenuNascimento.Image = ((System.Drawing.Image)(resources.GetObject("MenuNascimento.Image")));
            this.MenuNascimento.Name = "MenuNascimento";
            this.MenuNascimento.Size = new System.Drawing.Size(83, 35);
            this.MenuNascimento.Text = "Nascimento";
            this.MenuNascimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // incluirToolStripMenuItem
            // 
            this.incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            this.incluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.incluirToolStripMenuItem.Text = "Incluir";
            this.incluirToolStripMenuItem.Click += new System.EventHandler(this.incluirToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.relatórioToolStripMenuItem_Click);
            // 
            // MenuCasamento
            // 
            this.MenuCasamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem1,
            this.relatórioToolStripMenuItem1});
            this.MenuCasamento.Image = ((System.Drawing.Image)(resources.GetObject("MenuCasamento.Image")));
            this.MenuCasamento.Name = "MenuCasamento";
            this.MenuCasamento.Size = new System.Drawing.Size(79, 35);
            this.MenuCasamento.Text = "Casamento";
            this.MenuCasamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // incluirToolStripMenuItem1
            // 
            this.incluirToolStripMenuItem1.Name = "incluirToolStripMenuItem1";
            this.incluirToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.incluirToolStripMenuItem1.Text = "Incluir";
            this.incluirToolStripMenuItem1.Click += new System.EventHandler(this.incluirToolStripMenuItem1_Click);
            // 
            // relatórioToolStripMenuItem1
            // 
            this.relatórioToolStripMenuItem1.Name = "relatórioToolStripMenuItem1";
            this.relatórioToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.relatórioToolStripMenuItem1.Text = "Relatório";
            // 
            // MenuObito
            // 
            this.MenuObito.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem2,
            this.relatórioToolStripMenuItem2});
            this.MenuObito.Image = ((System.Drawing.Image)(resources.GetObject("MenuObito.Image")));
            this.MenuObito.Name = "MenuObito";
            this.MenuObito.Size = new System.Drawing.Size(49, 35);
            this.MenuObito.Text = "Óbito";
            this.MenuObito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // incluirToolStripMenuItem2
            // 
            this.incluirToolStripMenuItem2.Name = "incluirToolStripMenuItem2";
            this.incluirToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.incluirToolStripMenuItem2.Text = "Incluir";
            this.incluirToolStripMenuItem2.Click += new System.EventHandler(this.incluirToolStripMenuItem2_Click);
            // 
            // relatórioToolStripMenuItem2
            // 
            this.relatórioToolStripMenuItem2.Name = "relatórioToolStripMenuItem2";
            this.relatórioToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.relatórioToolStripMenuItem2.Text = "Relatório";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 35);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Borges";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuNascimento;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCasamento;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuObito;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

