using System;
using System.Collections.Generic;
using System.Text;


namespace AlugueldeCarros
{
    class Veiculo 
    {
        //declara a variavel com autoproperties
        public string ModeloCarro{ get; set; }

        //cria o construtor com um parametro
        public Veiculo(string modeloCarro)
        {
            ModeloCarro = modeloCarro;
        }
    }
}
