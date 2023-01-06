using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Script_Print.Characters.Moves;

namespace Script_Print.Characters.Mob
{
    public class Mob : Character
    {
        public Mob(Stats stats) : base(stats)
        {
        }

        public Mob(string name, Stats stats, Moveset moves) : base(name, stats, moves)
        {

        }
    }
}
