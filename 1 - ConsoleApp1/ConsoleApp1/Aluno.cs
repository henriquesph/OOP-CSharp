using System;

namespace Aluno;

public class AlunoNotas
{
    public double notaUm;
    public double notaDois;
    public double notaTres;

    public double NotaFinal()
    {
        double total = notaUm + notaDois + notaTres;
        return total;
    }

    public bool Aprovado()
    {
        if (NotaFinal() >= 60)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public double PontosRestantes()
    {
        double notaRest;
        notaRest = 60 - NotaFinal();
        return notaRest;
    }
}
