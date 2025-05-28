namespace Task_05_03
{
    internal class Program
    {
        /*Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если
        да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
        элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны.)
         */
        static void Main(string[] args)
        {
            char[,] matrix1 = {
                { 'm', 'b', 'c' },
                { 'd', 'e', 'f' },
                { 'g', 'h', 'i' }
            };

            char[,] matrix2 = {
                { 'v', 'f', 'c' },
                { 'd', 'e', 'b' },
                { 'g', 'l', 'z' }
            };

            if (matrix1 == matrix2)
            {
                Console.WriteLine("Матрицы равны.");
            }
            else
            {
                Console.WriteLine("Матрицы не равны. \nСовпадающие элементы:");
                PrintMatricesWithHighlight(matrix1, matrix2);
            }
        }

        static bool AreMatricesEqual(char[,] matrix1, char[,] matrix2)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void PrintMatricesWithHighlight(char[,] matrix1, char[,] matrix2)
        {
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Если элементы равны, выводим с цветом
                    if (matrix1[i, j] == matrix2[i, j])
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Цвет совпадающих элементов
                        Console.Write(matrix1[i, j] + " ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Цвет несовпадающих элементов
                        Console.Write(matrix1[i, j] + " ");
                    }
                }
                Console.ResetColor();

                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    if (matrix1[i, j] == matrix2[i, j])
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Цвет совпадающих элементов
                        Console.Write(matrix2[i, j] + " ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Цвет несовпадающих элементов
                        Console.Write(matrix2[i, j] + " ");
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}

