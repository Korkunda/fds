using Script_Print.Characters;
using Script_Print.Characters.Moves;
using Script_Print.Characters.Player;
using Script_Print.Game.Events;
using Script_Print.Game.Generators;
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
            
            int health = RandomGen.RollDice20();
            int attack = RandomGen.RollDice20();
            int speed = RandomGen.RollDice20();

            return new Player(name,new Stats(health,attack,speed),new Moveset(new Move(1,"name","type",1,2)));

        }

        public static Player CreateRandomStatsPlayerUserInput()
        {
            var input = RequestInput.BasicInput("What is the name of your character?");
            return CreateRandomStatsPlayer(input);
        }
    }
}
