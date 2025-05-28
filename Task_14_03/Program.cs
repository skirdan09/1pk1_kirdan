using System.Security.Cryptography.X509Certificates;

namespace Task_14_03
{
    internal class Program
    {
        /*Реализуйте статический метод Factorial, 
         * который принимает целое число и возвращает его факториал. 
         * Сделайте так, чтобы метод работал только для неотрицательных чисел.
         */
        static void Main(string[] args)
        {

            Console.Write("Введите число: ");
            int number;

                 
            if (int.TryParse(Console.ReadLine(), out number))
            {
                    long factorial = Factorial.GetFactorial(number);
                    Console.WriteLine($"Факториал {number} = {factorial}");
            }
            

        }
    }
}

