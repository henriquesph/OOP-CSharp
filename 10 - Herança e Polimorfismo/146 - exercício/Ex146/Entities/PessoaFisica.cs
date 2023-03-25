using System.Runtime.CompilerServices;

namespace Ex146.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double Imposto()
        {
            double imposto = 0;
            if (RendaAnual < 20000)
            {
                imposto = (RendaAnual * 15) / 100;
            }
            else if(RendaAnual > 20000)
            {
                imposto = (RendaAnual * 25) / 100;
            }
            else if(GastoSaude > 0)
            {
                imposto -= GastoSaude / 2;
            }
            return imposto;
        }
    }
}
