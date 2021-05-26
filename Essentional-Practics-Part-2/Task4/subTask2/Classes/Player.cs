using System;
using System.Collections.Generic;
using System.Text;

namespace subTask2.Classes
{
    interface IPlayable
    {
        void Play();
        void Pause(); 
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : IPlayable, IRecodable
    {
        public void Pause()
        {
            Console.WriteLine("---pause---");
        }

        public void Play()
        {
            Console.WriteLine("---play---");
        }

        public void Record()
        {
            Console.WriteLine("---recording---");
        }

        public void Stop()
        {
            Console.WriteLine("---stop---");
        }
    }
}
