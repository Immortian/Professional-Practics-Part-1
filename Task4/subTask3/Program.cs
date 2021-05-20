using System;
using System.Globalization;
using System.Text;
using System.Text.Encodings;

namespace subTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            product[] products = new product[3];
            products[0] = new product("Жаба", 50, 2);
            products[1] = new product("Дирижер", 100, 1);
            products[2] = new product("Дирижабль", 150, 1);
            check ch = new check(products);
            ch.printLikeSys();
            Console.ReadKey();
            Console.WriteLine();
            ch.printOnEn_Us();
            Console.ReadKey();

        }
        public class product
        {
            public product(string article, double priceofone, int count)
            {
                this.article = article;
                this.price = priceofone;
                this.count = count;
            }
            public string article { get; set; }
            public double price { get; set; }
            public int count { get; set; }
        }
        public class check
        {
            product[] basket;
            DateTime date;
            double fullprice = 0;
            public check(product[] products)
            {
                basket = products;

                date = DateTime.Now;
                
                foreach(product prod in basket)
                {
                    fullprice += prod.price * prod.count;
                }
            }

            public void printLikeSys()
            {
                CultureInfo cf = (CultureInfo.CurrentCulture);
                RegionInfo rf = (RegionInfo.CurrentRegion);
                foreach (var prod in basket)
                {
                    Console.WriteLine($"{prod.article} : {prod.price}{rf.CurrencySymbol} * {prod.count} = {prod.price * prod.count}{rf.CurrencySymbol}");
                }
                Console.WriteLine("---------------------------");
                Console.WriteLine($"Сумма: {fullprice}{rf.CurrencySymbol}");
                Console.WriteLine($"Время заказа: {date.ToString(cf.DateTimeFormat)}");
            }
            public void printOnEn_Us()
            {
                CultureInfo cf = new CultureInfo("en-us");
                RegionInfo rf = new RegionInfo("en-us");
                foreach (var prod in basket)
                {
                    Console.WriteLine($"{prod.article} : {prod.price}{rf.CurrencySymbol} * {prod.count} = {prod.price * prod.count}{rf.CurrencySymbol}");
                }
                Console.WriteLine("---------------------------");
                Console.WriteLine($"Сумма: {fullprice}{rf.CurrencySymbol}");
                Console.WriteLine($"Время заказа: {date.ToString(cf.DateTimeFormat)}");
            }

        }
    }
}
