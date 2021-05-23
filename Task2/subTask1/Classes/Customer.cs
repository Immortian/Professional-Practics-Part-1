using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Classes
{
    class Customer
    {
        public int customerIndex { get;set; }
        public Product[] productBasket { get; set; }
        public Customer(int index, Product[] buyitems)
        {
            customerIndex = index;
            productBasket = buyitems;
        }
    }
}
