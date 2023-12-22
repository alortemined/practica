using System;

class Program
{
    static void Main()
    {
        string filepath = @"C:\Users\khali\AppData\Local\JetBrains\Rider2023.3\projects\ConsoleApp3\ConsoleApp1 1.4 1 6.11\numsTask1.txt";
        string file = File.ReadAllText(filepath);
        string[] words = file.Split( ' ', '\n', '\t');
        int length = words.Length;
        
        for(int i = 0; i < length;i++)
        {
            if (words[i].Length % 2 != 0)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}