using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print.Game.Events
{
    public static class UI
    {
        public static string BasicInput(string msg)
        {
            string input;
            while (true)
            {
                Console.WriteLine(msg);
                input = Console.ReadLine();

                if(input.Trim() != "" && input.Length < 20)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

            return input;
        }
        public static int MinMaxRangeInput(string msg,int min,int max)
        {
            Console.WriteLine(msg);
            string input;

            while (true)
            {
                input = Console.ReadLine();

                if (input.Trim() != "" && (Convert.ToInt32(input) >= min && Convert.ToInt32(input) <= max))
                {
                    break;  
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

            return (Convert.ToInt32(input));
        }

        public static void UsedMoveMsg(string charName, string moveName)
        {
            Console.WriteLine($"{charName} used {moveName}!");
        }

        public static void TookDamage(string charName, int damage)
        {
            Console.WriteLine($"{charName} took {damage} damage!");
        }

        public static void HealedDamage(string charName, int damage)
        {
            Console.WriteLine($"{charName} healed {damage} points!");
        }

        public static void MobAppears(string charName)
        {
            Console.WriteLine($"A {charName} appears!");
        }

        public static void Clear()
        {
            Console.Clear();
        }
    }
}
