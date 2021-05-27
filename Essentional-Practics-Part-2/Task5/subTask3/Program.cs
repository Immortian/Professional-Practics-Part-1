using System;
using subTask3.Classes;

namespace subTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Article[] priceList = { new Article("товар 1", "пятерочка", 100), new Article("товар 2", "пятерочка", 150), new Article("товар 3", "пятерочка", 50) };
            Store store = new Store(priceList);
            Console.WriteLine("Выберите товар по номеру в списке");
            Article who = store[Convert.ToInt32(Console.ReadLine())];
            if (who != null)
                Console.WriteLine("товар " + who[0] + " в " + who[1] + " стоит " + who[3]);
            Console.WriteLine("Выберите товар по названю");
            who = store[Console.ReadLine()];
            if (who != null)
                Console.WriteLine("товар " + who[0] + " в " + who[1] + " стоит " + who[3]);

        }
    }
}
