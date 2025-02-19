﻿namespace Task_11_06
{
    internal class Program
    {
        /*Передача массива по значению: Напишите метод, который принимает массив целых чисел и
        изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли оригинальный
        массив вне метода
         */
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(0, 11);
                Console.Write(array[i] + " ");    
            }
            Console.WriteLine();

            GetArray(array);
                
            foreach (int el in array)
                Console.Write(el + " ");
            Console.WriteLine();
        }

        /// <summary>
        /// увеличивает элементы массива на 1
        /// </summary>
        /// <param name="array">массив</param>
        static void GetArray(int[] array)
        {
            for (int i = 0;i < array.Length;i++)
            {
                array[i]++;
                
            }
           
            
        }
    }
}
