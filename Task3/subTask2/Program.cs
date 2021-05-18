using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace subTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file name");
            string path = Console.ReadLine();
            using (FileStream fs = File.OpenRead(@path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }

                Console.WriteLine("zip?");
                Console.ReadKey();

                FileStream destination = File.Create(@"archive.zip");

                GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);

                int theByte = fs.ReadByte();
                while (theByte != -1)
                {
                    compressor.WriteByte((byte)theByte);
                    theByte = fs.ReadByte();
                }

                compressor.Close();
            }
            Console.ReadKey();
        }
        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}
