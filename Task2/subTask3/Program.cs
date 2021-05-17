using System;
using System.Collections;
using System.Collections.Specialized;
using subTask3.Classes;

namespace subTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary orda = new OrderedDictionary();
            orda.Add("1", "1,3123");
            orda.Add("2", "1,1126");
            orda.Add("3", "2,0120");
            Dictionary dic = new Dictionary(orda);
            Console.WriteLine( dic.IsBiger("1", "3"));
            Console.ReadKey();
        }
    }
}
