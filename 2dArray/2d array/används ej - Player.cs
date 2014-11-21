using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    class Player
    {
         public List<Peasant> Pawn = new List<Peasant>();
        public List<Queen> Queen = new List<Queen>();
        public List<Crusader> Crusader = new List<Crusader>();
        public List<King> King = new List<King>();
        public List<Tower> Tower = new List<Tower>();
        public List<Bishop> Bishop = new List<Bishop>();
        public string Color;

        public Player(string Color)
        {
            this.Color = Color;
            Peasant WP1 = new Peasant("W", new Position(1, 1));
            Peasant WP2 = new Peasant("W", new Position(2, 1));
            Peasant WP3 = new Peasant("W", new Position(3, 1));
            Peasant WP4 = new Peasant("W", new Position(4, 1));
            Peasant WP5 = new Peasant("W", new Position(5, 1));
            Peasant WP6 = new Peasant("W", new Position(6, 1));
            Peasant WP7 = new Peasant("W", new Position(7, 1));
            Peasant WP8 = new Peasant("W", new Position(8, 1));
            Pawn.Add(WP1);
            Pawn.Add(WP2);
            Pawn.Add(WP3);
            Pawn.Add(WP4);
            Pawn.Add(WP5);
            Pawn.Add(WP6);
            Pawn.Add(WP7);
            Pawn.Add(WP8);

        

            Peasant BP1 = new Peasant("B", new Position(1, 6));
            Peasant BP2 = new Peasant("B", new Position(2, 6));
            Peasant BP3 = new Peasant("B", new Position(3, 6));
            Peasant BP4 = new Peasant("B", new Position(4, 6));
            Peasant BP5 = new Peasant("B", new Position(5, 6));
            Peasant BP6 = new Peasant("B", new Position(6, 6));
            Peasant BP7 = new Peasant("B", new Position(7, 6));
            Peasant BP8 = new Peasant("B", new Position(8, 6));
            Pawn.Add(BP1);
            Pawn.Add(BP2);
            Pawn.Add(BP3);
            Pawn.Add(BP4);
            Pawn.Add(BP5);
            Pawn.Add(BP6);
            Pawn.Add(BP7);
            Pawn.Add(BP8);
        }

       public List<Peasant> GetPieces()
        {
            return Pawn;
        }
    }

}
    
        

