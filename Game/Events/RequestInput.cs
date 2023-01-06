using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print.Game.Events
{
    public static class RequestInput
    {
        public static string BasicInput(string msg)
        {
            Console.WriteLine(msg);
            string input;

            while (true)
            {
                input = Console.ReadLine();

                if(input != null && input.Length < 20)
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

                if (input != null && (Convert.ToInt32(input) >= min && Convert.ToInt32(input) <= max))
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
    }
}
