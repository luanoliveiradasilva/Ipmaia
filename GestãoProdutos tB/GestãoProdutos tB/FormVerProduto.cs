using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestãoProdutos_tB
{
    public partial class FormVerProduto : Form
    {
        Form1 fMain;

        public FormVerProduto(Form1 fMain)
        {
            InitializeComponent();
            this.fMain = fMain;
        }
        public FormVerProduto(string nome, string categoria, string descricao, double preco)
        {
            InitializeComponent();

            labelNome.Text = nome;
            labelCategoria.Text = categoria;
            labelDescricao.Text = descricao;
            labelPreco.Text = preco.ToString() + " €";
        }

        private void FormVerProduto_Load(object sender, EventArgs e)
        {
            Produto p = fMain.listBoxProdutos.SelectedItem as Produto;
            
            labelNome.Text = p.GetNome();
            labelCategoria.Text = p.GetCategoria();
            labelDescricao.Text = p.GetDescricao();
            labelPreco.Text = p.GetPreco().ToString() + " €";
        }
    }
}
