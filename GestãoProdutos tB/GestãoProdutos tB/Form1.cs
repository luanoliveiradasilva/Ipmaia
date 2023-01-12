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

namespace GestãoProdutos_tB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Produto p1 = new Produto(textBoxNome.Text, comboBoxCategoria.Text, textBoxDescricao.Text, double.Parse(textBoxPreco.Text));
                listBoxProdutos.Items.Add(p1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxProdutos_DoubleClick(object sender, EventArgs e)
        {
            if(listBoxProdutos.SelectedItem != null)
            {
                //Produto p = listBoxProdutos.SelectedItem as Produto;
                //MessageBox.Show(p.GetNome() + "\n" + p.GetCategoria() + "\n" + p.GetDescricao() + "\n" + p.GetPreco() + " €");
                //FormVerProduto fMostrar = new FormVerProduto(p.GetNome(),p.GetCategoria(), p.GetDescricao(),p.GetPreco());

                FormVerProduto fMostrar = new FormVerProduto(this);
                fMostrar.Show();
            }
            
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("dados.txt");

            foreach(Produto x in listBoxProdutos.Items)
            {
                sw.WriteLine(x.StringFicheiro());
            }

            sw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists("dados.txt"))
            {
                StreamReader sr = new StreamReader("dados.txt");

                string linha = sr.ReadLine();

                while(linha != "" && linha != null)
                {
                    string[] aux = linha.Split('|');
                    Produto pTemp = new Produto(aux[0], aux[1], aux[2], double.Parse(aux[3]));
                    listBoxProdutos.Items.Add(pTemp);

                    linha = sr.ReadLine();
                }

                sr.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Guardar alterações?", "Fechar", MessageBoxButtons.YesNoCancel);
            
            if(dr == DialogResult.Yes)
            {
                guardarToolStripMenuItem.PerformClick();
            }
            else if(dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBoxProdutos.SelectedIndex >= 0)
            {
                listBoxProdutos.Items.RemoveAt(listBoxProdutos.SelectedIndex);
            }
        }
        private void listBoxProdutos_MouseDown(object sender, MouseEventArgs e)
        {
            listBoxProdutos.SelectedIndex = listBoxProdutos.IndexFromPoint(e.X, e.Y);
        }
    }
}
