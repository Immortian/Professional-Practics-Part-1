using System;
using System.Collections.Generic;
using System.Text;

namespace subTask3.Classes
{
    class Dictionary
    {
        Words[] dictionary;
        public Dictionary(Words[] dick)
        {
            dictionary = dick;
        }
        public Dictionary()
        {
            dictionary = new Words[1];
        }

        public void Add(Words Word)
        {
            if (dictionary == null)
                dictionary = new Words[1];

            if (dictionary[^1] == new Words("", "", "") || dictionary[^1] == null)
                dictionary[^1] = Word;
            else
            {
                var newArray = new Words[dictionary.Length + 1];
                dictionary.CopyTo(newArray, 0);
                newArray[^1] = Word;
                dictionary = newArray;
            }
        }

        public Words SearchFor(string str)
        {
            foreach(var Word in dictionary)
            {
                if (Word.ru_word == str)
                    return Word;
                if (Word.uk_word == str)
                    return Word;
                if (Word.en_word == str)
                    return Word;
            }
            return null;
        }

        public enum TranslateOption { Russian, Ukrain, English};

        public string TranslateTo(string str, TranslateOption to)
        {
            Words Word = SearchFor(str);
            if(to == TranslateOption.English)
            {
                return Word.en_word;
            }
            else if (to == TranslateOption.Russian)
            {
                return Word.ru_word;
            }
            else
            {
                return Word.uk_word;
            }
        }
    }
}
