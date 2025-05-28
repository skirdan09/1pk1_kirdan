namespace Task_24_08
{
    internal class Program
    {
        /* Реализуйте функцию, осуществляющую поиск текста в файле 
          и его замену на значения, введенные пользователем. */
        static void Main(string[] args)
        {
            Console.Write("Введите путь к файлу: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Ошибка: Указанный файл не существует.");
                return;
            }
            Console.Write("Введите текст для поиска: ");
            string searchText = Console.ReadLine();

            Console.Write("Введите текст для замены: ");
            string replaceText = Console.ReadLine();

            try
            {
                // Чтение файла
                string fileContent = File.ReadAllText(filePath);

                // Замена текста
                string updatedContent = fileContent.Replace(searchText, replaceText);

                // Запись обновленного содержимого обратно в файл
                File.WriteAllText(filePath, updatedContent);

                Console.WriteLine("Замена выполнена успешно.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}