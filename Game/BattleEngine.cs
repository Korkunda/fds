using Script_Print.Characters;
using Script_Print.Characters.Mob;
using Script_Print.Characters.Moves;
using Script_Print.Characters.Player;
using Script_Print.Game.BattleEngineComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print.Game
{
    public class BattleEngine
    {
        Character Player1 { get; set; }
        Character Player2 { get; set; }
        IMoveSelector P1MoveSelector { get; set; }
        IMoveSelector P2MoveSelector { get; set; }

        public BattleEngine(Character player1, Character player2)
        {
            Player1 = player1;
            Player2 = player2;
            if (player1 is Player) 
            {
                P1MoveSelector = new PlayerMoveSelector(player1.Moves);

            }
            else 
            {
                P1MoveSelector = new CPUMoveSelector(player1.Moves);
            }


            
        }

        public void MainLoop()
        {
            while (true)
            {
                Move P1SelectedMove = P1MoveSelector.SelectMove();
                Move P2SelectedMove = P2MoveSelector.SelectMove();

                switch(StatChecker.WhoIsFaster(Player1.Stats, Player2.Stats))
                {
                    case 1:
                        ExecuteMove(Player1, Player2);
                        ExecuteMove(Player2, Player1);
                        break;
                    case 2:
                        ExecuteMove(Player2, Player1);
                        ExecuteMove(Player1, Player2);
                        break;
                    default:
                        break;

                }

            }
        }

        public void StartBattle()
        {
            MainLoop();
        }

        public void ExecuteMove(Character firstMover, Character secondMover)
        {

        }
    }
}
