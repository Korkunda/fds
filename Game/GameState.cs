using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Script_Print.Characters.Player;

namespace Script_Print.Game
{
    public class GameState
    {
        public Player Player1 { get; set; }
        public int Turn { get; set; }

        public GameState()
        {
            Turn = 1;
            Player1 = PlayerCreator.CreateRandomStatsPlayerUserInput();
        }

        public void IncrementTurn() { Turn++; }
    }
}
