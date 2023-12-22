using System;

class Program
{
    static void Main()
    {
        string filepath = @"C:\Users\khali\AppData\Local\JetBrains\Rider2023.3\projects\ConsoleApp3\ConsoleApp1 1.4 1 6.22\numsTask2.txt";
        string[] words = File.ReadAllLines(filepath);
        string result = string.Join(" ", words);
        Console.WriteLine(result);
    }
}