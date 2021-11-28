using System;
using System.Collections.Generic;
using System.Text;



namespace AlugueldeCarros
{
    class AluguelCarro { 
    
        //declaração de variaveis com autoproperties
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }
        public Veiculo Veiculo{ get; private set; }
        public Fatura Fatura{ get; set; }

        //declara o construtor com 3 parametros
        public AluguelCarro(DateTime inicio, DateTime fim, Veiculo veiculo)
        {
            checkin = inicio;
            checkout = fim;
            Veiculo = veiculo;
            Fatura = null;
        }
    }
}
