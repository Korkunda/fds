using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print.Characters
{
    public class Stats
    {
        public int BaseHealth { get; set; }

        public int BaseAttack { get; set; }

        public int BaseSpeed { get; set; }

        public int Health { get; set; }

        public int Attack { get; set; }

        public int Speed { get; set; }

        public Stats(int health, int attack, int speed)
        {
            Health = health;
            Attack = attack;
            Speed = speed;
            BaseHealth = health;
            BaseAttack = attack;
            BaseSpeed = speed;

        }

        public void TakeDamage(int dmg)
        {
            Health -= dmg;
        }

        public void Heal(int heal)
        {
            Health += heal;
        }
    }
}
