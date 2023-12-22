﻿using System;

class Program
{
    static void Main(string[] args)
    {
        string filepath = @"C:\Users\khali\AppData\Local\JetBrains\Rider2023.3\projects\ConsoleApp3\ConsoleApp1 1.4 1 1.5 1\numsTask1.txt";
        string[] numbers = File.ReadAllLines(filepath);

        int minIndex = 0;
        int min = int.Parse(numbers[0]);

        for (int i = 1; i < numbers.Length; i++)
        {
            int current = int.Parse(numbers[i]);
            if (current < min)
            {
                min = current;
                minIndex = i;
            }
        }

        int product = 1;
        for (int i = minIndex + 1; i < numbers.Length; i++)
        {
            product *= int.Parse(numbers[i]);
        }
        Console.WriteLine(product);
    }
    
    
}