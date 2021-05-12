using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Classes
{
    class Human
    {
        public Human(string name, int birthyear)
        {
            Name = name;
            Birthyear = birthyear;
        }
        public string Name;
        public int Birthyear;
        public Human Parent;
        public Human Child;
    }
}
