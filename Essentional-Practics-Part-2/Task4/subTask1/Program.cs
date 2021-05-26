using System;
using subTask1.Classes;
using System.Text.RegularExpressions;

namespace subTask1
{
    class Program
    {
        public static AbstractHandler handler;
        private static void WhatType()
        {
            Console.WriteLine("выберите фомат файла: XML, TXT, DOC");
            switch(Console.ReadLine())
            {
                case "XML": handler = new XMLHandler();
                    break;
                case "TXT": handler = new TXTHandler();
                    break;
                case "DOC": handler = new DOCHandler();
                    break;
                default:
                    WhatType(); break;
            }
        }
        private static Regex openr = new Regex(@"^Open");
        private static Regex changer = new Regex(@"^Change");
        private static Regex saver = new Regex(@"^Save");
        private static Regex creater = new Regex(@"^Create");
        private static void Command()
        {
            Console.WriteLine("Введите команду");

            string command = Console.ReadLine();
            if(openr.IsMatch(command))
            {
                char[] c = { ' ', '.' };
                handler.Path = command.Split(c, StringSplitOptions.RemoveEmptyEntries)[1];
                handler.Open();
            }
            if (changer.IsMatch(command))
            {
                char[] c = { ' ', '.' };
                handler.Path = command.Split(c, StringSplitOptions.RemoveEmptyEntries)[1];
                handler.Chenge();
            }
            if (saver.IsMatch(command))
            {
                handler.Save();
                return;
            }
            if (creater.IsMatch(command))
            {
                char[] c = { ' ', '.' };
                handler.Path = command.Split(c, StringSplitOptions.RemoveEmptyEntries)[1];
                handler.Create();
            }
            Command();
        }
        static void Main(string[] args)
        {
            WhatType();
            Command();
        }
    }
}
