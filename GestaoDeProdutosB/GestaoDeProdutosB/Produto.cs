using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutosB
{
    internal class Produto
    {
        private string nome;
        private string categoria;
        private string descricao;
        private double preco;

        public Produto()
        {
            nome = "";
            categoria = "";
            descricao = "";
            preco = 0;
        }

        public Produto(string nome, string categoria, string descricao, double preco)
        {
            this.nome = nome;
            this.categoria = categoria;
            this.descricao = descricao;
            this.preco = preco;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }

        public void setCategoria(string categoria)
        {
            this.categoria = categoria;
        }

        public string getCategoria()
        {
            return categoria;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public string getDescricao()
        {
            return descricao;
        }

        public void setPreco(double preco)
        {
            this.preco = preco;
        }

        public double getPreco()
        {
            return preco;
        }

        public string stringFicheiro()
        {
            return nome + "|" + categoria + "|" + descricao + "|" + preco;
        }

        public override string ToString()
        {
            return nome + " | " + categoria;
        }
    }
}
