namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                Console.WriteLine("Введите текст:");

                string userInput = Console.ReadLine();

                if (userInput == "exit" || userInput == "")
                {
                    break;
                }
                count++;
                Console.Clear();
            }
            Console.WriteLine("Количество введенных строк:" + count);
        }
    }
}