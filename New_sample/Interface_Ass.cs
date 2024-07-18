using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    public interface Iplayable
    {
        void Play();
    }
    public class VedioPlayer : Iplayable
    {
        public void Play()
        {
            Console.WriteLine("Playing Vedio....\n");
        }
    }
    public class MusicPlayer : Iplayable
    {
        public void Play()
        {
            Console.WriteLine("Playing music....");

        }
    }

    internal interface Interface_Ass
    {
        static void Main()
        {
            VedioPlayer v = new VedioPlayer();
            MusicPlayer m = new MusicPlayer();

            v.Play();
            m.Play();
        }
    }
}
