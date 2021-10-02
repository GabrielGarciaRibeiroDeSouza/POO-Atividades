using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque
{
    class Produto
    {
        //Delcaração de variaveis
        public string Nome;
        public double Preco;
        public int Quantidade;

        //cria o construtor com 3 paramaetros, sendo eles os mesmos nomes das variaveis só que em minusculo
        public Produto ( string nome, double preco, int quantidada)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidada;
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
            return Nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade 
            + " unidades, Total: R$ "+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
