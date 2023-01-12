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
        public Chave(int[] nNumeros, int[] nEstrelas)
        {
            if(VerificarVetor(nNumeros) && VerificarVetor(nEstrelas))
            {
                numeros = nNumeros;
                estrelas = nEstrelas;
            }
            else
            {
                throw new Exception("Dados errados.");
            }
 
        }

        public Chave(int n1, int n2, int n3, int n4, int n5, int e1, int e2 )
        {
            numeros = new int[5];
            estrelas = new int[2];

            numeros[0] = n1;
            numeros[1] = n2;
            numeros[2] = n3;
            numeros[3] = n4;
            numeros[4] = n5;
            estrelas[0] = e1;
            estrelas[1] = e2;
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

        private bool VerificarVetor(int[] valores)
        {
            for(int indice = 0; indice < valores.Length; indice++)
            {
                for (int j = indice + 1; j < valores.Length; j++)
                {
                    if(valores[j] == valores[j])
                    {
                        return false;
                    }
                }
            }
            return true;
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
