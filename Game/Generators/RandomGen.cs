using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print.Game.Generators
{
    public static class RandomGen
    {
        public static int SetPlayerStats()
        {
            Random rnd = new Random();

            return rnd.Next(4, 31);
        }

        public static int CoinToss()
        {
            Random rnd = new Random();

            return rnd.Next(1, 3);
        }

        public static bool AccuracyCalc(int accuracy)
        {
            bool moveHit = false;

            Random rnd = new Random();
            int rndNo = rnd.Next(1, 101);

            if(accuracy >= rndNo)
            {
                moveHit = true;
            }

            return moveHit;

        }
        public static int Custom(int min, int max)
        {
            Random rnd = new Random();

            return rnd.Next(min, max + 1);
        }
    }
}
