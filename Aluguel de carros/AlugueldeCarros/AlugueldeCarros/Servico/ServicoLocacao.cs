using System;
using System.Collections.Generic;
using System.Text;

namespace AlugueldeCarros
{
    class ServicoLocacao
    {
        //declara variaveis com autoproperties
        public double PrecoPorHora{ get; private set; }
        public double PrecoPorDia{ get; private set; }

        //declara a variavel da interface "ITaxaServico"
        private ITaxaServico _taxaServico;

        //cria o construtor com 3 parametros
        public ServicoLocacao(double precoPorHora, double precoPorDia, ITaxaServico taxaServico)
        { 
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaServico = taxaServico;
        }

        //declara uma função tendo como parametro a classe "AluguelCarro" para usar os dados da classe
        public void ProcessoFatura(AluguelCarro alugaCarro)
        {
            //declara a variavel e atribui o resultado da conta(checkout - checkin) 
            TimeSpan duracao = alugaCarro.checkout.Subtract(alugaCarro.checkin);

            //daclara a variavel para receber o valor bruto
            double pagamento = 0.0;

            //if para verificar se vai cobrar por dia ou hora
            if (duracao.TotalHours <= 12.0)
            { 
                //é atribuido a variavel o valor bruto por hora
                pagamento = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                //é atribuido a variavel o valor bruto por dia
                pagamento = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }
            
            //aplica a taxa no valor bruto fatura atual para "aluguelCarro"
            double taxa = _taxaServico.Taxa(pagamento);
            //passa a fatura atual para "aluguelCarro"
            alugaCarro.Fatura = new Fatura(pagamento, taxa);
    }
    }
}
