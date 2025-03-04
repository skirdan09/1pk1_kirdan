namespace Task_11_02
{
    internal class Program
    {//*Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке и
меняет их местами. Проверьте, изменились ли значения переменных вне метода
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Switch (ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        private static void Switch(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
