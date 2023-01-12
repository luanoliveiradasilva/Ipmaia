
namespace GestãoProdutos_tB
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
            this.labelPreco = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreco.Location = new System.Drawing.Point(483, 77);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(282, 73);
            this.labelPreco.TabIndex = 19;
            this.labelPreco.Text = "Exemplo";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(29, 266);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(86, 24);
            this.labelDescricao.TabIndex = 18;
            this.labelDescricao.Text = "Exemplo";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(26, 167);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(153, 39);
            this.labelCategoria.TabIndex = 17;
            this.labelCategoria.Text = "Exemplo";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(26, 69);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(153, 39);
            this.labelNome.TabIndex = 16;
            this.labelNome.Text = "Exemplo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome:";
            // 
            // FormVerProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 372);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVerProduto";
            this.Text = "FormVerProduto";
            this.Load += new System.EventHandler(this.FormVerProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}