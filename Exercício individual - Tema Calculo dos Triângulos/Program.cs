using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_dos_Triângulos
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração da variaveis da classe triangulo
            Triangulo x,y;

            //instanciamento das classes de x e y
            x = new Triangulo();
            y = new Triangulo();

            //inserindo os dados de x
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //calculo da area do triangulo x
            double p = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            //inserindo os dados de y
            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //calculo da area do triangulo y
            double o = (y.A + x.B + y.C) / 2;
            double areaY = Math.Sqrt(o * (o - y.A) * (o - y.B) * (o - x.C));

            //comparando se a area de x é maior que a de y
            if (areaX > areaY)
            {
                Console.WriteLine("Área de X é maior!");
            }
            else
            {
                Console.WriteLine("Área de Y é maior!");
            }
            
            Console.ReadKey();
        }
    }
}
