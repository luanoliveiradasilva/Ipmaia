using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2_tB
{
    class Chave
    {
        //ATRIBUTOS
        private int[] numeros;
        private int[] estrelas;

        //CONSTRUTORES
        public Chave()
        {
            numeros = new int[5];
            estrelas = new int[2];
        }

        //METODOS
        public void SetNumeros(int[] nNumeros)
        {
            numeros = nNumeros;
        }
        public int[] GetNumeros()
        {
            return numeros;
        }
        public void SetEstrelas(int[] nEstrelas)
        {
            estrelas = nEstrelas;
        }
        public int[] GetEstrelas()
        {
            return estrelas;
        }


        public override string ToString()
        {
            string chave = "";

            for (int i = 0; i < numeros.Length; i++)
            {
                chave += numeros[i] + " ";
            }
            chave += "+ ";
            for (int i = 0; i < estrelas.Length; i++)
            {
                chave += estrelas[i] + " ";
            }

            return chave;
        }
    }
}

//Criar metodo para adicionar numero e estrela uma a uma, fazendo verificações
