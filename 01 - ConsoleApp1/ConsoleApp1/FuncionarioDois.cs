using System.Globalization;

namespace FuncionarioDois;

public class FuncionarioDados
{
    public string nome;
    public double salarioBruto;
    public double imposto;

    public double salarioLiquido()
    {
        double s;
        s = salarioBruto - imposto;
        return s;
    }

    public void aumentarSalario(double porcentagem)
    {
        salarioBruto = salarioBruto + (salarioBruto * porcentagem / 100);
    }

    public override string ToString()
    {
        string result = nome + ", R$" + salarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        return result;
    }
}