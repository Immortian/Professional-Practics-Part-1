using System;
using Task2.Classes;
namespace subTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "Чайник", Product.Category.HouseHold);
            Product p2 = new Product(2, "Клубника", Product.Category.Food);
            Product p3 = new Product(3, "Телефон", Product.Category.Electronics);
            Product[] prods = { p1, p2, p3 };

            Customer c1 = new Customer(1, new Product[]{ p2, p3 });
            Customer c2 = new Customer(2, new Product[] { p2 });
            Customer c3 = new Customer(3, new Product[] { p1, p3 });
            Customer[] cuss = new Customer[] { c1, c2, c3};

            SellsCollection sells = new SellsCollection(cuss, prods);

            Console.WriteLine(sells.GetBasketOf(0));
            Console.WriteLine(sells.GetBuyers(2));
        }
    }
}
