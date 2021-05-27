using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace subTask3.Classes
{
    class Article
    {
        private string poductName { get; set; }
        private string shopName { get; set; }
        private double price { get; set; }
        public Article(string pName, string sName, double pPrice)
        {
            poductName = pName;
            shopName = sName;
            price = pPrice;
        }
        public string this[int who]
        {
            get 
            { 
                if(who == 0)
                    return poductName;
                if (who == 1)
                    return shopName;
                else
                    return price.ToString();
            }
        }
    }
    class Store
    {
        private Article[] priceList { get; set; }
        public Store(Article[] array)
        {
            priceList = array;
        }
        public Article this[int index]
        {
            get { return priceList[index - 1]; }
            set { priceList[index] = value; }
        }
        public Article this[string name]
        {
            get 
            {
                foreach (var item in priceList)
                {
                    if (item[0] == name)
                        return item;
                }
                return null;
            }
        }
    }
}
