using System;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace GestaoPersonagenLOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String file = @"D:\Documents\Jogos Digitais\Programação\Ipmaia\GestãoProdutos tB\dadosDosCampeaos.csv";

        private void campeaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Quando clicar no botao de cadastro, ira fechar a tela inicial.
            CampeaoForm campeaoForShow = new CampeaoForm();
            campeaoForShow.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            //Verificar a existencia do arquivo no diretorio.
            if (File.Exists(this.file))
            {
                //Ler o arquivo no diretorio
                string[] linhas = File.ReadAllLines(this.file);
                
                //Criando um DataTable
                DataTable dadosDaTabela = new DataTable();

                //Lendo Todas as linhas do arquivo CSV
                string[] Linha = File.ReadAllLines(this.file);

                //Percorrer todas as linhas
                for (int i = 0; i < Linha.Length; i++)
                {
                    //Aqui Estamos pegando a linha atual, e separando os campos
                    //Por exemplo, ele vai lendo um texto, e quando achar um ponto e virgula
                    //ele pega o texto e joga na outra posição do array temp, e assim por diante
                    //até chegar no final da linha

                    //Separando os campos e adicionado na data
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
                            DataColumn col = new DataColumn();
                            //Adicionando a coluna criada ao datatable
                            dadosDaTabela.Columns.Add(col);
                        }
                    }

                    //Inserindo uma linha(row) no datable (Vai fazer isso para cada linha encontrada
                    //no arquivo CSV
                    dadosDaTabela.Rows.Add(campos);
                }

                //Depois de montado o datatable, vamos falar para o grid
                //que a fonte de dados para ele exibir, será o datatable que 
                //a gente acabou de criar
                dataGridView2.DataSource = dadosDaTabela;
            }
            
        }
    }
}
