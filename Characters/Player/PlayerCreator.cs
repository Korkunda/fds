using Newtonsoft.Json.Linq;
using Script_Print.Characters;
using Script_Print.Characters.Mob;
using Script_Print.Characters.Moves;
using Script_Print.Characters.Player;
using Script_Print.Game.Events;
using Script_Print.Game.Generators;
using Script_Print.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print
{
    public static class PlayerCreator
    {
        public static Player CreateRandomStatsPlayer(string name)
        {

            int health = RandomGen.Custom(100, 201);
            int attack = RandomGen.SetPlayerStats();
            int speed = RandomGen.SetPlayerStats();

            Moveset moves = SetMoves(new List<int> { 1, 2, 3,4 });


            return new Player(name, new Stats(health, attack, speed), moves);

        }

        public static Player CreateRandomStatsPlayerUserInput()
        {
            var input = UI.BasicInput("What is the name of your character?");

            return CreateRandomStatsPlayer(input);
        }

        public static Moveset SetMoves(List<int> moves)
        {
            return MoveFactory.GetMoveset(moves);
        }
    }
}
