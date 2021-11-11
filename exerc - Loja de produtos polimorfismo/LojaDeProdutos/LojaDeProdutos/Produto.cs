using System;
using System.Collections.Generic;

namespace LojaDeProdutos
{
    class Produto
    {
        //declaração de variaveis com autoproperties
        public string Nome { get; set; }
        public double Preco { get; protected set; }

        //construtor com  2 parâmetros
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        //função que retorna em string o nome e preço
        public override string ToString()
        {
            return Nome + " - R$ " + Preco;
        }
        
    }
}
