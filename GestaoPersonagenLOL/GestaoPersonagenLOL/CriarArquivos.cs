using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPersonagenLOL
{
    public class CriarArquivos
    {

        public string lerArquivo()
        {
            //Mostrar em qual diretorio sera salvo e indicar o nome que quer seja salvo.
            string arquivo = @"C:\Users\" + Environment.UserName + @"\.leagueOfLegends\dadosDosCampeoes.csv";

            return arquivo;
    
        }
           
        public void criarDiretorio()
        {
            //Indica em qual direório será salvo mais a criação do subdiretório com o nome desejado.
            DirectoryInfo diretorio = new DirectoryInfo(@"C:\Users\" + Environment.UserName);

            diretorio.CreateSubdirectory(".leagueOfLegends");

        }


    }
}
