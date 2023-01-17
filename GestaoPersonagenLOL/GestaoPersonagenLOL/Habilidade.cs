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
        private string comandoHabilidade;
        private string descricaoHabilidade;

        public void setNomeHabilidade(string nomeHabilidade) {
            this.nomeHabilidade = nomeHabilidade;
        }
        public string getNomeHabilidade() {
            return this.nomeHabilidade;
        }

        public void setComandoHabilidade(string comandoHabilidade)
        {
            this.comandoHabilidade = comandoHabilidade;
        }
        public string getComandoHabilidade()
        {
            return this.comandoHabilidade;
        }

        public void setDescricaoHabilidade(string descricaoHabilidade)
        {
            this.descricaoHabilidade = descricaoHabilidade;
        }
        public string getDescricaoHabilidade()
        {
            return this.descricaoHabilidade;
        }

    }
}
