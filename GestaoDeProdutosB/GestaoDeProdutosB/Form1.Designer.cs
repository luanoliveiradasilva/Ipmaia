namespace GestaoDeProdutosB
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
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.labelProduto = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.listBoxProduto = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(149, 316);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(142, 31);
            this.buttonAdicionar.TabIndex = 0;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(91, 63);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(91, 95);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelCategoria.TabIndex = 2;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(91, 122);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 3;
            this.labelDescricao.Text = "Descrição";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(91, 215);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(35, 13);
            this.labelPreco.TabIndex = 4;
            this.labelPreco.Text = "Preço";
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Location = new System.Drawing.Point(460, 56);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(44, 13);
            this.labelProduto.TabIndex = 5;
            this.labelProduto.Text = "Produto";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(149, 56);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(121, 20);
            this.textNome.TabIndex = 6;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(149, 119);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(121, 80);
            this.textBoxDescricao.TabIndex = 8;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Mercearia",
            "Cafetaria Nestlé",
            "Yammi",
            "Iglo",
            "Nestlé Bebé",
            "Emma",
            "Lego",
            "Gillette Labs",
            "Yammi",
            "Bio e Escolhas Alimentares",
            "Laticínios e Ovos",
            "Peixaria e Talho",
            "Frutas e Legumes",
            "Charcutaria e Queijos",
            "Padaria e Pastelaria",
            "Refeições Fáceis",
            "Congelados",
            "Bebidas e Garrafeira",
            "Beleza e Higiene",
            "Bebé",
            "Limpeza",
            "Casa, Bricolage e Jardim",
            "Animais by ZU"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(149, 87);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoria.TabIndex = 7;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(149, 215);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(121, 20);
            this.textBoxPreco.TabIndex = 9;
            // 
            // listBoxProduto
            // 
            this.listBoxProduto.FormattingEnabled = true;
            this.listBoxProduto.Location = new System.Drawing.Point(463, 87);
            this.listBoxProduto.Name = "listBoxProduto";
            this.listBoxProduto.Size = new System.Drawing.Size(180, 225);
            this.listBoxProduto.TabIndex = 10;
            this.listBoxProduto.DoubleClick += new System.EventHandler(this.listBoxProduto_DoubleClick);
            this.listBoxProduto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxProduto_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "€";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "Ficheiro";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            this.ficheiroToolStripMenuItem.Click += new System.EventHandler(this.ficheiroToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxProduto);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.labelProduto);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBoxProduto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
    }
}

