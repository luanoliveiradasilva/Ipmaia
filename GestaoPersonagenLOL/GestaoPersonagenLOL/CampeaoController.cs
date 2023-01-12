using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace GestaoPersonagenLOL
{
    public class CampeaoController : CampeaoInterface
    {

        // Extensiação da Interface Campeao 
        private Campeao dadosCampeao;

 
        // Contrutor da classe CampeaoController com inserção dos objetos parametrizado.
        public CampeaoController(Campeao dadosCampeao)
        {
            this.dadosCampeao = dadosCampeao;
        }

        //Override da função da interface
        public void cadastrarCampeao()
        {
            if (File.Exists("dados.txt"))
            {
                StreamReader sr = new StreamReader("dados.csv");
                string linha = sr.ReadLine();

                while (linha != "" && linha != null)
                {
                    string[] aux = linha.Split('|');
                    Produto pTempo = new Produto(aux[0], aux[1], aux[2], double.Parse(aux[3]));

                    linha = sr.ReadLine();

                }

                sr.Close();
            }

        }

    }
}