using System;
using System.Globalization;

namespace Encapsolamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicializa o objeto com um valor
            Produto p = new Produto("ps4", 6000, 10);

            //faz os printes de cada propriedade do produto usando o properties
            Console.WriteLine("Nome: " + p.Nome);
            Console.WriteLine("Preço: R$" + p.Preco);
            Console.WriteLine("Quantidade: " + p.Quantidade);

        }
    }
}
