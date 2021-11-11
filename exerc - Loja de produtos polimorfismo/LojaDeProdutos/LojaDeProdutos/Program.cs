using System;
using System.Globalization;

namespace LojaDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            //pede para o usuario digitar a quantidade de produtos
            Console.WriteLine("Digite o numero de produtos a ser registrado: ");
            int x = int.Parse(Console.ReadLine());

            //Criando vetor produto
            Produto[] vect = new Produto[x +1];

            for (int i = 1; i < x +1; i++)
            {
                //nesse bloco o usuario informa os dados do produto
                Console.WriteLine("__________________________________ ");
                Console.WriteLine($"Produto#{i}");
                Console.WriteLine("Comum, Usado ou Importado (c/u/i)? ");
                string tipo = Console.ReadLine();
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                //os ifs compara a letra digitada para saber se é comum,usado ou importado
                if (tipo == "c")
                {
                    
                    vect[i] = new Produto(nome, preco);

                }

                if (tipo == "u")
                {
                    //o usuario informa a data de fabricação
                    Console.WriteLine("Fabricação: ");
                    DateTime fabricacao = DateTime.Parse(Console.ReadLine());                    
                    vect[i] = new ProdutoUsado(nome, preco, fabricacao);
                }

                if (tipo == "i")
                {  
                    //o usuario informa a taxa
                    Console.WriteLine("Taxa: ");
                    double taxa = double.Parse(Console.ReadLine());
                    vect[i] = new ProdutoImportado(nome, preco, taxa);
                }
                
                

            }

            //nesse bloco mostra as informações dos produtos
            Console.WriteLine("__________________________________ ");
            Console.WriteLine("Etiquetas: ");
            for (int i = 0; i < x + 1; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i]);
                }
            }
        } 
    }
}
