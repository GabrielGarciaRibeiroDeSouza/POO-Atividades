using System;
using System.Globalization;

namespace ArrayClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            //texto para deixar a interface amigavel
            Console.WriteLine("Insera a quantidade de pessoas: ");

            //variavel para o usuario inserir o valor da quantidade de pessoas
            int n = int.Parse(Console.ReadLine());

            //cria o vetor "vect" com o tamanho do valor inserido pelo usuario em n
            double[] vect = new double[n];

            //um for para ler os valores de altura de cada pessoa
            for(int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            
            //variavel para fazer a soma
            double soma = 0;
            
            //um for para fazer a soma dos valores
            for(int i = 0; i < n; i++)
            {
                soma += vect[i];
            }

            //faz a média e mostra o valor
            Console.WriteLine("a média é de: " + (soma / n).ToString( "F2", CultureInfo.InvariantCulture));
        }
    }
}
