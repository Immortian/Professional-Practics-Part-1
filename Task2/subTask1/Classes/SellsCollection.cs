using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2.Classes
{
    class SellsCollection
    {
        Customer[] customers;
        Product[] products;
        public SellsCollection(Customer[] Customers, Product[] Products)
        {
            customers = Customers;
            products = Products;
        }
        public SellsCollection(Product[] Products)
        {
            products = Products;
        }
        public SellsCollection()
        {
            customers = new Customer[1];
            products = new Product[1];
        }

        public void Add(Customer cus, Product prod)
        {
                if (customers == null)
                    customers = new Customer[1];
                if (products == null)
                    products = new Product[1];

            if (customers[^1] == null)
                customers[^1] = cus;
                else
                {
                    var newArray = new Customer[customers.Length + 1];
                    customers.CopyTo(newArray, 0);
                    newArray[newArray.Length - 1] = cus;
                    customers = newArray;
                }

            if (products[^1] == null)
                products[^1] = prod;
            else
            {
                var newArray = new Product[products.Length + 1];
                products.CopyTo(newArray, 0);
                newArray[newArray.Length - 1] = prod;
                products = newArray;
            }
        }
        public void Add(Product prod)
        {
            if (products == null)
                products = new Product[1];

            if (products[^1] == null)
                products[^1] = prod;
            else
            {
                var newArray = new Product[products.Length + 1];
                products.CopyTo(newArray, 0);
                newArray[newArray.Length - 1] = prod;
                products = newArray;
            }
        }
        public void Add(Customer cus)
        {
            if (customers == null)
                customers = new Customer[1];

            if (customers[^1] == null)
                customers[^1] = cus;
            else
            {
                var newArray = new Customer[customers.Length + 1];
                customers.CopyTo(newArray, 0);
                newArray[newArray.Length - 1] = cus;
                customers = newArray;
            }
        }

        public string GetBasketOf(int i)
        {
            string result = "Customer " +
                customers[i].customerIndex + ", bought this products:\n";

            foreach( var prod in customers[i].productBasket)
            {
                result += "" + prod.productName + " - " + prod.GetCategoryName(prod.productCategory) +"\n";
            }
            return result;
        }

        public string GetBuyers(int i)
        {
            string result = "Category " +
                products[i].GetCategoryName(products[i].productCategory) + ", bought by:\n";

            foreach (var cust in customers)
            {
                if(cust.productBasket.Contains(products[i]))
                    result += "Customer " + cust.customerIndex + "\n";
            }
            return result;
        }
    }
}
