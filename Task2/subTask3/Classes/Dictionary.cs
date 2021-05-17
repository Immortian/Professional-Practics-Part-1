using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace subTask3.Classes
{
    class Dictionary : OrderedDictionary
    {
        String[] myKeys;
        String[] myValues;
        OrderedDictionary dick = new OrderedDictionary();
        public Dictionary(OrderedDictionary value)
        {
            dick = value;
            myKeys = new String[dick.Count];
            myValues = new String[dick.Count];
            dick.Keys.CopyTo(myKeys, 0);
            dick.Values.CopyTo(myValues, 0);
        }
        public OrderedDictionary this[int i]
        {
            get => (OrderedDictionary)dick;
            set => dick = value;
        }
        public bool IsBiger(string Key1, string Key2)
        {
            
            string element_1 = (string)dick[Key1];
            string element_2 = (string)dick[Key2];

            Console.WriteLine(element_1 + " " + element_2);

            if (Convert.ToDouble(element_1) > Convert.ToDouble(element_2))
                return true;
            else
                return false;
        }
    }
}
