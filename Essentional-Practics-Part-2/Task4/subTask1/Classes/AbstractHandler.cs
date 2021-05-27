using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace subTask1.Classes
{
    abstract class AbstractHandler
    {
        public string Path { get; set; }
        public abstract void Open();
        public abstract void Create();
        public abstract void Chenge();
        public abstract void Save();
        internal static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
    class XMLHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Введите текст для добавления в файл");
            if (Path != null)
            {
                Path = Path + ".xml";
                using (FileStream fs = File.OpenWrite(Path))
                {
                    AddText(fs, Console.ReadLine());
                }
            }
        }

        public override void Create()
        {
            if (Path != null)
            {
                Path = Path + ".xml";
                using (FileStream fs = File.Create(Path))
                {
                    AddText(fs, Console.ReadLine());
                }
            }
        }

        public override void Open()
        {
            Console.WriteLine("Содержимое файла:");
            using (FileStream fs = File.OpenRead(Path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }
        }

        public override void Save()
        {
            Console.WriteLine("XML файл сохранен");
        }
    }
    class TXTHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Введите текст для добавления в файл");
            if (Path != null)
            {
                Path = Path + ".txt";
                using (FileStream fs = File.OpenWrite(Path))
                {
                    AddText(fs, Console.ReadLine());
                }
            }
        }

        public override void Create()
        {
            Console.WriteLine("Введите текст для добавления в файл");
            if (Path != null)
            {
                Path = Path + ".txt";
                using (FileStream fs = File.OpenWrite(Path))
                {
                    AddText(fs, Console.ReadLine());
                }
            }
        }

        public override void Open()
        {
            Console.WriteLine("Содержимое файла:");
            using (FileStream fs = File.OpenRead(Path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }
        }

        public override void Save()
        {
            Console.WriteLine("TXT файл сохранен");
        }
    }
    class DOCHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Введите текст для добавления в файл");
            if (Path != null)
            {
                Path = Path + ".doc";
                using (FileStream fs = File.OpenWrite(Path))
                {
                    AddText(fs, Console.ReadLine());
                }
            }
        }

        public override void Create()
        {
            Console.WriteLine("Введите текст для добавления в файл");
            if (Path != null)
            {
                Path = Path + ".doc";
                using (FileStream fs = File.OpenWrite(Path))
                {
                    AddText(fs, Console.ReadLine());
                }
            }
        }

        public override void Open()
        {
            Console.WriteLine("Содержимое файла:");
            using (FileStream fs = File.OpenRead(Path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }
        }
        public override void Save()
        {
            Console.WriteLine("DOC файл сохранен");
        }
    }
}
