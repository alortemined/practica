using System;
using System.IO;


class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\khali\AppData\Local\JetBrains\Rider2023.3\projects\ConsoleApp3\ConsoleApp1 1.4 1 1.3 1\input.txt");
        
        string[] selectedNumbersStr = lines[0].Split(' ');
        int[] selectedNumbers = Array.ConvertAll(selectedNumbersStr, int.Parse);
        
        int n = int.Parse(lines[1]);
        
        using (StreamWriter writer = new StreamWriter(@"C:\Users\khali\AppData\Local\JetBrains\Rider2023.3\projects\ConsoleApp3\ConsoleApp1 1.4 1 1.3 1\output.txt"))
        {
            for (int i = 2; i < n + 2; i++)
            {
                string[] ticketNumbersStr = lines[i].Split(' ');
                int[] ticketNumbers = Array.ConvertAll(ticketNumbersStr, int.Parse);
                
                int count = 0;
                foreach (int number in ticketNumbers)
                {
                    if (selectedNumbers.Contains(number))
                    {
                        count++;
                        if (count >= 3)
                        {
                            break;
                        }
                            
                    }
                }
                if (count >= 3)
                {
                    writer.WriteLine("Lucky");
                }
                else
                {
                    writer.WriteLine("Unlucky");
                }
            }
        }
        Console.WriteLine(" Результаты записаны в файл Output.txt.");
    }
}