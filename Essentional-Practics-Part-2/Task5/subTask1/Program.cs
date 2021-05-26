using System;

namespace subTask1
{
    class Program
    {
        static int[] arr;
        static void Main(string[] args)
        {
            Console.WriteLine("сколько элементов");
            int N = Convert.ToInt32(Console.ReadLine());
            arr = new int[N];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 100);
            }

            Console.WriteLine(string.Join(" ", arr));
            Highest();
            Lowest();
            Sum();
            Sred();
            Nechet();
        }
        private static void Highest()
        {
            int high = 0;
            foreach (var i in arr)
            {
                if (i > high)
                    high = i;
            }
            Console.WriteLine($"Наибольшее: {high}");
        }
        private static void Lowest()
        {
            int low = 100;
            foreach (var i in arr)
            {
                if (i < low)
                    low = i;
            }
            Console.WriteLine($"Наименьшее: {low}");
        }
        private static void Sum()
        {
            int sum = 0;
            foreach (var i in arr)
            {
                sum += i;
            }
            Console.WriteLine($"Сумма: {sum}");
        }
        private static void Sred()
        {
            int sum = 0;
            foreach (var i in arr)
            {
                sum += i;
            }
            Console.WriteLine($"Среднее: {sum/arr.Length}");
        }
        private static void Nechet()
        {
            Console.Write("Нечетные: ");
            foreach (var i in arr)
            {
                if (i % 2 == 1)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
