using Script_Print.Characters.Moves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print.Characters
{
    public class Character
    {
        private string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public Stats Stats { get; set; }

        public Moveset Moves;

        public Character(Stats stats)
        {
            Stats = stats;
            Name = "Unnamed mob";
        }
        public Character(string name, Stats stats, Moveset moves)
        {
            Name = name;
            Stats = stats;
            Moves = moves;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}; Id: {Id}\n-----Stats-----\nHealth: {Stats.Health}\nAttack: {Stats.Attack}\nSpeed: {Stats.Speed}");
        }

    }
}
