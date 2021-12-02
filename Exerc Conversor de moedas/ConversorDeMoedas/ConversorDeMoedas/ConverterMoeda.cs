using System;
using System.Globalization;


namespace ConversorDeMoedas
{
    class ConverterMoeda
    {
        //declara variaveis com autoproperties
        public double Dolar { get; private set; }
        public double CompraDolar { get; private set; }
        public double IOF { get; private set; }
        

        //variaveis privadas
        private double dinheiroBruto;
        private double total;

        //construtor com 2 parametros
        public ConverterMoeda(double dolar, double compraDolar, double iof)
        {
            Dolar = dolar;
            CompraDolar = compraDolar;
            IOF = iof;
        }

        //função para fazer o calculo da converção
        public void ConversorMoeda()
        {
            dinheiroBruto = Dolar * CompraDolar;
            total = (IOF/100) * dinheiroBruto + dinheiroBruto;
        }

        public override string ToString()
        {
            //mostra o resultado final para o usuario
            return "Cotação do Dolar: "
                + "R$" + Dolar.ToString("F2", CultureInfo.InvariantCulture)

                + "\nQuantos dolar você irá comprar? "
                + "R$" + CompraDolar.ToString("F2", CultureInfo.InvariantCulture)

                + "\nValor a ser pago em Reais: "
                + "R$" + dinheiroBruto.ToString("F2", CultureInfo.InvariantCulture)

                + "\nValor do IOF: "
                + IOF.ToString("F2", CultureInfo.InvariantCulture) + "%"

                + "\nValor Total da compra com IOF: "
                + "R$" + total.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
