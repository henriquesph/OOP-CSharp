using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoeda;

public static class Conversor
{
    public static double IOF = 6.0;
    
    public static double Converter(double dolar, double cotacao)
    {
        double valorPagar;
        valorPagar = (dolar * cotacao);
        valorPagar += (valorPagar * IOF / 100);
        return valorPagar;
    }
}
