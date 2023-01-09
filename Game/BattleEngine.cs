using Script_Print.Characters;
using Script_Print.Characters.Mob;
using Script_Print.Characters.Moves;
using Script_Print.Characters.Player;
using Script_Print.Game.BattleEngineComponents;
using Script_Print.Game.Events;
using Script_Print.Game.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print.Game
{
    public class BattleEngine
    {
        public Character Player1 { get; set; }
        Character Player2 { get; set; }
        IMoveSelector P1MoveSelector { get; set; }
        IMoveSelector P2MoveSelector { get; set; }

        bool isBattling { get; set; }

        public BattleEngine(Character player1, Character player2)
        {
            Player1 = player1;
            Player2 = player2;
            if (player1 is Player) 
            {
                P1MoveSelector = new PlayerMoveSelector(player1.Moveset);
                P2MoveSelector = new CPUMoveSelector(player2.Moveset);

            }
            else 
            {
                P1MoveSelector = new CPUMoveSelector(player1.Moveset);
                P2MoveSelector = new CPUMoveSelector(player2.Moveset);
            }
            isBattling = false;
            
        }

        public void MainLoop()
        {
            isBattling= true;
            while (isBattling)
            {

                Player1.BattleInfoDisplay();
                Player2.BattleInfoDisplay();

                //reset move selector
                P1MoveSelector.SetMoves(Player1.Moveset);
                P2MoveSelector.SetMoves(Player2.Moveset);

                Move P1Move = P1MoveSelector.SelectMove();
                Move P2Move = P2MoveSelector.SelectMove();


                switch(StatChecker.WhoIsFaster(Player1.Stats, Player2.Stats))
                {
                    case 1:
                        ExecuteMoves(Player1, Player2, P1Move, P2Move);
                        break;
                    case 2:
                        ExecuteMoves(Player2, Player1, P2Move, P1Move);
                        break;
                    default:
                        int coinToss = RandomGen.CoinToss();
                        if(coinToss > 0)
                        {
                            ExecuteMoves(Player1, Player2, P1Move, P2Move);
                        }
                        else
                        {
                            ExecuteMoves(Player2, Player1, P2Move, P1Move);
                        }
                        break;

                }

            }
        }

        public void StartBattle()
        {
            UI.MobAppears(Player2.Name);
            MainLoop();
        }

        public void ExecuteMove(Character attacker, Character defender, Move moveUsed)
        {

            DamageCalc(attacker, defender, moveUsed);

        }

        public void DamageCalc(Character attacker, Character defender, Move moveUsed)
        {
            UI.UsedMoveMsg(attacker.Name, moveUsed.Name);

            bool moveHit = RandomGen.AccuracyCalc(moveUsed.Accuracy);

            if (!moveHit)
            {
                Console.WriteLine("But it missed!");
                return;
            }
            int dmg;
            switch (moveUsed.Type.ToLower())
            {
                case "heal":
                    dmg = moveUsed.Damage;
                    attacker.Stats.Heal(moveUsed.Damage);
                    UI.HealedDamage(attacker.Name,moveUsed.Damage);
                    break;
                case "attack":
                    dmg = moveUsed.Damage * attacker.Stats.Attack;
                    defender.Stats.TakeDamage(dmg);
                    UI.TookDamage(defender.Name, dmg);
                    break;
                default:
                    dmg = moveUsed.Damage * attacker.Stats.Attack;
                    defender.Stats.TakeDamage(dmg);
                    UI.TookDamage(defender.Name, dmg);
                    break;
            }
        }

        public void BattleOver(string winner)
        {
            Console.WriteLine(winner + " won!");
            isBattling = false;
        }

        public void ExecuteMoves(Character attacker, Character defender, Move attackerMove, Move defenderMove)
        {
            ExecuteMove(attacker, defender, attackerMove);

            if (CheckDeath(attacker, defender)) {
                return;
            }

            ExecuteMove(defender, attacker, defenderMove);

            CheckDeath(defender, attacker);
        }
        bool IsDead(Character player)
        {
            bool isDead = false;
            if (player.Stats.Health <= 0)
            {
                isDead= true;
            }
            return isDead;
        }

        bool CheckDeath(Character p1,Character p2)
        {
            if (IsDead(p1))
            {
                Console.WriteLine($"{p1.Name} died miserably.");
                BattleOver(p2.Name);
                return true;
            }
            if (IsDead(p2))
            {
                Console.WriteLine($"{p2.Name} died miserably.");
                BattleOver(p1.Name);
                return true;
            }
            return false;

        }
    }
}
