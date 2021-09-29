using System;
using System.Collections.Generic;

namespace Exemplo_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Professores: ");

            //criando uma lista
            List<string> list = new List<string>();

            //adicionando elementos na matriz
            list.Add("Fábio"); list.Add("Wilsooon!"); list.Add("Angelina"); list.Add("Eliney"); list.Add("André");

            list.Insert(2, "Lucas");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
