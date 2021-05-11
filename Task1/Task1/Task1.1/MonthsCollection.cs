using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Task1._1
{
    class MonthsCollection
	{
        Element[] elements;

        public MonthsCollection(Element[] arr)
        {
            elements = arr;
        }
        public MonthsCollection()
        {
            Element[] elements = new Element[1];
        }
        public Element this[int index]
		{
			get { return elements[index]; }
			set { elements[index] = value; }
		}
		int position = -1;

		public void Reset()
		{
			position = -1;
		}
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)elements).GetEnumerator();
        }
        public void Add(Element element)
        {
            var newArray = new Element[elements.Length + 1];    // Создание нового массива (на 1 больше старого).
            elements.CopyTo(newArray, 0);                       // Копирование старого массива в новый.
            newArray[newArray.Length - 1] = element;            // Помещение нового значения в конец массива.
            elements = newArray;                                // Замена старого массива на новый.
        }
            
        public Element FilterbyName(string Name)
        {
            if (((Element)(GetEnumerator().Current)).name == Name)
                return ((Element)(GetEnumerator().Current));
            else
            {
                throw new Exception("There is no such month");
            }
        }
        public Element FilterbyNumber(int Num)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                GetEnumerator().MoveNext();
                if (((Element)GetEnumerator().Current).number == Num)
                    return ((Element)(GetEnumerator().Current));
            }
            throw new Exception("There is no such month");
        }
        public Element[] FilterbyCountDays(int Num)
        {
            var collection = new MonthsCollection();
            if (((GetEnumerator().Current) as Element).countDays == Num)
            {
                collection.Add((Element)(GetEnumerator().Current));
            }
            return collection.elements;
        }
    }
}
