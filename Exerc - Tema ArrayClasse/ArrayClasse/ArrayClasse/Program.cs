using System;
using System.Globalization;

namespace ArrayClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            //faz a instancia do objeto
            Media media;
            media = new Media();

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

            //chama a função de fazer a media da classe Media
            media.Somaste(n, vect);
            

            //imprime o resultado
            Console.WriteLine("a média é de: " + media.result.ToString( "F2", CultureInfo.InvariantCulture));
        }
    }
}
