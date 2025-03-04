namespace Task_11_07
{
    internal class Program
    {
        /*Напишите метод, который принимает массив целых чисел по
          ссылке и изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли
          оригинальный массив вне метода.*/
        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Оригинальный массив: " + string.Join(", ", originalArray));
            ModArray(ref originalArray);

            // Вывод оригинального массива 
            Console.WriteLine("Оригинальный массив после вызова метода: " + string.Join(", ", originalArray));
        }

        static void ModArray(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1; // Увеличиваем каждый элемент на 1
            }
        }
    }
}