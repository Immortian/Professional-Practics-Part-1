using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Classes
{
    class Product
    {
        public int productIndex { get; set; }
        public string productName { get; set; }
        public Category productCategory { get; set; }

        public enum Category { Food, Electronics, HouseHold, Games };
        public string GetCategoryName(Category cat)
        {
            switch(cat)
            {
                case Category.Food:
                    return "Food";
                case Category.Electronics:
                    return "Electronics";
                case Category.HouseHold:
                    return "HouseHold";
                case Category.Games:
                    return "Games";
                default: return null;
            }
        }
        public Product(int index, string name, Category category)
        {
            productIndex = index;
            productName = name;
            productCategory = category;
        }
    }
}
