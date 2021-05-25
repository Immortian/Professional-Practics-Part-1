using System;
using System.Text.RegularExpressions;
using subTask3.Classes;
namespace subTask3
{
    class Program
    {
        public static int ver = 0;
        public static bool YorN()
        {
            Console.WriteLine("Y or N");
            if (Console.ReadLine() == "Y")
                return true;
            else if (Console.ReadLine() == "N")
                return false;
            else YorN();
            return true;
        }
        public static void Upgrade()
        {
            if (ver == 1)
            {
                Console.WriteLine("Приобрести верию Expert за 99$?");
                if (YorN() == true)
                    ver++;
            }
            if (ver == 0)
            {
                Console.WriteLine("Приобрести верию Pro за 99$?");
                if (YorN() == true)
                    ver++;
            }
            
        }
        public static DocumentWorker dw = new DocumentWorker();
        public static DocumentWorker dw1 = new ProDocumentWorker();
        public static DocumentWorker dw2 = new ExpertDocumentWorker();
        static Regex openreg = new Regex(@"^Open\s\w+\.\w+$");
        static Regex editreg = new Regex(@"^Edit$");
        static Regex savereg = new Regex(@"^Save$");
        static void Main(string[] args)
        {
            if(ver == 1)
            {
                dw = dw1;
            }
            if(ver == 2)
            {
                dw = dw2;
            }

            string command = Console.ReadLine();
            if (openreg.IsMatch(command))
            {
                dw.OpenDocument();
            }
            if (editreg.IsMatch(command))
            {
                dw.EditDocument();
            }
            if (savereg.IsMatch(command))
            {
                dw.SaveDocument();
            }
            Main(null);
        }
    }
}
