using Script_Print.Characters.Mob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Script_Print.Characters.Moves;
using System.Collections;
using Script_Print.Utils;
using Script_Print.Game.Generators;

namespace Script_Print.Characters.Mob
{
    public static class MobFactory
    {
        public static Mob FindMob(string mobName)
        {
            string jsonString = File.ReadAllText("C:/Users/JaredP/source/repos/Script Print/Assets/Mobs/Mobs.json");

            JObject json = JObject.Parse(jsonString);
            
            bool mobIsFound = false;
            int i = 0;


            foreach (JToken mob in json["Mobs"])
            {
                string name = mob["Name"].ToString();
                if (name.ToLower() == mobName.ToLower())
                {
                    mobIsFound = true;
                    break;
                }
                i++;
            }

            if (mobIsFound)
            {
                JToken foundMob = json["Mobs"][i];

                //set stats

                int health = Convert.ToInt32(foundMob["Stats"]["Health"]);
                int attack = Convert.ToInt32(foundMob["Stats"]["Attack"]);
                int speed = Convert.ToInt32(foundMob["Stats"]["Speed"]);

                Stats stats = new Stats(health, attack, speed);

                //set moveset

                List<int> moves = new List<int>();

                foreach (var move in foundMob["Moveset"])
                {
                    if(move != null)
                    {
                        moves.Add(Convert.ToInt32(move));
                    }
                }

                Moveset moveset = MoveFactory.GetMoveset(moves);

                Mob mob = new Mob(mobName, stats, moveset);
                return mob;
            }
            else
            {
                return new Mob("Unknown", new Stats(1, 1, 1), new Moveset());
            }


        }
        public static Mob CreateMob(string mobName)
        {
            Mob mob = FindMob(mobName);
            return mob;
        }

        public static Mob CreateRandomMob()
        {
            string jsonString = File.ReadAllText("C:/Users/JaredP/source/repos/Script Print/Assets/Mobs/Mobs.json");

            JObject json = JObject.Parse(jsonString);

            JToken MobList = json["Mobs"];
            
            var count = MobList.Count();

            int rnd = RandomGen.Custom(0, count - 1);


            string mobName = Convert.ToString(json["Mobs"][rnd]["Name"]);

            Mob randomMob = CreateMob(mobName);

            return randomMob;

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