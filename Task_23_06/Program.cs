namespace Task_23_06
{
    internal class Program
    {
        /*Напишите программу со следующими функциями:
        1. Выведите информации о всех дисках в системе
        2. Выведите содержимое каталога C:\Users (названия папок)
        3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
        a) Создание вложенного каталога “temp”
        b) Вывод информации о текущем каталоге (имя, родитель и тд)
        c) Вывод информации о вложенном каталоге
        4. Переместите каталог “temp” по пути “D:\work\newTemp”
        a) Реализуйте вывод информационного сообщения об успешном (или нет)
        перемещении
        5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет)
        удалении.
         */
        static void Main(string[] args)
        {

            //1
            List<DriveInfo> drives = DriveInfo.GetDrives().ToList();

            Console.WriteLine("Диски: ");
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine(drive.Name);
                Console.WriteLine($"Размер диска: {drive.TotalSize/1024/1024/1024} Гб");
                Console.WriteLine($"Доступное место: {drive.AvailableFreeSpace / 1024 / 1024 / 1024} Гб");
                Console.WriteLine($"Тип диска: {drive.DriveType}");
                Console.WriteLine($"Метка диска: {drive.VolumeLabel}");
            }

            //2
            Console.Write("Введите название каталога: ");
            string pathName = Console.ReadLine();

            if (Directory.Exists(pathName))
            {
                Console.WriteLine($"Файлы в папке {pathName}");
                List<String> list = Directory.GetDirectories(pathName).ToList();

                if (list.Count > 0)
                {
                    foreach (String file in list)
                    {
                        Console.WriteLine(file);
                    }
                }
            }
            else
                Console.WriteLine("Каталог не существует");


            //3

            string work = @"D:\work";
            Directory.CreateDirectory(work);

            string temp = Path.Combine(work, "temp");
            Directory.CreateDirectory(temp);

            DirectoryInfo currentDirectory = new DirectoryInfo(work);
            Console.WriteLine("Информация о текущем каталоге:");
            Console.WriteLine($"Имя: {currentDirectory.Name}");
            Console.WriteLine($"Путь: {currentDirectory.FullName}");
            Console.WriteLine($"Родитель: {currentDirectory.Parent?.FullName}");


            DirectoryInfo tempInfo = new DirectoryInfo(temp);
            Console.WriteLine("Информация о вложенном каталоге:");
            Console.WriteLine($"Имя: {tempInfo.Name}");
            Console.WriteLine($"Путь: {tempInfo.FullName}");
            Console.WriteLine($"Родитель: {tempInfo.Parent?.FullName}");


            //4
            string newTemp = Path.Combine(work, "newTemp");

            if (Directory.Exists(temp))
            {
                Directory.Move(temp, newTemp);
                Console.WriteLine("Каталог перемещён успешно");
            }
            else
            {
                Console.WriteLine("Каталог не существует");
            }

            //5

            Directory.Delete(temp, true);
            Console.WriteLine($"Каталог '{temp}' удален.");
        }
    }
}
