using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando as variaveis da classe dadosPessoa
            DadosPessoa pessoa1,pessoa2;

            //instanciando as duas pessoas
            pessoa1 = new DadosPessoa();
            pessoa2 = new DadosPessoa();

            //inserindo os dados da primeira pessoa
            Console.WriteLine("Insira o nome da primeira pessoa: ");
            pessoa1.nome = Console.ReadLine();
            Console.WriteLine("Insira a idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("_____________________________");


            //inserindo os dados da segunda pessoa
            Console.WriteLine("Insira o nome da segunda pessoa: ");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine("Insira a idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            //faz uma linha para separar os dados e faz a comparação de idades
            Console.WriteLine("_____________________________");
            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine(pessoa1.nome + " é Mais velho");
            }
            else
            {
                Console.WriteLine(pessoa2.nome + " é Mais velho");
            }

            //espera aperta algum botão para fechar a tela.
            Console.ReadKey();
        }
    }
}
