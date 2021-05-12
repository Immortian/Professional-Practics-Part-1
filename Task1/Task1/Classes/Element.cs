using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Task1._1
{
    public class Element
    {
		public string name { get; set; }
		public int number { get; set; }
		public int countDays { get; set; }

		public Element(string Name, int Number, int CountDays)
		{
			name = Name;
			number = Number;
			countDays = CountDays;
		}
	}
}
