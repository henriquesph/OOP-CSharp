namespace Retangulo
{
    public class RetanguloMedidas
    {
        public double largura;

        public double altura;

        public double Area()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            double p;
            p = (largura * 2) + (altura * 2);
            return p;
        }

        public double Diagonal()
        {
            double d;
            d = Math.Sqrt(largura * largura + altura * altura);
            return d;
        }
    }
}