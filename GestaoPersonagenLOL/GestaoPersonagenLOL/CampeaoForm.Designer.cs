namespace GestaoPersonagenLOL
{
    partial class CampeaoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampeaoForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbcFuncao = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbcDificuldade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrarCampeao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricaoHabilidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeHabilidade = new System.Windows.Forms.TextBox();
            this.cbcComandoHabilidade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkIndisponivel = new System.Windows.Forms.CheckBox();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomeSkin = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cbcFuncao);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.cbcDificuldade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(547, 639);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campeão";
            // 
            // cbcFuncao
            // 
            this.cbcFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcFuncao.FormattingEnabled = true;
            this.cbcFuncao.Items.AddRange(new object[] {
            "Assasino",
            "Lutador",
            "Mago",
            "Atirador",
            "Suporte",
            "Tanque"});
            this.cbcFuncao.Location = new System.Drawing.Point(25, 174);
            this.cbcFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbcFuncao.Name = "cbcFuncao";
            this.cbcFuncao.Size = new System.Drawing.Size(237, 24);
            this.cbcFuncao.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 74);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(303, 22);
            this.txtNome.TabIndex = 2;
            // 
            // cbcDificuldade
            // 
            this.cbcDificuldade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcDificuldade.FormattingEnabled = true;
            this.cbcDificuldade.Items.AddRange(new object[] {
            "Fácil",
            "Moderado",
            "Difícil"});
            this.cbcDificuldade.Location = new System.Drawing.Point(25, 244);
            this.cbcDificuldade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbcDificuldade.Name = "cbcDificuldade";
            this.cbcDificuldade.Size = new System.Drawing.Size(236, 24);
            this.cbcDificuldade.TabIndex = 4;
            this.cbcDificuldade.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Função";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(25, 336);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(490, 274);
            this.txtDescricao.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dificuldade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição";
            // 
            // btnCadastrarCampeao
            // 
            this.btnCadastrarCampeao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarCampeao.Location = new System.Drawing.Point(28, 688);
            this.btnCadastrarCampeao.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarCampeao.Name = "btnCadastrarCampeao";
            this.btnCadastrarCampeao.Size = new System.Drawing.Size(375, 48);
            this.btnCadastrarCampeao.TabIndex = 10;
            this.btnCadastrarCampeao.Text = "Cadastrar";
            this.btnCadastrarCampeao.UseVisualStyleBackColor = true;
            this.btnCadastrarCampeao.Click += new System.EventHandler(this.btnCadastrarCampeao_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDescricaoHabilidade);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNomeHabilidade);
            this.groupBox2.Controls.Add(this.cbcComandoHabilidade);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(621, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(541, 639);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Habilidades";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Descrição";
            // 
            // txtDescricaoHabilidade
            // 
            this.txtDescricaoHabilidade.Location = new System.Drawing.Point(32, 338);
            this.txtDescricaoHabilidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricaoHabilidade.Multiline = true;
            this.txtDescricaoHabilidade.Name = "txtDescricaoHabilidade";
            this.txtDescricaoHabilidade.Size = new System.Drawing.Size(490, 274);
            this.txtDescricaoHabilidade.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Comando";
            // 
            // txtNomeHabilidade
            // 
            this.txtNomeHabilidade.Location = new System.Drawing.Point(29, 74);
            this.txtNomeHabilidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeHabilidade.Name = "txtNomeHabilidade";
            this.txtNomeHabilidade.Size = new System.Drawing.Size(303, 22);
            this.txtNomeHabilidade.TabIndex = 0;
            // 
            // cbcComandoHabilidade
            // 
            this.cbcComandoHabilidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcComandoHabilidade.FormattingEnabled = true;
            this.cbcComandoHabilidade.Items.AddRange(new object[] {
            "Passiva",
            "Q",
            "W",
            "E",
            "R - Ultimate"});
            this.cbcComandoHabilidade.Location = new System.Drawing.Point(29, 174);
            this.cbcComandoHabilidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbcComandoHabilidade.Name = "cbcComandoHabilidade";
            this.cbcComandoHabilidade.Size = new System.Drawing.Size(237, 24);
            this.cbcComandoHabilidade.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.chkIndisponivel);
            this.groupBox3.Controls.Add(this.chkDisponivel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtNomeSkin);
            this.groupBox3.Location = new System.Drawing.Point(1212, 25);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(569, 639);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skins";
            // 
            // chkIndisponivel
            // 
            this.chkIndisponivel.AutoSize = true;
            this.chkIndisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIndisponivel.Location = new System.Drawing.Point(46, 248);
            this.chkIndisponivel.Name = "chkIndisponivel";
            this.chkIndisponivel.Size = new System.Drawing.Size(137, 29);
            this.chkIndisponivel.TabIndex = 7;
            this.chkIndisponivel.Text = "Indisponivel";
            this.chkIndisponivel.UseVisualStyleBackColor = true;
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDisponivel.Location = new System.Drawing.Point(46, 191);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(124, 29);
            this.chkDisponivel.TabIndex = 6;
            this.chkDisponivel.Text = "Disponível";
            this.chkDisponivel.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Disponibilidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nome";
            // 
            // txtNomeSkin
            // 
            this.txtNomeSkin.Location = new System.Drawing.Point(39, 97);
            this.txtNomeSkin.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeSkin.Name = "txtNomeSkin";
            this.txtNomeSkin.Size = new System.Drawing.Size(236, 22);
            this.txtNomeSkin.TabIndex = 2;
            // 
            // CampeaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 798);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastrarCampeao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CampeaoForm";
            this.Text = "Registrar campeão";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CampeaoForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbcFuncao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbcDificuldade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrarCampeao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescricaoHabilidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeHabilidade;
        private System.Windows.Forms.ComboBox cbcComandoHabilidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkIndisponivel;
        private System.Windows.Forms.CheckBox chkDisponivel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomeSkin;
    }
}