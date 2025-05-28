namespace Task_03_06
{
    internal class Program
    {
        /*Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5.
         * 
         */
        static void Main(string[] args)
        {
            double h = 0.5;

            for (double x = -4; x <= 4; x += h)
            {
                double y = Math.Abs(x);
                Console.WriteLine($"x = {x}, y = {y}");
            }
        }
    }
}
