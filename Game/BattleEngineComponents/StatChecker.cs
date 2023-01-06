using Script_Print.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print.Game.BattleEngineComponents
{
    public static class StatChecker
    {
        public static int WhoIsFaster(Stats player1Stats, Stats player2Stats)
        {
            if(player1Stats.Speed == player2Stats.Speed)
            {
                return 0;
            } 
            else if(player1Stats.Speed > player2Stats.Speed)
            {
                return 1;
            }
            else if (player1Stats.Speed < player2Stats.Speed)
            {
                return 2;
            }
            return 0;


        }
    }
}
