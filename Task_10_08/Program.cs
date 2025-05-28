namespace Task_10_08
{
    internal class Program
    {
        /*Создайте метод, который на вход принимает 
         * одномерный массив и число для поиска, 
         * верните индекс искомого элемента в массиве. 
         * Если элемента нет – верните индекс = -1*/
        static void Main(string[] args) { }
        
            public class SearchExample
            {
            public static int FindElementIndex(int[] array, int target)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == target)
                    {
                        return i; // Элемент найден, возвращаем индекс
                    }
                }
                return -1; // Элемент не найден, возвращаем -1
            }

            public static void Main(string[] args)
            {
                int[] arr = { 1, 2, 3, 4, 5 };
                int numberToFind = 3;
                int index = FindElementIndex(arr, numberToFind);

                if (index != -1)
                {
                    Console.WriteLine($"Элемент {numberToFind} найден на индексе {index}.");
                }
                else
                {
                    Console.WriteLine($"Элемент {numberToFind} не найден.");
                }
            }
        }
    }
}
