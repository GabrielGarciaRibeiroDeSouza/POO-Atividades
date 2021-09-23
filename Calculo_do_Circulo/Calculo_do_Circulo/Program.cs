using System;
using System.Globalization;

namespace Calculo_do_Circulo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //GG_non
            //declara a variavel calc para instanciar a classe calculadora.
            calculadora calc = new calculadora();
            
            //imprime uma mesagem no console e depois espera receber um valor do usuario
            Console.WriteLine("Entre com valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            //declaracao daa variaveis circ e volume, que pega a funcao da classe calculadora. 
            double circ = calc.Circuferencia(raio);
            double volume = calc.Volume(raio);
            
            //imprime os valores em sequecia das variaveis circ, volume e pi (que fica dentro da classe calculadora)
            Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " +calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        
    }
}

