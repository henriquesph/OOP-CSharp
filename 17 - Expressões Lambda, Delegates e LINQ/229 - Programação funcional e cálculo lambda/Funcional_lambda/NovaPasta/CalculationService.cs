using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// static: método de classe, não precisa instanciar objeto para ser executado, não depende do estado do objeto, ou seja, dos valores do objeto instanciado, os valores são passados na classe que executa, exemplo: MATH
// todos os objetos criado apontam para o mesmo endereço de memória static

namespace Course.Services
{
    class CalculationService
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Square(double x)
        {
            return x * x;
        }
    }
}