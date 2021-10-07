using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    class Estudante
    {
        //cria variaveis com autoproperties
        public string Nome { get; set; }
        public string Email { get; set; }

        //cria um construtor com 2 parametros 
        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
