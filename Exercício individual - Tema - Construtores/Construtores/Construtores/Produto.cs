using System.Globalization;

public class Produto
{ 
    public string Nome;
    public double Preco;
    public int Quantidade;

    //esse � o construtor, ele recebe 3 par�mentros. 
    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;

    }

    //fun��o para calcular o valor total do estoque.
    public double ValorTotalEmEstoque() 
    {
        return Preco* Quantidade;
    }

    //fun��o para adicionar a quantidade de produtos
    public void AdicionarProduto(int quantidade)
    {
        Quantidade += quantidade;
    }

    //fun��o para receber um valor e subtrair da Quantidade
    public void RemoverProdutos(int quantidade)
    {
        Quantidade = Quantidade - quantidade;
    }

    //essa fun��o mostra os dados atualizados
    public override string ToString() 
    {
        return Nome+", R$ "+Preco.ToString("F2", CultureInfo.InvariantCulture)+", "+Quantidade+" unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); 
    }
}