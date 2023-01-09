using Script_Print.Characters.Moves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print.Characters
{
    public abstract class Character
    {
        private string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public Stats Stats { get; set; }

        public Moveset Moveset;

        public Character(Stats stats)
        {
            Stats = stats;
            Name = "Unnamed mob";
        }
        public Character(string name, Stats stats, Moveset moves)
        {
            Name = name;
            Stats = stats;
            Moveset = moves;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\nName: {Name}\n-----Stats-----\nHealth: {Stats.Health}\nAttack: {Stats.Attack}\nSpeed: {Stats.Speed}"+
            "\n\n-----Moveset-----");
            foreach(var item in Moveset.Moves)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
        }

        public abstract void BattleInfoDisplay();

    }
}
