using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Script_Print.Characters.Moves;

namespace Script_Print.Characters.Player
{
    public class Player : Character
    {
        public Player(string name, Stats stats, Moveset moves) : base(name, stats, moves)
        {

        }
            public override void BattleInfoDisplay()
        {
            DisplayInfo();
        }
    }
}
