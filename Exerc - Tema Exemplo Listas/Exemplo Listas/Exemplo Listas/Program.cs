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

            //adicionando elementos na lista
            list.Add("Fábio"); list.Add("Wilsooon!"); list.Add("Angelina"); list.Add("Eliney"); list.Add("André");

            //adicionando mais um elemento na posição informada
            list.Insert(2, "Lucas");
            
            //esse loop mostra os itens da lista
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //conta quantos elementos tem na lista
            Console.WriteLine("Quantidade de elementos na lista: " + list.Count);

            
            //encontra o primeiro iten iniciado com a letra A
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro item com a letra A: " + s1);

            //encontrar o ultimo elemento que inicia com a letra A
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo item com a letra A: " + s2);

            //buscar item pela posição
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição de 'A': " + pos1);

            //busca a ultima posição com a letra a
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição de 'A': " + pos2);

            //buscar todos os itens com o tamanho igual a 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------");
            //loop para imprimir os itens
            foreach (string obj in list2)
            {
                Console.WriteLine("Nome com 5 caracteres: " + obj);
            }

            //Remover itens da lista
            list.Remove("André");
            Console.WriteLine("===========================");
            foreach (string obj in list)
            {
                Console.WriteLine( obj);
            }

            //remover determinado item da lista
            list.RemoveAll(x => x[0] == 'W');
            Console.WriteLine("+++++++++++++++++++++++++++");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            //remover item de determinada posição da lista
            list.RemoveAt(3);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remover itens da lista a partir da posição e quantos itens
            list.RemoveRange(1, 2);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXX");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
        }

    }
}
