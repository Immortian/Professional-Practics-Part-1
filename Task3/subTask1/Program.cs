using System;
using System.IO;


namespace subTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file name");
            string filename = Console.ReadLine();
            Console.WriteLine("Fill this file");
            string filefill = Console.ReadLine();
            StreamWriter sw = new StreamWriter(@filename);
            sw.WriteLine(filefill);
            sw.Close();
            Console.WriteLine($"File {filename} conteins:");
            StreamReader sr = new StreamReader(@filename);
            Console.Write(sr.ReadToEnd());
            sr.Close();
            Console.ReadKey();
        }
    }
}
