using System.Globalization;

public class Produto
{
    //declaração de variaveis, a variavel Preco e Quantidade estão sendo declaradas como Properties.
    private string _nome;
    public double Preco { get; private set; }
    public int Quantidade { get; private set; }

    //esse é o construtor, ele recebe 3 parâmentros. 
    public Produto(string nome, double preco, int quantidade)
    {
        _nome = nome;
        Preco = preco;
        Quantidade = quantidade;

    }

    //Properties, ele faz o get e no set tem uma condição de entrada para não receber nulo ou valor abaixo de 1.
    public string Nome
    {
        get { return _nome; }

        set { if (value != null && value.Length > 1)
                _nome = value;
            }
    }
}