using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_03
{
    internal class Factorial
    {
        public static long GetFactorial(int n)
        {
            
            if (n < 0) // условие для неотрцательных чисел
            {
                Console.WriteLine("Факториал только для неотрицательных чисел.");

                return 0;
            }

            long result = 1;
            for (int i = 2; i <= n; i++) // нахождение факториала
            {
                result *= i;
            }

            return result;
        }

    }
}    

