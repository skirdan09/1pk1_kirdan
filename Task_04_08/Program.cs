namespace Task_04_08
{
    internal class Program
    {
        /* Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения 
        которых равны

         */
        static void Main(string[] args)
        {
            int[] nums = new int[30];
            Random rand = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(0, 11);


            }

            Dictionary<int, int> count = new Dictionary<int, int>();

            foreach (var number in nums)
            {
                if (count.ContainsKey(number))
                {
                    count[number]++;
                }
                else
                {
                    count[number] = 1;
                }
            }

            // Подсчет количества пар
            int total = 0;
            foreach (var counts in count.Values)
            {
                if (counts > 1)
                {

                    total += counts * (counts - 1) / 2;
                }
            }
            Console.WriteLine("Количество пар элементов с равными значениями: " + total);
        }
    }
}