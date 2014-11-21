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
            Peasant P1 = new Peasant("W", new Position(1, 1));
            Peasant P2 = new Peasant("W", new Position(2, 1));
            Peasant P3 = new Peasant("W", new Position(3, 1));
            Peasant P4 = new Peasant("W", new Position(4, 1));
            Peasant P5 = new Peasant("W", new Position(5, 1));
            Peasant P6 = new Peasant("W", new Position(6, 1));
            Peasant P7 = new Peasant("W", new Position(7, 1));
            Peasant P8 = new Peasant("W", new Position(8, 1));
            Piece.Add(P1);
            Piece.Add(P2);
            Piece.Add(P3);
            Piece.Add(P4);
            Piece.Add(P5);
            Piece.Add(P6);
            Piece.Add(P7);
            Piece.Add(P8);
        }

        public List<Peasant> GetPieces()
        {
            return Piece;
        }
    }
}
