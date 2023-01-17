using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Collections.Generic;
using System.Collections;

namespace GestaoPersonagenLOL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        CriarArquivos criarArquivos = new CriarArquivos();
        private string valorDataGrid;

        private void campeaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Vai criar diretório inicial
            criarArquivos.criarDiretorio();
            // Quando clicar no botao de cadastro, ira fechar a tela inicial.
            this.Hide();
            CampeaoForm campeaoForShow = new CampeaoForm();
            campeaoForShow.Show();
        }


        private void Main_Load(object sender, EventArgs e)
        {

            //Verificar a existencia do arquivo no diretorio.
            if (File.Exists(criarArquivos.lerArquivo()))
            {
                
                //Criando um DataTable
                DataTable dadosDaTabela = new DataTable();


                //Lendo Todas as linhas do arquivo CSV
                string[] Linha = File.ReadAllLines(criarArquivos.lerArquivo());

                //Percorrer todas as linhas
                for (int i = 0; i < Linha.Length; i++)
                {
                    //Aqui Estamos pegando a linha atual, e separando os campos
                    //Por exemplo, ele vai lendo um texto, e quando achar um ponto e virgula
                    //ele pega o texto e joga na outra posição do array, e assim por diante
                    //até chegar no final da linha
                    string[] campos = Linha[i].Split(Convert.ToChar(";"));

                    //Um datable precisa de colunas
                    //Como a função acima jogou cada campo em uma posição do array de acordo com
                    //o ponto e virgula, eu estou pegando quantos campos ele achou e criando a mesma
                    //quantidade de colunas no datatable para corresponder a cada campo
                    if (i == 0)
                    {
                        for (int j = 0; j < campos.Length; j++)
                        {
                            //Criando uma coluna
                            DataColumn colunas = new DataColumn();

                            //Adicionando a coluna criada ao datatable
                            dadosDaTabela.Columns.Add(colunas);
                        }
                    }

                    //Inserindo uma linha(row) no datable (Vai fazer isso para cada linha encontrada
                    //no arquivo CSV
                    dadosDaTabela.Rows.Add(campos);
                }

                //Depois de montado o datatable, vamos falar para o grid
                //que a fonte de dados para ele exibir, será o datatable que 
                //a gente acabou de criar
                dataGridView1.DataSource = dadosDaTabela;

                dataGridView1.Columns[0].HeaderText = Titulos.Nome;
                dataGridView1.Columns[1].HeaderText = Titulos.Funcao;
                dataGridView1.Columns[2].HeaderText = Titulos.Dificuldade;
                dataGridView1.Columns[3].HeaderText = Titulos.Descricao;
                dataGridView1.Columns[4].HeaderText = Titulos.NomeHabilidades;
                dataGridView1.Columns[5].HeaderText = Titulos.ComandoHabilidades;
                dataGridView1.Columns[6].HeaderText = Titulos.DescricaoHabilidades;
                dataGridView1.Columns[7].HeaderText = Titulos.NomeSkins;
                dataGridView1.Columns[8].HeaderText = Titulos.SkinsHabilitada;
            }           

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string valorDataGrids;
            List<string> valoresDosGrids = new List<string>();


            for (int i=0; i < 9 ; i++)
            {
                valorDataGrids = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                valoresDosGrids.Add(valorDataGrids);
            };


            Form2 teste = new Form2(valoresDosGrids);

            teste.Show();

        }
    }
}
