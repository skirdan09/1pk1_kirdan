using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_06
{
    internal class TrafficLight
    {
        private TrafficLightColor currentColor;
        

        public TrafficLight()
        {
            currentColor = TrafficLightColor.Red; // Начальный цвет
        }

        public void Automatic()
        {
            while (true)
            {
                switch (currentColor)
                {
                    case TrafficLightColor.Red:
                        SetColor(TrafficLightColor.Green);
                        break;
                    case TrafficLightColor.Green:
                        SetColor(TrafficLightColor.Yellow);
                        break;
                    case TrafficLightColor.Yellow:
                        SetColor(TrafficLightColor.Red);
                        break;
                }

                Thread.Sleep(3000); // Задержка в 3 секунды
            }
        }

        public void SetColor(TrafficLightColor color)
        {
            currentColor = color;
            Console.Clear();
            Console.WriteLine($"Текущий цвет светофора: {currentColor}");
            
        }

        public void Switch()
        {
            while (true)
            {
                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Spacebar) // Переключение по пробелу
                {
                    switch (currentColor)
                    {
                        case TrafficLightColor.Red:
                            SetColor(TrafficLightColor.Green);
                            break;
                        case TrafficLightColor.Green:
                            SetColor(TrafficLightColor.Yellow);
                            break;
                        case TrafficLightColor.Yellow:
                            SetColor(TrafficLightColor.Red);
                            break;
                    }
                }
            }
        }
    }
}

