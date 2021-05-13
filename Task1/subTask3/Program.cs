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
            Word[] arr;
            Word w1 = new Word("Абоба", "Абiба", "Abooba");
            Word w2 = new Word("Брух", "Брух", "Bruh");
            Word w3 = new Word("Спинер", "Як'ысь геiска хуiта", "spinner");
            arr = new Word[] { w1, w2, w3 };
            dick = new Dictionary(arr);
        }
    }
}
