using System;
using subTask3.Classes;

namespace subTask3
{
    class Program
    {
        static Dictionary dick;
        static void Main(string[] args)
        {
            createWords();
            Console.WriteLine("Translete of word 'спинер': ");
            Console.WriteLine(dick.TranslateTo("Спинер", Dictionary.TranslateOption.Ukrain));
        }
        static void createWords()
        {
            Words[] arr;
            Words w1 = new Words("Абоба", "Абiба", "Abooba");
            Words w2 = new Words("Брух", "Брух", "Bruh");
            Words w3 = new Words("Спинер", "Як'ысь геiска хуiта", "spinner");
            arr = new Words[] { w1, w2, w3 };
            dick = new Dictionary(arr);
        }
    }
}
