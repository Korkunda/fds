using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;
using Script_Print.Characters.Mob;
using Newtonsoft.Json;
using Script_Print.Characters.Moves;

namespace Script_Print.Utils
{
    public static class MoveFactory
    {

        public static Moveset GetMoveset(int[] moveIds)
        {
            
            Moveset moveset = new Moveset();
            List<Move> moves = GetMoveList();

            foreach(int id in moveIds)
            {
                Move foundMove = moves.FirstOrDefault(m => m.Id == id);
                if (foundMove != null)
                {
                    moveset.AddMove(foundMove);
                }
            }

            return moveset;
        }

        public static List<Move> GetMoveList()
        {
            List<Move> moveList = new List<Move>();

            string jsonString = File.ReadAllText("C:/Users/JaredP/source/repos/Script Print/Assets/Moves/Moves.json");

            JObject json = JObject.Parse(jsonString);

            foreach(JToken move in json["Moves"])
            {
                int Id = Convert.ToInt32(move["Id"]);
                string Name = move["Name"].ToString();
                string Type = move["Type"].ToString();
                int Damage = Convert.ToInt32(move["Damage"]);
                int Accuracy = Convert.ToInt32(move["Accuracy"]);


                moveList.Add(new Move(Id, Name, Type, Damage, Accuracy));
            }



            return moveList;
        }
    }
}
