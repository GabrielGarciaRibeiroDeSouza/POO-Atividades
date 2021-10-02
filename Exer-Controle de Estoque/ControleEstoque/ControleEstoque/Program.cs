using System;
using System.Globalization;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            /*esse bloco recebe os dados do usuario. Vale ressaltar que os "=" e "_" são para deixar a
             visulização no console mais organizada. */
            Console.WriteLine("===================================");
            Console.WriteLine("Entre com os dados do produto;");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            //instancia o objeto já com os dados do usuario
            Produto p = new Produto(nome, preco, quantidade);

            //mostra os dados atuais para o usuario
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("________________________________");
           
            /*nesse bloco ele pede para o usuario digitar a quantidade de produtos a ser adicionado e
             em seguida mostra os dados atuais do produto. */
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine("Dados do atualizados: " + p);
            Console.WriteLine("________________________________");

            /*nesse bloco pede a quantidada de produtos a serem removidos do estoque e em seguida
             mostra novamento os dados atuais do estoque. */
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            Console.WriteLine("Dados do atualizados: " + p);
            Console.WriteLine("===================================");
        }
    }
}
