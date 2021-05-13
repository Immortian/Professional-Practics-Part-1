using System;
using System.Collections.Generic;
using System.Text;

namespace subTask3.Classes
{
    class Word
    {
        public Word(string ru, string uk, string en)
        {
            ru_word = ru;
            uk_word = uk;
            en_word = en;
        }

        public string ru_word { get; set; }
        public string uk_word { get; set; }
        public string en_word { get; set; }
    }
}
