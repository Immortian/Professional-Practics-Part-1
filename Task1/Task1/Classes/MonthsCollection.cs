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
            while (true)
            {
                if (position < elements.Length - 1)
                {
                    position++;
                    yield return elements[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }
        public void Add(Element element)
        {
            if (elements == null)
                elements = new Element[1];

            if (elements[elements.Length - 1] == new Element("", 0, 0) || elements[elements.Length - 1] == null)
                elements[elements.Length - 1] = element;
            else
            {
                var newArray = new Element[elements.Length + 1];    // Создание нового массива (на 1 больше старого).
                elements.CopyTo(newArray, 0);                       // Копирование старого массива в новый.
                newArray[newArray.Length - 1] = element;            // Помещение нового значения в конец массива.
                elements = newArray;                                // Замена старого массива на новый.
            }
        }

        public Element FilterbyName(string Name)
        {
            foreach (var element in elements)
            {
                if (element.name == Name)
                    return element;
            }
            throw new Exception("There is no such month");
        }
        public Element FilterbyNumber(int Num)
        {
            foreach (var element in elements)
            {
                if (element.number == Num)
                    return element;
            }
            throw new Exception("There is no such month");
        }
        public Element[] FilterbyCountDays(int Num)
        {
            var collection = new MonthsCollection();
            foreach (var element in elements)
            {
                if (element.countDays == Num)
                    collection.Add(element);
            }
            return collection.elements;
        }
    }
}
