using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    class Player
    {
        public List<Peasant> Piece = new List<Peasant>();
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
            Piece.Add(WP1);
            Piece.Add(WP2);
            Piece.Add(WP3);
            Piece.Add(WP4);
            Piece.Add(WP5);
            Piece.Add(WP6);
            Piece.Add(WP7);
            Piece.Add(WP8);
            Peasant BP1 = new Peasant("B", new Position(1, 6));
            Peasant BP2 = new Peasant("B", new Position(2, 6));
            Peasant BP3 = new Peasant("B", new Position(3, 6));
            Peasant BP4 = new Peasant("B", new Position(4, 6));
            Peasant BP5 = new Peasant("B", new Position(5, 6));
            Peasant BP6 = new Peasant("B", new Position(6, 6));
            Peasant BP7 = new Peasant("B", new Position(7, 6));
            Peasant BP8 = new Peasant("B", new Position(8, 6));
            Piece.Add(BP1);
            Piece.Add(BP2);
            Piece.Add(BP3);
            Piece.Add(BP4);
            Piece.Add(BP5);
            Piece.Add(BP6);
            Piece.Add(BP7);
            Piece.Add(BP8);
        }

        public List<Peasant> GetPieces()
        {
            return Piece;
        }
    }
}
