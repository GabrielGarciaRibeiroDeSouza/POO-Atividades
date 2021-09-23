using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo_do_Circulo
{
    class Calculadora
    {
        //declaraçao da variavel como static pi;
        public static double Pi = 3.14;
        
        //declaraçao da funcao circunferencia com o parametro de double r e statico.
        public static double Circuferencia(double r)
        {
            //retorna o resultado da conta abaixo.
            return 2.0 * Pi * r;
        }

        //declaraçao da funcao volume com parametro de double r e statico.
        public static double Volume(double r)
        {
            //retorna o resultado da conta abaixo.
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
