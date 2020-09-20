using System;
using System.Globalization;

namespace Exerc2
{
    public class Program
    {
        static void Main(string[] args)
        {
            NSI A, B, SL; 

            A = new NSI();
            B = new NSI();
            SL = new NSI();

            Console.WriteLine("Insira os dados do funcionario(a)");
            Console.WriteLine("Nome: ");
            A.Nome = Console.ReadLine();

            Console.WriteLine("Digite o salario bruto:");
            A.SalarioBruto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor do imposto:");
            A.Imposto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("___________________________________________________");

            SL.CobraImposto(A.SalarioBruto, A.Imposto);

            Console.WriteLine("Funcionário(a): "+ A.Nome.ToString() + ", R$" + SL.SalarioLiquido.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
