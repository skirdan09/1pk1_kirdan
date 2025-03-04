namespace task_13_02
{
    using System;

    public class Pet
    {
        // Свойства
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool IsHealthy { get; set; } // true - здоров, false - нездоров


        // Конструктор с параметрами
        public Pet(string name, string animalType, int age, double weight, bool isHealthy)
        {
            Name = name;
            AnimalType = animalType;
            Age = age;
            Weight = weight;
            IsHealthy = isHealthy;
        }

        public Pet()
        {
        }

        // Метод для вывода информации об объекте
        public void DisplayInfo()
        {
            Console.WriteLine($"Кличка: {Name}");
            Console.WriteLine($"Вид: {AnimalType}");
            Console.WriteLine($"Возраст: {Age} лет");
            Console.WriteLine($"Вес: {Weight} кг");
            Console.WriteLine($"Состояние здоровья: {(IsHealthy ? "Здоров" : "Нездоров")}");
        }

        // Метод для изменения значения веса животного
        public void ChangeWeight(double newWeight)
        {
            Weight = newWeight;
            Console.WriteLine($"Вес питомца \"{Name}\" изменен на {Weight} кг.");
        }

        // Метод для изменения отметки о состоянии здоровья
        public void ChangeHealthStatus(bool isHealthy)
        {
            IsHealthy = isHealthy;
            Console.WriteLine($"Состояние здоровья питомца \"{Name}\" изменено на {(IsHealthy ? "Здоров" : "Нездоров")}");
        }
    }

    // Пример использования
    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра класса с использованием конструктора с параметрами
            Pet myPet = new Pet("Бублик", "Собака", 5, 20.5, true);

            // Вывод информации о питомце
            myPet.DisplayInfo();

            // Изменение веса питомца
            myPet.ChangeWeight(22.0);

            // Изменение статуса здоровья
            myPet.ChangeHealthStatus(false);

            // Вывод обновленной информации о питомце
            myPet.DisplayInfo();
            // Создание объекта питомца по умолчанию
            Pet defaultPet = new Pet();
            defaultPet.DisplayInfo();
        }
    }
}