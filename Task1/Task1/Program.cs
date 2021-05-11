using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Task1._1;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new MonthsCollection(GenerateMonths());
            Console.WriteLine(collection.FilterbyNumber(1));
            foreach (var mon in collection.FilterbyCountDays(30))
                Console.WriteLine(string.Join(" ", mon.name, mon.number, mon.countDays));
        }
        private static Element[] GenerateMonths()
        {
            const int firstMonthNum = 1;
            const int firstDayNum = 1;
            int year = DateTime.Now.Year;

            DateTime dateTime = new DateTime((int)year, firstMonthNum, firstDayNum);
            Element[] months = new Element[12];
            do
            {
                int daysInMonth = DateTime.DaysInMonth((int)year, dateTime.Month);
                months[dateTime.Month - 1] = new Element(dateTime.ToString("MMMM"), dateTime.Month, daysInMonth);
                dateTime = dateTime.AddMonths(1);
            } while (dateTime.Year == (int)year);

            return months;
        }
    }
}
