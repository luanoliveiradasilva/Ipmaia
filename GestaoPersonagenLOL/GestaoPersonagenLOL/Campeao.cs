using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPersonagenLOL
{  

   public class Campeao
    {
        private string nome;
        private string funcao;
        private string dificuldade;
        private string descricao;


        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setFuncao(string funcao)
        {
            this.funcao = funcao;
        }

        public string getFuncao()
        {
            return this.funcao;
        }

        public void setDificuldade(string dificuldade)
        {
            this.dificuldade = dificuldade;
        }

        public string getDificuldade()
        {
            return this.dificuldade;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public string getDescricao()
        {
            return this.descricao;
        }
    }
}
