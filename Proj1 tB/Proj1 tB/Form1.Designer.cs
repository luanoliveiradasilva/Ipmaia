namespace Proj1_tB
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtPrimoValue = new System.Windows.Forms.TextBox();
            this.lblValorPrimo = new System.Windows.Forms.Label();
            this.btnPrimoValue = new System.Windows.Forms.Button();
            this.btnPrimo = new System.Windows.Forms.Button();
            this.btnParOuImpar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnNumeroMaior = new System.Windows.Forms.Button();
            this.txtNumeroDois = new System.Windows.Forms.TextBox();
            this.txtNumeroUm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textValorDois = new System.Windows.Forms.TextBox();
            this.textValorUm = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonDivisao = new System.Windows.Forms.Button();
            this.buttonMultiplicacao = new System.Windows.Forms.Button();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.buttonSubtracao = new System.Windows.Forms.Button();
            this.textBoxExe1 = new System.Windows.Forms.TextBox();
            this.buttonExe1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1170, 674);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtResultado);
            this.tabPage1.Controls.Add(this.txtPrimoValue);
            this.tabPage1.Controls.Add(this.lblValorPrimo);
            this.tabPage1.Controls.Add(this.btnPrimoValue);
            this.tabPage1.Controls.Add(this.btnPrimo);
            this.tabPage1.Controls.Add(this.btnParOuImpar);
            this.tabPage1.Controls.Add(this.txtNumero);
            this.tabPage1.Controls.Add(this.lblNum);
            this.tabPage1.Controls.Add(this.btnNumeroMaior);
            this.tabPage1.Controls.Add(this.txtNumeroDois);
            this.tabPage1.Controls.Add(this.txtNumeroUm);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textValorDois);
            this.tabPage1.Controls.Add(this.textValorUm);
            this.tabPage1.Controls.Add(this.labelResultado);
            this.tabPage1.Controls.Add(this.buttonDivisao);
            this.tabPage1.Controls.Add(this.buttonMultiplicacao);
            this.tabPage1.Controls.Add(this.buttonSoma);
            this.tabPage1.Controls.Add(this.buttonSubtracao);
            this.tabPage1.Controls.Add(this.textBoxExe1);
            this.tabPage1.Controls.Add(this.buttonExe1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1162, 648);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(714, 168);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(321, 426);
            this.txtResultado.TabIndex = 45;
            // 
            // txtPrimoValue
            // 
            this.txtPrimoValue.Location = new System.Drawing.Point(746, 91);
            this.txtPrimoValue.Name = "txtPrimoValue";
            this.txtPrimoValue.Size = new System.Drawing.Size(100, 20);
            this.txtPrimoValue.TabIndex = 44;
            // 
            // lblValorPrimo
            // 
            this.lblValorPrimo.AutoSize = true;
            this.lblValorPrimo.Location = new System.Drawing.Point(696, 98);
            this.lblValorPrimo.Name = "lblValorPrimo";
            this.lblValorPrimo.Size = new System.Drawing.Size(44, 13);
            this.lblValorPrimo.TabIndex = 43;
            this.lblValorPrimo.Text = "Número";
            // 
            // btnPrimoValue
            // 
            this.btnPrimoValue.Location = new System.Drawing.Point(746, 121);
            this.btnPrimoValue.Name = "btnPrimoValue";
            this.btnPrimoValue.Size = new System.Drawing.Size(75, 23);
            this.btnPrimoValue.TabIndex = 42;
            this.btnPrimoValue.Text = "Primo";
            this.btnPrimoValue.UseVisualStyleBackColor = true;
            this.btnPrimoValue.Click += new System.EventHandler(this.btnPrimo_Click);
            // 
            // btnPrimo
            // 
            this.btnPrimo.Location = new System.Drawing.Point(250, 448);
            this.btnPrimo.Name = "btnPrimo";
            this.btnPrimo.Size = new System.Drawing.Size(72, 23);
            this.btnPrimo.TabIndex = 41;
            this.btnPrimo.Text = "Primo";
            this.btnPrimo.UseVisualStyleBackColor = true;
            this.btnPrimo.Click += new System.EventHandler(this.btnPrimo_Click);
            // 
            // btnParOuImpar
            // 
            this.btnParOuImpar.Location = new System.Drawing.Point(250, 406);
            this.btnParOuImpar.Name = "btnParOuImpar";
            this.btnParOuImpar.Size = new System.Drawing.Size(72, 23);
            this.btnParOuImpar.TabIndex = 40;
            this.btnParOuImpar.Text = "Par/Impar";
            this.btnParOuImpar.UseVisualStyleBackColor = true;
            this.btnParOuImpar.Click += new System.EventHandler(this.btnParOuImpar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(138, 409);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(97, 20);
            this.txtNumero.TabIndex = 39;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(135, 393);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(44, 13);
            this.lblNum.TabIndex = 38;
            this.lblNum.Text = "Número";
            // 
            // btnNumeroMaior
            // 
            this.btnNumeroMaior.Location = new System.Drawing.Point(245, 298);
            this.btnNumeroMaior.Name = "btnNumeroMaior";
            this.btnNumeroMaior.Size = new System.Drawing.Size(86, 54);
            this.btnNumeroMaior.TabIndex = 37;
            this.btnNumeroMaior.Text = "Qual o número maior?";
            this.btnNumeroMaior.UseVisualStyleBackColor = true;
            this.btnNumeroMaior.Click += new System.EventHandler(this.btnNumeroMaior_Click);
            // 
            // txtNumeroDois
            // 
            this.txtNumeroDois.Location = new System.Drawing.Point(138, 354);
            this.txtNumeroDois.Name = "txtNumeroDois";
            this.txtNumeroDois.Size = new System.Drawing.Size(95, 20);
            this.txtNumeroDois.TabIndex = 36;
            // 
            // txtNumeroUm
            // 
            this.txtNumeroUm.Location = new System.Drawing.Point(138, 298);
            this.txtNumeroUm.Name = "txtNumeroUm";
            this.txtNumeroUm.Size = new System.Drawing.Size(95, 20);
            this.txtNumeroUm.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Número 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Número 1";
            // 
            // textValorDois
            // 
            this.textValorDois.Location = new System.Drawing.Point(135, 233);
            this.textValorDois.Name = "textValorDois";
            this.textValorDois.Size = new System.Drawing.Size(103, 20);
            this.textValorDois.TabIndex = 32;
            // 
            // textValorUm
            // 
            this.textValorUm.Location = new System.Drawing.Point(135, 184);
            this.textValorUm.Name = "textValorUm";
            this.textValorUm.Size = new System.Drawing.Size(103, 20);
            this.textValorUm.TabIndex = 31;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(411, 172);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(241, 55);
            this.labelResultado.TabIndex = 30;
            this.labelResultado.Text = "Resultado";
            // 
            // buttonDivisao
            // 
            this.buttonDivisao.Location = new System.Drawing.Point(304, 227);
            this.buttonDivisao.Name = "buttonDivisao";
            this.buttonDivisao.Size = new System.Drawing.Size(51, 30);
            this.buttonDivisao.TabIndex = 29;
            this.buttonDivisao.Text = "/";
            this.buttonDivisao.UseVisualStyleBackColor = true;
            this.buttonDivisao.Click += new System.EventHandler(this.buttonSubtracao_Click);
            // 
            // buttonMultiplicacao
            // 
            this.buttonMultiplicacao.Location = new System.Drawing.Point(304, 184);
            this.buttonMultiplicacao.Name = "buttonMultiplicacao";
            this.buttonMultiplicacao.Size = new System.Drawing.Size(51, 30);
            this.buttonMultiplicacao.TabIndex = 28;
            this.buttonMultiplicacao.Text = "x";
            this.buttonMultiplicacao.UseVisualStyleBackColor = true;
            this.buttonMultiplicacao.Click += new System.EventHandler(this.buttonDivisao_Click);
            // 
            // buttonSoma
            // 
            this.buttonSoma.Location = new System.Drawing.Point(247, 227);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(51, 30);
            this.buttonSoma.TabIndex = 27;
            this.buttonSoma.Text = "+";
            this.buttonSoma.UseVisualStyleBackColor = true;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // buttonSubtracao
            // 
            this.buttonSubtracao.Location = new System.Drawing.Point(247, 184);
            this.buttonSubtracao.Name = "buttonSubtracao";
            this.buttonSubtracao.Size = new System.Drawing.Size(51, 31);
            this.buttonSubtracao.TabIndex = 26;
            this.buttonSubtracao.Text = "-";
            this.buttonSubtracao.UseVisualStyleBackColor = true;
            this.buttonSubtracao.Click += new System.EventHandler(this.buttonSubtracao_Click);
            // 
            // textBoxExe1
            // 
            this.textBoxExe1.Location = new System.Drawing.Point(135, 119);
            this.textBoxExe1.Name = "textBoxExe1";
            this.textBoxExe1.Size = new System.Drawing.Size(100, 20);
            this.textBoxExe1.TabIndex = 25;
            // 
            // buttonExe1
            // 
            this.buttonExe1.Location = new System.Drawing.Point(247, 117);
            this.buttonExe1.Name = "buttonExe1";
            this.buttonExe1.Size = new System.Drawing.Size(75, 23);
            this.buttonExe1.TabIndex = 24;
            this.buttonExe1.Text = "button1";
            this.buttonExe1.UseVisualStyleBackColor = true;
            this.buttonExe1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Olá mundo!";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1162, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 686);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtPrimoValue;
        private System.Windows.Forms.Label lblValorPrimo;
        private System.Windows.Forms.Button btnPrimoValue;
        private System.Windows.Forms.Button btnPrimo;
        private System.Windows.Forms.Button btnParOuImpar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnNumeroMaior;
        private System.Windows.Forms.TextBox txtNumeroDois;
        private System.Windows.Forms.TextBox txtNumeroUm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textValorDois;
        private System.Windows.Forms.TextBox textValorUm;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonDivisao;
        private System.Windows.Forms.Button buttonMultiplicacao;
        private System.Windows.Forms.Button buttonSoma;
        private System.Windows.Forms.Button buttonSubtracao;
        private System.Windows.Forms.TextBox textBoxExe1;
        private System.Windows.Forms.Button buttonExe1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

