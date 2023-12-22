﻿using System;

class Program
{
    static void Main()
    {
        string filepath = @"C:\Users\khali\AppData\Local\JetBrains\Rider2023.3\projects\ConsoleApp3\ConsoleApp1 1.4 1 1.4 3\numsTask3.txt";
        string[] numbers = File.ReadAllText(filepath).Split(";");

        int minNumber = int.Parse(numbers[0]);
        int maxNumber = int.Parse(numbers[0]);

        foreach (string number in numbers)
        {
            int Number = int.Parse(number);
            {
                if (Number < minNumber)
                {
                    minNumber = Number;
                }

                if (Number > maxNumber)
                {
                    maxNumber = Number;
                }

                if (Number == 0)
                {
                    break;
                }
            }
            double ratio = (double)minNumber / maxNumber;
            
            Console.WriteLine($"Отношение мин {(minNumber)} и макс элементов {(maxNumber)}:{ratio}");
        }
    }
}