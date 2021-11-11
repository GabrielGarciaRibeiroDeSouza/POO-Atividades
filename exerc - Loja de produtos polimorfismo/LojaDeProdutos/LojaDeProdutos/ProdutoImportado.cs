using System;
using System.Collections.Generic;


namespace LojaDeProdutos
{
    class ProdutoImportado : Produto
    {
        //declaração de variavel com autoproperties
        public double Taxa { get; set; }

        //construtor com 3 parametros e pegando variaveis da classe pai/base
        public ProdutoImportado(string nome, double preco, double taxa) : base(nome, preco)
        {
            Nome = nome;
            Preco = preco;
            Taxa = taxa;
            
        }

        //tostring 
        public override string ToString()
        {
            return Nome + " - R$ " + Preco + " - " + "(Taxa: " + Taxa + ")";
        }
    }
}
