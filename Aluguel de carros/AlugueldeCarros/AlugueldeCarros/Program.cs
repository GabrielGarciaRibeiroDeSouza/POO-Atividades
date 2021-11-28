using System;
using System.Globalization;

namespace AlugueldeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados da locação:");//texto no console 
            Console.Write("Modelo do veiculo: ");//texto para o usuario digitar
            string modeloCarro = Console.ReadLine();//declara a variavel para receber os dados inserido pelo usuario
            Console.Write("Check-in (dd / MM / yyyy HH:mm): ");//texto para o usuario digitar a data
            DateTime checkin = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);//declara a variavel "checkin" para receber a data digitado
            Console.Write("Check -out (dd / MM / yyyyHH:mm): ");//texto para o usuario digitar a data
            DateTime checkout = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);//declara a variavel "checkout" para receber a data digitado

            Console.Write("Entre com o preço por hora: ");//texto para o usuario colocar o valor da hora
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//declaração da variavel "hora" para receber o valor da hora
            Console.Write("Entre com preço por dia: ");//texto para o usuario colocar o valor do dia
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//declara a variavel para receber o valor digitado
            
            //instancia o objeto "alugarCarro" da classe "AluguelCarro", tem como um dos parametros uma segunda classe, a "veiculo"; para receber os dados digitados
            AluguelCarro alugarCarro = new AluguelCarro(checkin, checkout, new Veiculo(modeloCarro));
            
            //instancia o objeto da classe "ServicoLocacao", tendo como um dos parametros a classe "taxaServicoBR"
            ServicoLocacao servicoLocacao = new ServicoLocacao(hora, dia, new TaxaServicoBR());
            
            //passa os dados digitados para a função da classe "ServicoLocacao"
            servicoLocacao.ProcessoFatura(alugarCarro);


            // os "==" serve apenas para destacar os resultados
            Console.WriteLine("================================");
            Console.WriteLine("FATURA: ");//texto para interface de usuario
            Console.WriteLine(alugarCarro.Fatura);//mostra a fatura atual armazenada no objeto da classe "aluguelCarro"
            Console.WriteLine("================================");
        }
    }
}
