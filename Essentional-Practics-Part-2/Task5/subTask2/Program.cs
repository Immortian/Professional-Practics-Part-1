using System;
using subTask2.Classes;

namespace subTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("сколько элементов");
            Console.Write("X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            MyMatrix mm = new MyMatrix(x, y);
            int count = 0;
            foreach (var i in mm)
            {
                Console.Write(i + " ");
                count++;
                if(count % mm.GetLength(1) == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Добавляем 1 столбец и 3 строки\n");

            //Добавить столбец
            mm.AddRow(1);
            //Добавить строку
            mm.AddLevel(3);

            count = 0;
            foreach (var i in mm)
            {
                Console.Write(i + " ");
                count++;
                if (count % mm.GetLength(1) == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\nВведите номер интересующего вас ряда");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Элементы {N} ряда: ");
            Console.WriteLine(string.Join(" ", mm[N]));

            Console.WriteLine("сколько рядов и столбцов вас интересуют");
            Console.Write("X: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            count = 0;
            foreach (var i in mm.GetSpecial(x1, y1))
            {
                Console.Write(i + " ");
                count++;
                if (count % y1 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}