using ClassePessoa;
using System;
using System.Globalization;

namespace MostraPessoaMaisVelha
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Pessoa A, B;

            A = new Pessoa();
            B = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            A.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa: ");
            A.Idade = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("nome: " + A.Nome.ToString() + "| idade: " + A.Idade.ToString());
            Console.WriteLine("_________________________________________________________");



            Console.WriteLine("Digite o nome da segunda pessoa: ");
            B.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa: ");
            B.Idade = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("nome: " + B.Nome.ToString() + "| idade: " + B.Idade.ToString());
            Console.WriteLine("_________________________________________________________");




            if (A.Idade > B.Idade)
            {
                Console.WriteLine("O(a) " + A.Nome.ToString() + " é o mais velho");
            }
            else
            {
                Console.WriteLine("O(a) " + B.Nome.ToString() + " é o mais velho");

            }
        }
    }
}
