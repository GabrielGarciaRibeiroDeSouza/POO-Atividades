using System;
using System.Globalization;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia o objeto
            Estudante[] vect = new Estudante[10];
            
            // recebe a quatidade de quartos que usuario inserir
            Console.WriteLine("Quantos quartos serão alugados? ");
            Console.WriteLine("o maximo é 9!");
            int n = int.Parse(Console.ReadLine());

            //nesse for o usuario digita os dados do hospede
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Hospede #{i+1} ");//coloquei +1 para começar do hospede 1.
                Console.WriteLine("Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Email");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }

            //esse for verifica o vetor "vect" e se não for nulo, imprime o que o vect armazenou no indice.
            Console.WriteLine("");
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
