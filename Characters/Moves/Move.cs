using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print.Characters.Moves
{
    public class Move
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Damage { get; set; }

        public int Accuracy { get; set; }

        public Move(int id, string name, string type, int damage, int accuracy)
        {
            Id = id;                
            Name = name;
            Damage = damage;
            Accuracy = accuracy;
            Type = type;
        }
    }
}
