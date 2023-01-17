using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeProdutosB
{
    public partial class FormVerProduto : Form
    {

        Form1 fmain; // Injeção de dependência.

        public FormVerProduto(Form1 fmain)
        {
            InitializeComponent();
            this.fmain = fmain;
        }
        /*public FormVerProduto(string nome, string categoria, string descricao, double preco)
        {
            InitializeComponent();

            labelNome.Text = nome;
            labelCategoria.Text = categoria;
            labelDescricao.Text = descricao;
            labelPreco.Text = "€ "+preco.ToString();
        }*/

        private void FormVerProduto_Load(object sender, EventArgs e)
        {
           Produto produtos =  fmain.listBoxProduto.SelectedItem as Produto;
                labelNome.Text = produtos.getNome();
                labelCategoria.Text = produtos.getCategoria();
                labelDescricao.Text = produtos.getDescricao();
                labelPreco.Text = "€ " + produtos.getPreco();
            }          
        }
}
