using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Print.Characters.Moves
{
    public class Moveset 
    {
        public List<Move> Moves { get; set; }

        public Moveset()
        {
            Moves = new List<Move>();
        }

        public Moveset(List<Move> moves)
        {
            Moves = moves;
        }
        public Moveset(Move move1)
        {
            Moves.Add(move1);

        }
        public Moveset(Move move1, Move move2)
        {
            Moves.Add(move1);
            Moves.Add(move2);

        }
        public Moveset(Move move1, Move move2, Move move3)
        {
            Moves.Add(move1);
            Moves.Add(move2);
            Moves.Add(move3);
        }

        public Moveset(Move move1, Move move2, Move move3, Move move4)
        {
            Moves.Add(move1);
            Moves.Add(move2);
            Moves.Add(move3);
            Moves.Add(move4);
        }

        public void AddMove(Move move)
        {
            if(Moves.Count <= 4)
            {
                Moves.Add(move);
            }
        }
        public void SetMoves (List<Move> moves)
        {
            Moves = moves;
        }
    }
}
