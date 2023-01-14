using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GestaoPersonagenLOL
{

   
    public class RegistrarCampeoes : CampeaoInterface
    {

        // Extensiação da Interface Campeao 
        private Campeao dadosCampeao;
        private Habilidade habilidade;

        //StringBuilder para concatenar as informacoes, por exemplo, titulo, titulo2 ou informacoes dos dados dos campeaoes.
        StringBuilder concatenarString = new StringBuilder();

        //Mostrar em qual diretorio sera salvo e indicar o nome que quer seja salvo.
        String file = @"D:\Documents\Jogos Digitais\Programação\Ipmaia\GestaoPersonagenLOL\dadosDosCampeaos.csv";


        //Utilizado para separar informacoes por ponto e virgula.
        /* Definido como ponto e virgula pora questoes de padrao do excel, 
         * se abrir o csv como bloco de nota sera exibido com ponto e virgula, se abrir no excel sera 
         * exibido por colunas normais.*/
        String separador = ";";


        // Contrutor da classe CampeaoController com inserção dos objetos parametrizado.
        public RegistrarCampeoes(Campeao dadosCampeao, Habilidade habilidade)
        {
            this.dadosCampeao = dadosCampeao;
            this.habilidade = habilidade;

        }


        //Override da função da interface
        public void registrarCampeoes()
        {
            try
            { 
                //Execucao dos getters nos dados para atribuir a uma varivel do tipo list.
                string[] dadosCampeoes = {
                    dadosCampeao.getNome(),
                    dadosCampeao.getFuncao(),
                    dadosCampeao.getDificuldade(),
                    dadosCampeao.getDescricao(),
                    habilidade.getNomeHabilidade(),
                };

                this.concatenarString.AppendLine(string.Join(this.separador, dadosCampeoes));

                File.AppendAllText(this.file, this.concatenarString.ToString());

                MessageBox.Show("Campeão cadastrado! ");

            } catch (Exception ex) {

                MessageBox.Show("Não foi possível cadastrar campeão", ex.ToString());
            }        
        }
    }
}