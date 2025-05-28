namespace Task_24_06
{
    internal class Program
    {
        /* Напишите метод, 
         * который принимает путь к файлу и возвращает количество строк в нем. 
         * ИспользуйтеStreamReader. */
        static void Main(string[] args)
        {
            string path = "text.txt";
            File.Create(path).Dispose();
            File.WriteAllText(path, "hello\nworld\n!");

            int lines = CountOfLines(path);
            Console.WriteLine($"Количество строк в файле: {lines}");
        }
        public static int CountOfLines(string filePath)
        {
            int lineCount = 0;
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                
                    lineCount++;
            }
            return lineCount;
        }
    }
}