using System;
using System.Collections.Generic;
using System.Text;

namespace subTask1.Classes
{
    class ClassRoom
    {
        Pupil[] arr;
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            arr = new Pupil[] { p1, p2, p3, p4 };
        }
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            arr = new Pupil[] { p1, p2, p3 };
        }
        public ClassRoom(Pupil p1, Pupil p2)
        {
            arr = new Pupil[] { p1, p2 };
        }

        public void SomeWordsAboutPupil(int i)
        {
            foreach(var pup in arr)
            {
                if (pup.num == i)
                {
                    pup.Study();
                    pup.Read();
                    pup.Write();
                    pup.Relax();
                }
            }
        }
        public void SomeWordsAboutClass()
        {
            foreach (var pup in arr)
            {
                pup.Study();
                pup.Read();
                pup.Write();
                pup.Relax();
                Console.WriteLine();
            }

        }
    }

    public class Pupil
    {
        public Pupil(int Num)
        {
            num = Num;        
        }
        public int num { get; set; }

        public virtual void Study()
        {
            Console.WriteLine($"Pupil {num}");
        }
        public virtual void Read()
        {
            Console.WriteLine($"Pupil {num}");
        }
        public virtual void Write()
        {
            Console.WriteLine($"Pupil {num}");
        }
        public virtual void Relax()
        {
            Console.WriteLine($"Pupil {num}");
        }
    }
    class ExelentPupil : Pupil
    {
        int Num;
        int st, rd, wr, rl;
        public ExelentPupil(int num, int ST, int RD, int WR, int RL) : base(num)
        {
            Num = num;
            st = ST;
            rd = RD;
            wr = WR;
            rl = RL;
        }
        public override void Study()
        {
            Console.WriteLine($"Pupil {Num} has grade of study: {st}. Perfecto!");
        }
        public override void Read()
        {
            Console.WriteLine($"Pupil {Num} has grade of reading: {rd}. Perfecto!");
        }
        public override void Write()
        {
            Console.WriteLine($"Pupil {Num} has grade of writing: {wr}. Perfecto!");
        }
        public override void Relax()
        {
            Console.WriteLine($"Pupil {Num} has grade of relax: {rl}. Perfecto!");
        }
    }
    class GoodPupil : Pupil
    {
        int Num;
        int st, rd, wr, rl;
        public GoodPupil(int num, int ST, int RD, int WR, int RL) : base(num)
        {
            Num = num;
            st = ST;
            rd = RD;
            wr = WR;
            rl = RL;
        }
        public override void Study()
        {
            Console.WriteLine($"Pupil {Num} has grade of study: {st}. Good!");
        }
        public override void Read()
        {
            Console.WriteLine($"Pupil {Num} has grade of reading: {rd}. Good!");
        }
        public override void Write()
        {
            Console.WriteLine($"Pupil {Num} has grade of writing: {wr}. Good!");
        }
        public override void Relax()
        {
            Console.WriteLine($"Pupil {Num} has grade of relax: {rl}. Good!");
        }
    }
    class BadPupil : Pupil
    {
        int Num;
        int st, rd, wr, rl;
        public BadPupil(int num, int ST, int RD, int WR, int RL) : base(num)
        {
            Num = num;
            st = ST;
            rd = RD;
            wr = WR;
            rl = RL;
        }
        public override void Study()
        {
            Console.WriteLine($"Pupil {Num} has grade of study: {st}. Try better!");
        }
        public override void Read()
        {
            Console.WriteLine($"Pupil {Num} has grade of reading: {rd}. Try better!");
        }
        public override void Write()
        {
            Console.WriteLine($"Pupil {Num} has grade of writing: {wr}. Try better!");
        }
        public override void Relax()
        {
            Console.WriteLine($"Pupil {Num} has grade of relax: {rl}. Try better!");
        }
    }
}
