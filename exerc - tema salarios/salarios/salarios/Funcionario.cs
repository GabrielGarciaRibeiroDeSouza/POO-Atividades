using System;
using System.Collections.Generic;
using System.Text;

namespace salarios
{
    class Funcionario
    {
        //nesse bloco tem a declaração de variaveis com auto-properties
        public int Id { get; private set; }
        public string Nome { get;private set; }
        public double Salario { get;private set; }

        //construtor com 3 parâmetros 
        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        //função para aumentar o salario
        public void AumentarSalario(double porcentagem, double salario)
        {
            porcentagem = (porcentagem / 100)* salario;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario;
        }

    }
}
