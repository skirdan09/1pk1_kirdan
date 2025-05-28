﻿namespace Task_20_06
{
    internal class Program
    {
        /*Создайте программу, имитирующую работу светофора, используя перечисление TrafficLightColor:
        • Red
        • Yellow
        • Green
        Реализуйте автоматическое переключение цветов (каждые 3 секунды). 
        При смене цвета выводите его в консоль (можно с задержкой Thread.Sleep). 
        Добавьте возможность ручного переключения (например, по нажатию клавиши).
         */
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();

            //  автоматическое переключение в отдельном потоке
            Thread automaticThread = new Thread(trafficLight.Automatic);
            automaticThread.Start();

            // ручное переключение
            trafficLight.Switch();
        }
    }
}
