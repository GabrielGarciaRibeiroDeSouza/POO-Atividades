using System;
using System.Globalization;

namespace Construtores
{
    public class Program
    {
        static void Main(string[] arg)
        {
            //nesse bloco de código, recebe os dados do usuário
            Console.WriteLine("Entre com os dados do produto;");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("_________________________________________________");

            //atruibuí os valores inseridos anteriormente na variavel "p"
            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: " + p);

            //nesse bloco chama a função de adicionar produtos da classe "Produto"
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine("_________________________________________________");

            //só mostra os dados atualizados
            Console.WriteLine("Dados do atualizados: " + p);

            //recebe um valor e depois subtrai esse valor do produto, por fim, mostra os dados atualizados.
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            Console.WriteLine("_________________________________________________");
            p.RemoverProdutos(qte); Console.WriteLine("Dados do atualizados: " + p);
            Console.WriteLine("_________________________________________________");

        }
    }
}
