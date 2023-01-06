using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print.Game.Generators
{
    public static class RandomGen
    {
        public static int RollDice20()
        {
            Random rnd = new Random();

            return rnd.Next(0, 21);
        }

        public static int CoinToss()
        {
            Random rnd = new Random();

            return rnd.Next(0, 3);
        }
        public static int Custom(int min, int max)
        {
            Random rnd = new Random();

            return rnd.Next(min, max+1);
        }
    }
}
