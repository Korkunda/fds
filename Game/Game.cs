using Script_Print.Characters;
using Script_Print.Characters.Mob;
using Script_Print.Game.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print.Game
{
    public class Game
    {
        GameState GState { get; set; }
        public Game()
        {
            GState = new GameState();
        }

        public void Start()
        {
            GState.isRunning = true;
            MainLoop();
        }

        public void MainLoop()
        {
            while (GState.isRunning)
            {
                GState.DisplayTurn();
                int input = UI.MinMaxRangeInput("Choose your turn:\n\n 1. Battle\n 2. Explore",1, 4);

                switch(input)
                {
                    case 1:
                        Battle();
                        break;
                    case 2:
                        Explore();
                        break;
                    case 3:
                        GState.Player1.DisplayInfo();
                        break;
                    default:
                        break;
                }
            }
        }

        public void Battle()
        {
            Mob randomMob = MobFactory.CreateRandomMob();

            BattleEngine bEng = new BattleEngine(GState.Player1, randomMob);

            bEng.StartBattle();

            GState.Player1 = bEng.Player1;

            if(bEng.Player1.Stats.Health <= 0)
            {
                Console.WriteLine("Game over, trollDespair...");
                GState.isRunning = false;
            }
            GState.Player1.Stats.ResetStats();
            GState.IncrementTurn();

        }

        public void Explore()
        {
            
        }
    }
}
