using System;
using System.Globalization;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //recebe o valor digitado pelo usuario
            Console.WriteLine("insira o tamanho da matriz quadrada: ");
            int n = int.Parse(Console.ReadLine());

            //cria uma matriz com o valor dgitado pelo usuario
            int[,] mat = new int[n, n];

            Console.WriteLine("insira os valores da matiz: ");

            //for para o usuario inserir os dados
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(',');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            //esse for verifica os numeros nas diagonais
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(mat[i, j] + "");
                    }
                    
                }
                
            }

            //verifica quantos numeros negativos foram inserido na matriz
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Números negativos: " + count);
        }
    }
}
