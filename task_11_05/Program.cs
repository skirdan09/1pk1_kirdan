namespace Task_11_05
{
    internal class Program
    {
        /*Напишите метод, который принимает два числа по ссылке (ref) и
          возвращает их сумму и произведение через выходные параметры (out) */
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Add(ref a, ref b, out int sum, out int product);

            Console.WriteLine($"Сумма: {sum}, Произведение: {product}");
        }

        static void Add(ref int x, ref int y, out int sum, out int product)
        {
            sum = x + y;
            product = x * y;

            x++; // Увеличим x на 1
            y += 2; // Увеличим y на 2
        }
    }
}