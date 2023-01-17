namespace GestaoDeProdutosB
{
    partial class FormVerProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(133, 79);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(79, 29);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(133, 149);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(79, 29);
            this.labelCategoria.TabIndex = 4;
            this.labelCategoria.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descrição:";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(133, 220);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(79, 29);
            this.labelDescricao.TabIndex = 6;
            this.labelDescricao.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Preço:";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreco.Location = new System.Drawing.Point(388, 79);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(79, 29);
            this.labelPreco.TabIndex = 8;
            this.labelPreco.Text = "label8";
            // 
            // FormVerProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label1);
            this.Name = "FormVerProduto";
            this.Text = "FormVerProduto";
            this.Load += new System.EventHandler(this.FormVerProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPreco;
    }
}