using System;
using subTask2.Classes;

namespace subTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            p.Record();
            p.Stop();
            p.Play();
            p.Pause();
        }
    }
}
