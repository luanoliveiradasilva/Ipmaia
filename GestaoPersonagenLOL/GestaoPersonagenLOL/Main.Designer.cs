namespace GestaoPersonagenLOL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campeaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeCampaõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assasinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lutadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atiradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeSkinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMPEÃO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ESCOLHA SEU";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.listaDeCampaõesToolStripMenuItem,
            this.listaDeSkinsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.campeaoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // campeaoToolStripMenuItem
            // 
            this.campeaoToolStripMenuItem.Name = "campeaoToolStripMenuItem";
            this.campeaoToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.campeaoToolStripMenuItem.Text = "Campeão";
            this.campeaoToolStripMenuItem.Click += new System.EventHandler(this.campeaoToolStripMenuItem_Click);
            // 
            // listaDeCampaõesToolStripMenuItem
            // 
            this.listaDeCampaõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assasinosToolStripMenuItem,
            this.lutadoresToolStripMenuItem,
            this.magosToolStripMenuItem,
            this.atiradoresToolStripMenuItem,
            this.suporteToolStripMenuItem,
            this.tanquesToolStripMenuItem});
            this.listaDeCampaõesToolStripMenuItem.Name = "listaDeCampaõesToolStripMenuItem";
            this.listaDeCampaõesToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.listaDeCampaõesToolStripMenuItem.Text = "Lista de campeões";
            // 
            // assasinosToolStripMenuItem
            // 
            this.assasinosToolStripMenuItem.Name = "assasinosToolStripMenuItem";
            this.assasinosToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.assasinosToolStripMenuItem.Text = "Assasinos";
            // 
            // lutadoresToolStripMenuItem
            // 
            this.lutadoresToolStripMenuItem.Name = "lutadoresToolStripMenuItem";
            this.lutadoresToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.lutadoresToolStripMenuItem.Text = "Lutadores";
            // 
            // magosToolStripMenuItem
            // 
            this.magosToolStripMenuItem.Name = "magosToolStripMenuItem";
            this.magosToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.magosToolStripMenuItem.Text = "Magos";
            // 
            // atiradoresToolStripMenuItem
            // 
            this.atiradoresToolStripMenuItem.Name = "atiradoresToolStripMenuItem";
            this.atiradoresToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.atiradoresToolStripMenuItem.Text = "Atiradores";
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.suporteToolStripMenuItem.Text = "Suportes";
            // 
            // tanquesToolStripMenuItem
            // 
            this.tanquesToolStripMenuItem.Name = "tanquesToolStripMenuItem";
            this.tanquesToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.tanquesToolStripMenuItem.Text = "Tanques";
            // 
            // listaDeSkinsToolStripMenuItem
            // 
            this.listaDeSkinsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temasToolStripMenuItem});
            this.listaDeSkinsToolStripMenuItem.Name = "listaDeSkinsToolStripMenuItem";
            this.listaDeSkinsToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.listaDeSkinsToolStripMenuItem.Text = "Lista de Skins";
            // 
            // temasToolStripMenuItem
            // 
            this.temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            this.temasToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.temasToolStripMenuItem.Text = "Temas";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 261);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1067, 278);
            this.dataGridView2.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "             ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campeaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeCampaõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assasinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lutadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atiradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeSkinsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem temasToolStripMenuItem;
    }
}

