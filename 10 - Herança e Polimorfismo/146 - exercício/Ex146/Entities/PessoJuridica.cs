namespace Ex146.Entities
{
    class PessoJuridica : Pessoa
    {
        public int Nfuncionarios { get; set; }

        public PessoJuridica(string nome, double rendaAnual, int nFuncionarios) : base(nome, rendaAnual)
        {
            Nfuncionarios = nFuncionarios;
        }
        public override double Imposto()
        {
            double imposto = 0;
            if (Nfuncionarios >10)
            {
                imposto = (RendaAnual * 14) / 100;
            }
            else
            {
                imposto = (RendaAnual * 16) / 100;
            }
            return imposto;
        }
    }
}
