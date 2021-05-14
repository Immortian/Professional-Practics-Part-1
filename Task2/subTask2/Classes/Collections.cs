using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace subTask2.Classes
{
    class CollectionType1 : HybridDictionary
    {
        private static HybridDictionary dictionary = new HybridDictionary();
        public CollectionType1(int[] num, double[] sum)
        {
            int Length = 0;
            if (num.Length == sum.Length)
                Length = num.Length;
            else if (num.Length < sum.Length)
                Length = num.Length;
            else
                Length = sum.Length;

            for (int i = 0; i < Length; i++)
            {
                dictionary.Add(num[i], sum[i]);
            }
        }
        public HybridDictionary take()
        {
            return (HybridDictionary)dictionary;
        }
    }
    class CollectionType2 : SortedList
    {
        private static SortedList dictionary = new SortedList();
        public CollectionType2(int[] num, double[] sum)
        {
            int Length = 0;
            if (num.Length == sum.Length)
                Length = num.Length;
            else if (num.Length < sum.Length)
                Length = num.Length;
            else
                Length = sum.Length;

            for (int i = 0; i < Length; i++)
            {
                dictionary.Add(num[i], sum[i]);
            }
        }
        public SortedList take()
        {
            return (SortedList)dictionary;
        }
    }
    class CollectionType3 : OrderedDictionary
    {
        private static OrderedDictionary dictionary = new OrderedDictionary();
        public CollectionType3(int[] num, double[] sum)
        {
            int Length = 0;
            if (num.Length == sum.Length)
                Length = num.Length;
            else if (num.Length < sum.Length)
                Length = num.Length;
            else
                Length = sum.Length;

            for (int i = 0; i < Length; i++)
            {
                dictionary.Add(num[i], sum[i]);
            }
        }
        public OrderedDictionary take()
        {
            return (OrderedDictionary)dictionary;
        }
    }
}
