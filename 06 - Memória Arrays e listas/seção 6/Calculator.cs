using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seção_6
{
    class Calculator
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static void Triplicar(ref int x)
        {
            x = x * 3;
        }

        public static void Dobro(int origin, out int result)
        {
            result = origin * 2;
        }
    }
}
