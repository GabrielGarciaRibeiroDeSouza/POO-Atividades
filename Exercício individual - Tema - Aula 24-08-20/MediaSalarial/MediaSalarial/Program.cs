using System;
using System.Globalization;


namespace MediaSalarial
{
    class Program
    {

        static void Main(string[] args)
        {
            MediaSalario A, B, MediaSalaraial;

            A = new MediaSalario();
            B = new MediaSalario();
            MediaSalaraial = new MediaSalario();

            Console.WriteLine("DADOS DO PRIMEIRO FUNCIONARIO: ");
            Console.WriteLine("Nome:");
            A.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario da primeira pessoa: ");
            A.Salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("nome: " + A.Nome.ToString() + "| Salario R$" + A.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("_________________________________________________________");



            Console.WriteLine("DADOS DO SEGUNDO FUNCIONARIO: ");
            Console.WriteLine("Nome:");
            B.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario da segunda pessoa: ");
            B.Salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("nome: " + B.Nome.ToString() + "| Salario R$" + B.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("_________________________________________________________");

            MediaSalaraial.Media(A.Salario,B.Salario);

            Console.WriteLine("A média Salarial é de R$" + MediaSalaraial.media + ",00");

            
        }
    }
}
