namespace Task_11_04
{
    internal class Program
    {
        /*Напишите метод, который принимает массив чисел и возвращает
            их среднее значение. Используйте ключевое слово params*/
        static void Main(string[] args)
        {
            double average = Calculate(1, 2, 3, 4, 5);
            Console.WriteLine($"Среднее значение: {average}");
        }
        static double Calculate(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Массив не может быть пустым");
            }

            double summ = 0;
            foreach (int number in numbers)
            {
                summ += number;
            }
            return summ / numbers.Length;
        }
    }
}
