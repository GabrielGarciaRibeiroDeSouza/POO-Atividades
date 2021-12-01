using System;
using System.Globalization;

namespace ConversorDeMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            //nesse bloco o usuario insere os dados solicitados
            Console.WriteLine("Informe a cotação do dolar: ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade de dolar que vai comprar: ");
            double comprarDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //cria um objeto e usa as variaveis com os dados digitados pelo usuario
            ConverterMoeda conversor = new ConverterMoeda(dolar, comprarDolar);
            
            //usa a função para converter as moedas
            conversor.ConversorMoeda();

            //imprime o resultado
            Console.WriteLine("=======================");
            Console.WriteLine(conversor.ToString());

            /*
             o projeto foi criado com base em uma uml simples que criei, depois utilizei os codigos
            de tarefas passada como guia.
            */
        }
    }
}
