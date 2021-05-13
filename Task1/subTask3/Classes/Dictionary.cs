using System;
using System.Collections.Generic;
using System.Text;

namespace subTask3.Classes
{
    class Dictionary
    {
        Word[] dictionary;
        public Dictionary(Word[] dick)
        {
            dictionary = dick;
        }
        public Dictionary()
        {
            dictionary = new Word[1];
        }

        public void Add(Word Word)
        {
            if (dictionary == null)
                dictionary = new Word[1];

            if (dictionary[^1] == new Word("", "", "") || dictionary[^1] == null)
                dictionary[^1] = Word;
            else
            {
                var newArray = new Word[dictionary.Length + 1];
                dictionary.CopyTo(newArray, 0);
                newArray[^1] = Word;
                dictionary = newArray;
            }
        }

        public Word SearchFor(string str)
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
            Word Word = SearchFor(str);
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
