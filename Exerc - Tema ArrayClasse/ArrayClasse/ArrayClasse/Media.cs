using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayClasse
{
    class Media
    {
        //variavel para fazer a soma
        double soma = 0;

        //variavel para mostrar o resultado
        public double result;

        //função para fazer a media recebendo 2 parametros
        public void Somaste(int a, double[] vetor)
        {
            //um for para fazer a soma dos valores
            for (int i = 0; i < a; i++)
            {
                soma += vetor[i];
            }

            //adiciona o resultado a variavel resultado
            result = soma /= a;
        }
    }
}
