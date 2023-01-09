using Script_Print.Characters;
using Script_Print.Game.Events;
using Script_Print.Game.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print.Game
{
    public class Exploration
    {
        public Character Player;
        public Exploration(Character player)
        {
            Player = player;
        }

        public void Start()
        {
            MainLoop();
        }
        public void MainLoop()
        {
            int input = UI.MinMaxRangeInput("Choose your luck:\n1. Easy Exploration\n 2. Normal Adventure\n 3. TrollDespair\n", 1, 3);

            switch (input)
            {
                case 1:
                    Easy(90);
                    break;
                case 2:
                    Normal(70);
                    break;
                case 3:
                    TrollDespair(30);
                    break;
                default:
                    break;
            }
        }
        
        public void Easy(int accuracy)
        {
            int acc = accuracy;

            bool success = RandomGen.AccuracyCalc(acc);

            if (success)
            {

            }
            else
            {

            }

        }

        public void Normal(int accuracy)
        {
            int acc = accuracy;

            bool success = RandomGen.AccuracyCalc(acc);
        }

        public void TrollDespair(int accuracy)
        {
            int acc = accuracy;

            bool success = RandomGen.AccuracyCalc(acc);
        }
        
    }
}
