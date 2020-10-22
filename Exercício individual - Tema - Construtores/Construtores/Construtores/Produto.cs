using System.Globalization;

public class Produto
{ 
    public string Nome;
    public double Preco;
    public int Quantidade;

    //esse é o construtor, ele recebe 3 parâmentros. 
    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;

    }

    //função para calcular o valor total do estoque.
    public double ValorTotalEmEstoque() 
    {
        return Preco* Quantidade;
    }

    //função para adicionar a quantidade de produtos
    public void AdicionarProduto(int quantidade)
    {
        Quantidade += quantidade;
    }

    //função para receber um valor e subtrair da Quantidade
    public void RemoverProdutos(int quantidade)
    {
        Quantidade = Quantidade - quantidade;
    }

    //essa função mostra os dados atualizados
    public override string ToString() 
    {
        return Nome+", R$ "+Preco.ToString("F2", CultureInfo.InvariantCulture)+", "+Quantidade+" unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); 
    }
}