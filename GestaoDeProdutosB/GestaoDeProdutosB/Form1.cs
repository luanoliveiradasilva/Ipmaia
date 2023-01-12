using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestaoDeProdutosB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {

            try{
                Produto produtoUm = new Produto(
                textNome.Text,
                comboBoxCategoria.Text,
                textBoxDescricao.Text,
                double.Parse(textBoxPreco.Text)
                );

                listBoxProduto.Items.Add(produtoUm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void listBoxProduto_DoubleClick(object sender, EventArgs e)
        {
            //Produto listarProduto = listBoxProduto.SelectedItem as Produto;

            /*   MessageBox.Show(
                   listarProduto.getNome() + "\n"
                   + listarProduto.getCategoria() + "\n"
                   + listarProduto.getDescricao() + "\n"
                   + listarProduto.getPreco());*/

            // FormVerProduto formVerProduto = new FormVerProduto(listarProduto.getNome(), listarProduto.getCategoria(), listarProduto.getDescricao(), listarProduto.getPreco());
            if (listBoxProduto.SelectedItem != null) { 

                FormVerProduto formVerProduto = new FormVerProduto(this);
                formVerProduto.Show();

            }
            else
            {
                MessageBox.Show("Nenhum item selecionado!");
            }
        }

        private void ficheiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("dados.txt");

            foreach (Produto produto in listBoxProduto.Items)
            {
                sw.WriteLine(produto.stringFicheiro());
            }

            sw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("dados.txt"))
            {
                StreamReader sr = new StreamReader("dados.txt");
                string linha = sr.ReadLine();
                
                while(linha != "" && linha != null)
                {
                    string[] aux  = linha.Split('|'); 
                    Produto pTempo = new Produto(aux[0], aux[1], aux[2], double.Parse(aux[3]));

                    linha = sr.ReadLine();

                }

                sr.Close();
            }
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          DialogResult dr = MessageBox.Show("Guardar alteração?", "Fechar", MessageBoxButtons.YesNoCancel);
        }

        private void listBoxProduto_MouseDown(object sender, MouseEventArgs e)
        {
            listBoxProduto.SelectedIndex = listBoxProduto.IndexFromPoint(e.X, e.Y);
        }
    }
}
