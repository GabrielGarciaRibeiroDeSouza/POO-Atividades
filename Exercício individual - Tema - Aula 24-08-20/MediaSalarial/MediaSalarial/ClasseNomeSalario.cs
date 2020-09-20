


namespace MediaSalarial
{
    class MediaSalario
    {
        public double Salario;
        public string Nome;
        public double media;

        public double Media(double valor1, double valo2)
        {
            media = valor1 + valo2;
            media = media / 2;

            return media;
        }
    }
}