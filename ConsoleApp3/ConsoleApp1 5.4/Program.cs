using System;

class Program
{
    static void Main()
    {
        string filepath = @"C:\Users\khali\AppData\Local\JetBrains\Rider2023.3\projects\ConsoleApp3\ConsoleApp1 1.4 1 5.44\numsTask4.txt";
        string file = File.ReadAllText(filepath);
        string[] numbers = file.Split(' ');

        int max = int.MinValue;
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int num = int.Parse(numbers[i]);
            if (num > max)
            {
                max = num;
            }
            else if (num + 1 < max)
            {
                sum += num + 1;
            }
        }
        Console.WriteLine("Сумма элементов:" + sum);
    }
}