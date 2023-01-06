using Script_Print.Characters.Moves;
using Script_Print.Game.Events;
using Script_Print.Game.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print.Game.BattleEngineComponents
{
    public class PlayerMoveSelector : IMoveSelector
    {
        public Moveset PlayerMoveSet { get; set; }

        public PlayerMoveSelector(Moveset playerMoveset)
        {
            PlayerMoveSet = playerMoveset;

        }

        public Move SelectMove()
        {
            Console.WriteLine("Select move number (1-4):");
            for (int i = 0; i < 0; i++)
            {
                Console.WriteLine($"{i} {PlayerMoveSet.Moves[i]}");
            }
            int input = RequestInput.MinMaxRangeInput("", 1, 4);
            return PlayerMoveSet.Moves.ElementAt(input - 1);
        }
    }
}
