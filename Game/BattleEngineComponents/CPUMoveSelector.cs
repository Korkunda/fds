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
    public class CPUMoveSelector : IMoveSelector
    {
        public Moveset PlayerMoveSet { get; set; }

        public CPUMoveSelector(Moveset playerMoveset)
        {
            PlayerMoveSet = playerMoveset;

        }


        public Move SelectMove()
        {

            return PlayerMoveSet.Moves.ElementAt((RandomGen.Custom(0, PlayerMoveSet.Moves.Count-1)));
        }
        public void SetMoves(Moveset playerMoveset)
        {
            PlayerMoveSet = playerMoveset;

        }

    }
}
