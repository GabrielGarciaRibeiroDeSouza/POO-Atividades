using System;
using System.Globalization;

namespace salarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //recebe o valor de 'n'
            Console.WriteLine("Quantos funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            //esses 2 arrays são gambiarras que não funcionou
            //cria um array para pegar o id digitado posteriormente
            int[] compareId = new int[n];
            //cria um array para armazenar o salario
            double[] setSalario = new double[n];

            //cria um array com o tamnho de n
            Funcionario[] vectF = new Funcionario[n]; 
            
            //o usuario digita as informações dos funcionarios
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("___________________________");
                Console.WriteLine($"Funcionário #{i+1} ");
                Console.WriteLine("id: ");
                int id = int.Parse(Console.ReadLine());
                compareId[i] = id;//atribui o id digitado a outro array
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                setSalario[i] = salario;
                Console.WriteLine("___________________________");

                vectF[i] = new Funcionario(id, nome, salario);
            }

            Console.WriteLine("Digite o id que recebera o aumento no Salário: ");
            int id2 = int.Parse(Console.ReadLine());

            //gambiarra que não funciona
            for (int i = 0; i < n; i++)
            {
                if (id2 == compareId[i])
                {
                    Console.WriteLine("Pocentagem de aumento de salário: ");
                    double porcent = double.Parse(Console.ReadLine());
                    vectF[i].AumentarSalario(porcent,setSalario[i]);
                    
                }
                else
                {
                    Console.WriteLine("Este funcionario não exite");
                }
            }

            //mostra a tabela de funcionarios atualizada
            for (int i = 0; i < n; i++)
            {
                
                if (vectF[i] != null)
                {
                    Console.WriteLine(vectF[i]);
                }
            }

            
        }
    }
}
