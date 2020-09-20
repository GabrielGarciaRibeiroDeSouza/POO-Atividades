using System;
using System.Globalization;


namespace MediaSalarial
{
    class Program
    {

        static void Main(string[] args)
        {
            MediaSalario A, B;

            A = new MediaSalario();
            B = new MediaSalario();

            double media;

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            A.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa: ");
            A.Salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("nome: " + A.Nome.ToString() + "| Salario R$" + A.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("_________________________________________________________");



            Console.WriteLine("Digite o nome da segunda pessoa: ");
            B.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa: ");
            B.Salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("nome: " + B.Nome.ToString() + "| Salario R$" + B.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("_________________________________________________________");

            media = A.Salario + B.Salario;
            media = media / 2;

            Console.WriteLine("A média Salarial é de R$" + media.ToString() + ",00");

            
        }
    }
}
