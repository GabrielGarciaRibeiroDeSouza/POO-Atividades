using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;



namespace AlugueldeCarros
{
    class Fatura 
    {
        //declara as variaveis com autoproperties
        public double Pagamento { get; set; }
        public double Taxa{ get; set; }

        //cria o construtor com 2 parametros
        public Fatura(double pagamento, double taxa)
        {
            Pagamento = pagamento;
            Taxa = taxa;
        }

        //aplica a taxa ao pagamento e atribui o valor a variavel declarada
        public double TotalPagamento
        {
            get{ return Pagamento + Taxa; }
        }

        
        public override string ToString()
        {
            //mostra o resultado final para o usuario
            return "Pagamento: "
                + Pagamento.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: "
                + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal a Pagar: "
                + TotalPagamento.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
