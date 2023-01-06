using Script_Print.Characters.Mob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Script_Print.Characters.Moves;

namespace Script_Print.Characters.Mob
{
    public static class MobFactory
    {
        public static Mob FindMob()
        {
            string jsonString = File.ReadAllText("C:/Users/JaredP/source/repos/Script Print/Assets/Mobs/Mobs.json");

            JObject json = JObject.Parse(jsonString);

            Mob creature = new Mob(name, stats, moveset);

            Stats mobStats = new Stats(int health, int attack, int speed);     

            foreach(JToken stats in json["Stats"])
            {
                int Health = Convert.ToInt32(stats["Health"]);
                int Attack = Convert.ToInt32(stats["Attack"]);
                int Speed = Convert.ToInt32(stats["Speed"]);


                mobStats(Stats(Health, Attack, Speed));
            }

            foreach(JToken mob in json["Mobs"])
            {
                string Name = mob["Name"].ToString();
            }

            return mobStats;
        }
        public static Mob CreateMob(string monster)
        {
            Mob Monster = new Mob();
            Monster.Name = monster;
            Monster.Stats = ;

        }
    }

}


//public static Mob CreateMob(string type)
//{
//    switch (type.ToLower())
//    {
//        case "jelly":



//            //var jelly = new Jelly("Jelly", new Stats(5, 2, 1));
//            var jelly = GetMob(type);
//            return jelly;
//        case "spider":

//        default:
//            return new Mob(new Stats(5, 3, 3));
//    }
//}
//public static Mob GetMob(string type)
//{
//    //read json
//    //loop through mob json array and get the right one
//    //create new mob with json config
//    //return mob
//}