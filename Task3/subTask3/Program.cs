using System;
using System.IO;
using System.IO.IsolatedStorage;

namespace subTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();

            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream(@"file.set", FileMode.Create, userStorage);

            StreamWriter userWriter = new StreamWriter(userStream);
            Console.WriteLine("Write something");
            userWriter.WriteLine(Console.ReadLine());
            userWriter.Close();

            string[] files = userStorage.GetFileNames("file.set");

            if (files.Length == 0)
            {
                Console.WriteLine("No data saved for this user");
            }
            else
            {
                // Прочитать данные из потока.
                userStream = new IsolatedStorageFileStream(@"file.set", FileMode.Open, userStorage);

                StreamReader userReader = new StreamReader(userStream);
                string contents = userReader.ReadToEnd();
                Console.WriteLine(contents);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
