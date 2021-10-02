using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque
{
    class Produto
    {
        //prop
        //Delcaração de variavel
        private string _nome;

        //declaração de variaveis com o auto-properties
        public double Preco { get; private set;}
        public int Quantidade { get; private set;}

        //cria o construtor com 3 paramaetros
        public Produto ( string nome, double preco, int quantidada)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidada;
        }

        //get e set do nome
        public string Nome
        {
            get { return _nome;}
            set 
            {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
                 
            }
        }
        
        //função para calculo do valor em estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //função para adicionar produtos ao estoque
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        // função para remover produtos do estoque
        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        //função para mostrar o nome, quantidade e preco do estoque atual.
        public override string ToString()
        {
            return _nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade 
            + " unidades, Total: R$ "+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
