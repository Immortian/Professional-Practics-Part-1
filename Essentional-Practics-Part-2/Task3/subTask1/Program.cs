using System;
using subTask1.Classes;

namespace subTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom cls = new ClassRoom(
                new ExelentPupil(1, 10, 10, 10, 10),
                new ExelentPupil(2, 10, 9, 10, 9),
                new BadPupil(3, 4, 3, 5, 4),
                new GoodPupil(4, 7, 6, 7, 9));

            cls.SomeWordsAboutClass();
        }
    }
}
