using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace GestaoPersonagenLOL
{

   
    public class RegistrarCampeoes : CampeaoInterface
    {

        // Criação de variável do tipo das classes.
        private Campeao dadosCampeao;
        private Habilidade habilidade;
        private Skin skin;


        //StringBuilder para concatenar as informacoes, por exemplo, titulo, titulo2 ou informacoes dos dados dos campeaoes.
        StringBuilder concatenarString = new StringBuilder();

        /*Validação de criação de diretório e criação e sugestao de nome para o arquivo csv*/
        CriarArquivos criarArquivos = new CriarArquivos();

        //Utilizado para separar informacoes por ponto e virgula.
        /* Definido como ponto e virgula pora questoes de padrao do excel, 
         * se abrir o csv como bloco de nota sera exibido com ponto e virgula, se abrir no excel sera 
         * exibido por colunas normais.*/
        String separador = ";";


        // Contrutor da classe CampeaoController com inserção dos objetos parametrizado.
        public RegistrarCampeoes(Campeao dadosCampeao, Habilidade dadosHabilidade, Skin dadosSkins )
        {
            this.dadosCampeao = dadosCampeao;
            this.habilidade = dadosHabilidade;
            this.skin = dadosSkins;

        }


        //Override da função da interface
        public void registrarCampeoes()
        {
            try
            {
                if(this.dadosCampeao != null || this.habilidade != null || this.skin != null)
                {


                    string[] dadosCampeoes = {
                            dadosCampeao.getNome(),
                            dadosCampeao.getFuncao(),
                            dadosCampeao.getDificuldade(),
                            dadosCampeao.getDescricao(),
                            habilidade.getNomeHabilidade(),
                            habilidade.getComandoHabilidade(),
                            habilidade.getDescricaoHabilidade(),
                            skin.getNomeSkins(),
                            skin.getSkinsHabilitada()                        
                    };
                    

                    this.concatenarString.AppendLine(string.Join(this.separador, dadosCampeoes));

                    File.AppendAllText(criarArquivos.lerArquivo(), this.concatenarString.ToString());

                    MessageBox.Show("Campeão cadastrado! ");
                }

            } catch (Exception ex) {

                MessageBox.Show("Não foi possível cadastrar campeão", ex.ToString());
            }        
        }
    }
}