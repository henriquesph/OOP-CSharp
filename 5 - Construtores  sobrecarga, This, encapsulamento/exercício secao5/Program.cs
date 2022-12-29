using System;

namespace exercício_secao5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número da conta");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o Titular da conta");
            string titular = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial [s/n]?");
            char depositoIni = char.Parse(Console.ReadLine());

            double saldo = 0;
            if (depositoIni == 's')
            {
                Console.WriteLine("Entre com o valor do Depósito");
                saldo = double.Parse(Console.ReadLine());
            }

            Conta c = new Conta(n, titular, depositoIni, saldo);

            Console.WriteLine(c);

            Console.WriteLine("Entre com um valor para depósito: ");
            double dep = double.Parse(Console.ReadLine());
            c.Depositar(dep);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

            Console.WriteLine("Entre com um valor para saque: ");
            double saq = double.Parse(Console.ReadLine());
            c.Saque(saq);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

        }
    }
}