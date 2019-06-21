using System;

namespace UberGame
{
    public class MusicBox
    {
        private int C1 = 265;
        private int D = 297;
        private int Eb = 315;
        private int E = 334;
        private int F = 354;
        private int Gb = 375;
        private int G = 397;


        public void PlayDramaticSound()
        {
            Console.Beep(Gb, 300);
            Console.Beep(Gb, 300);
            Console.Beep(Gb, 300);
            Console.Beep(Eb, 1200);

            Console.Beep(F, 300);
            Console.Beep(F, 300);
            Console.Beep(F, 300);
            Console.Beep(D, 1200);
        }

        public void IntroMusic()
        {
            Console.Beep(Eb, 500);
            Console.Beep(Gb, 500);
            Console.Beep(E, 500);
            Console.Beep(C1, 600);
        }

        public void BattleMusic()
        {
            Console.Beep(C1, 100);
            Console.Beep(G, 100);
        }
        
      
    }
}
