


namespace Exerc2
{
    public class NSI //NomeSalarioImposto
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido;

        public double CobraImposto(double ValorSalarial, double ValorImposto)
        {
            
            SalarioLiquido = ValorSalarial - ValorImposto;

            return SalarioLiquido;
        }
    }
}