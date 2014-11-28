using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    class Player
    {
        public List<Pawn> Pawn = new List<Pawn>();
        public List<Queen> Queen = new List<Queen>();
        public List<Crusader> Crusader = new List<Crusader>();
        public List<King> King = new List<King>();
        public List<Tower> Tower = new List<Tower>();
        public List<Bishop> Bishop = new List<Bishop>();
        public string Color;

        public Player(string Color)
        {
            this.Color = Color;
            Pawn WP1 = new Pawn("W", new Position(0, 1));
            Pawn WP2 = new Pawn("W", new Position(1, 1));
            Pawn WP3 = new Pawn("W", new Position(2, 1));
            Pawn WP4 = new Pawn("W", new Position(3, 1));
            Pawn WP5 = new Pawn("W", new Position(4, 1));
            Pawn WP6 = new Pawn("W", new Position(5, 1));
            Pawn WP7 = new Pawn("W", new Position(6, 1));
            Pawn WP8 = new Pawn("W", new Position(7, 1));
            Pawn.Add(WP1);
            Pawn.Add(WP2);
            Pawn.Add(WP3);
            Pawn.Add(WP4);
            Pawn.Add(WP5);
            Pawn.Add(WP6);
            Pawn.Add(WP7);
            Pawn.Add(WP8);

            Pawn BP1 = new Pawn("B", new Position(0, 1));
            Pawn BP2 = new Pawn("B", new Position(1, 1));
            Pawn BP3 = new Pawn("B", new Position(2, 1));
            Pawn BP4 = new Pawn("B", new Position(3, 1));
            Pawn BP5 = new Pawn("B", new Position(4, 1));
            Pawn BP6 = new Pawn("B", new Position(5, 1));
            Pawn BP7 = new Pawn("B", new Position(6, 1));
            Pawn BP8 = new Pawn("B", new Position(7, 1));
            Pawn.Add(BP1);
            Pawn.Add(BP2);
            Pawn.Add(BP3);
            Pawn.Add(BP4);
            Pawn.Add(BP5);
            Pawn.Add(BP6);
            Pawn.Add(BP7);
            Pawn.Add(BP8);
        }

        public List<Pawn> GetPieces()
        {
            return Pawn;
        }
    }

}
    
        

