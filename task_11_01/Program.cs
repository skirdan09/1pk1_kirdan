namespace task_11_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine($"До вызова метода: x= {x},y={y}");
            Swap(x, y);
            Console.WriteLine($"После вызова метода: x= {x},y={y}");
        }
        static void Swap(int a,int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
