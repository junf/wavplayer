using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace wavplayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = args.Length;
            if (n < 1)
            {
                Console.WriteLine("Usage: wavplayer wavfile");
            }
            else
            {
                SoundPlayer wavePlayer = new SoundPlayer(args[0]);
                wavePlayer.PlaySync();
            }
        }
    }
}
