using System;

namespace UberGame
{
    static class Die
    {
        private static Random rnd = new Random();

        public static int Throw1d6()
        {
            return rnd.Next(1, 7);
        }

        public static int[] Throw2d6()
        {
            return new int[] { rnd.Next(1, 7), rnd.Next(1, 7) };
        }

        public static int Throw1d20()
        {
            return rnd.Next(1, 21);
        }
    }
}