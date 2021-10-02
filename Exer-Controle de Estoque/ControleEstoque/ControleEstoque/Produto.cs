using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque
{
    class Produto
    {
        //prop
        //Delcaração de variaveis
        private string _nome;
        private double _preco;
        private int _quantidade;

        //cria o construtor com 3 paramaetros
        public Produto ( string nome, double preco, int quantidada)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidada;
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

        //get do preço
        public double Preco
        {
            get { return _preco; }
        }

        //get da quantidade
        public int Quantidade
        {
            get { return _quantidade; }
        }

        //função para calculo do valor em estoque
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        //função para adicionar produtos ao estoque
        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }

        // função para remover produtos do estoque
        public void RemoverProduto(int quantidade)
        {
            _quantidade = _quantidade - quantidade;
        }

        //função para mostrar o nome, quantidade e preco do estoque atual.
        public override string ToString()
        {
            return _nome + ", R$ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade 
            + " unidades, Total: R$ "+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
