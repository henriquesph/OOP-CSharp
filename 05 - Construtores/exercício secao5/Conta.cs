using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_secao5
{
    public class Conta
    {
        public int N { get; private set; }
        public string Titular { get; private set; }
        public char DepositoIni { get; private set; }
        public double Deposito { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int n, string titular, char depositoIni, double saldo)
        {
            N = n;
            Titular = titular;
            DepositoIni = depositoIni;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor - 5;
        }

        public override string ToString()
        {
            return "Conta: " + N
                + " Titular: " + Titular
                + ", Saldo: R$" + Saldo;
        }
    }
}