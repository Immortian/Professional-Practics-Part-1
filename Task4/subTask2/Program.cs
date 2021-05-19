using System;
using System.Collections.Generic;

namespace subTask2
{
    class Program
    {
        static List<string> predlogs = new List<string> { "в", "с", "к", "у", "над", "на", "перед", "при", "около", "под", "вокруг", "возле" };
        static void Main(string[] args)
        {
            Console.WriteLine("Write string in Russian");
            string text = Console.ReadLine();
            char[] ch = new char[] { ' ', ',', '.' };
            string[] words = text.Split(ch, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < words.Length; i++)
            {
                if (predlogs.Contains(words[i]))
                    words[i] = "ГАВ!";
            }
            string result = string.Join(" ", words);
            Console.WriteLine(result);
        }
    }
}
