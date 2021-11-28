using System;
using System.Collections.Generic;
using System.Text;

namespace AlugueldeCarros
{
    //herda a interface
    class TaxaServicoBR : ITaxaServico
    {
        
        public double Taxa(double qtdTaxa)
        {
            //if para verificar se a taxa for maior que 100 cobra20%
            if (qtdTaxa <= 100.00)
            {
                return qtdTaxa * 0.2;
            }
            else//se não cobra 15%
            {
                return qtdTaxa * 0.15;
            }
        }
    }
}
