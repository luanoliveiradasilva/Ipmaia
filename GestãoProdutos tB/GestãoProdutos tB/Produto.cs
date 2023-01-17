using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoProdutos_tB
{
    public class Produto
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
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetCategoria(string categoria)
        {
            this.categoria = categoria;
        }
        public string GetCategoria()
        {
            return categoria;
        }
        public void SetDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public string GetDescricao()
        {
            return descricao;
        }
        public void SetPreco(double preco)
        {
            this.preco = preco;
        }
        public double GetPreco()
        {
            return preco;
        }
        public string StringFicheiro()
        {
            return nome + "|" + categoria + "|" + descricao + "|" + preco;
        }


        public override string ToString()
        {
            return nome + " | " + categoria;
        }
    }
}
