using System;

class Program
{
    static void Main(string[] args)
    {
        string filepath = @"C:\Users\khali\AppData\Local\JetBrains\Rider2023.3\projects\ConsoleApp3\ConsoleApp1 1.4 1 1.3 2\nums.txt";
        string[] numbers = File.ReadAllText(filepath).Split(' ');

        for (int i = 0; i < numbers.Length; i++)
        {
            int num;
            if (int.TryParse(numbers[i], out num))
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}