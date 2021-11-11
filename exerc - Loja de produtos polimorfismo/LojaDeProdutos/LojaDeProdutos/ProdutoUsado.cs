using System;
using System.Collections.Generic;


namespace LojaDeProdutos
{
    class ProdutoUsado: Produto
    {
        public DateTime Fabricacao { get; set;  }

        //construtor com 3 parametros e pegando variaveis da classe pai/base
        public ProdutoUsado (string nome, double preco, DateTime fabricacao) : base(nome, preco)
        {
            Nome = nome;
            Preco = preco;
            Fabricacao = fabricacao;
        }

        public override string ToString()
        {
            return Nome + "(Usado) - R$ " + Preco + " - " + $"(fabricado: {Fabricacao.ToString("dd/MM/yyyy")})";
        }
    }
}
