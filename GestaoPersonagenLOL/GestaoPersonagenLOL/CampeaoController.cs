using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GestaoPersonagenLOL
{

   
    public class CampeaoController : CampeaoInterface
    {

        // Extensiação da Interface Campeao 
        private Campeao dadosCampeao;


        //StringBuilder para concatenar as informacoes, por exemplo, titulo, titulo2 ou informacoes dos dados dos campeaoes.
        StringBuilder concatenarString = new StringBuilder();

        //Mostrar em qual diretorio sera salvo e indicar o nome que quer seja salvo.
        String file = @"D:\Documents\Jogos Digitais\Programação\Ipmaia\GestãoProdutos tB\dadosDosCampeaos.csv";

        //Utilizado para separar informacoes por ponto e virgula.
        /* Definido como ponto e virgula pora questoes de padrao do excel, 
         * se abrir o csv como bloco de nota sera exibido com ponto e virgula, se abrir no excel sera 
         * exibido por colunas normais.*/
        String separador = ";";


        // Contrutor da classe CampeaoController com inserção dos objetos parametrizado.
        public CampeaoController(Campeao dadosCampeao)
        {
            this.dadosCampeao = dadosCampeao;
        }

        //Override da função da interface
        public void cadastrarCampeao()
        {
            try
            { 
                //Execucao dos getters nos dados para atribuir a uma varivel do tipo list.
                string[] dadosCampeoes = {
                    dadosCampeao.getNome(),
                    dadosCampeao.getFuncao(),
                    dadosCampeao.getDificuldade(),
                    dadosCampeao.getDescricao()
                };

                this.concatenarString.AppendLine(string.Join(this.separador, dadosCampeoes));

                /*Verifica a existencia do arquivo no diretorio, caso nao existe nada, sera criado um arquivo 
                novo e adicionado o valor inicial.*/
                if (File.Exists(this.file))
                {
                    this.concatenarString.AppendLine(string.Join(this.separador, dadosCampeoes));
                }
                
                File.AppendAllText(this.file, this.concatenarString.ToString());

                MessageBox.Show("Campeão cadastrado! ");

            } catch (Exception ex) {

                MessageBox.Show("Não foi possível cadastrar campeão", ex.ToString());
            }        
        }
    }
}