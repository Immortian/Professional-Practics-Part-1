using System;
using subTask3.Classes;

namespace subTask3
{
    class Program
    {
        static Dictionary dict;
        static void Main(string[] args)
        {
            createWords();
            Console.WriteLine("Translete of word 'спинер': ");
            Console.WriteLine(dict.TranslateTo("Спинер", Dictionary.TranslateOption.Ukrain));
        }
        static void createWords()
        {
            Word[] arr;
            Word w1 = new Word("Абоба", "Абiба", "Abooba");
            Word w2 = new Word("Брух", "Брух", "Bruh");
            Word w3 = new Word("Спинер", "Спiнёр", "spinner");
            arr = new Word[] { w1, w2, w3 };
            dict = new Dictionary(arr);
        }
    }
}
