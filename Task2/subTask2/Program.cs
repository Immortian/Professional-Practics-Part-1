using System;
using System.Linq;
using System.Collections.Specialized;
using subTask2.Classes;
using System.Collections;

namespace subTask2
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] num = new int[3] { 21313, 42578, 85732 };
            double[] sum = new double[3] { 991313.99, 102578.98, 1285732.93 };
            CollectionType1 cum = new CollectionType1(num, sum);
            CollectionType2 cum2 = new CollectionType2(num, sum);
            CollectionType3 cum3 = new CollectionType3(num, sum);

           
            foreach (var em in cum.take().Values)
            {
                Console.WriteLine((double)em);
            }

            foreach (var em in cum2.take().Values)
            {
                Console.WriteLine((double)em);
            }

            foreach (var em in cum3.take().Values)
            {
                Console.WriteLine((double)em);
            }
        }
    }
}
