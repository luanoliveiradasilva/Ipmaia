using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPersonagenLOL
{
    public class Habilidade
    {
       private string nomeHabilidade;

        public void setNomeHabilidade(string nomeHabilidade) {
            this.nomeHabilidade = nomeHabilidade;
        }
        public string getNomeHabilidade() {
            return this.nomeHabilidade;
        }

    }
}
