using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2d_array;

namespace _2d_array
{
    public class Pawn : IChessPiece
    {
        public Position position;
        public Pawn(string color, int x, int y)
        {
            this.Color = color;
            
        }
        public string Name()
        {
            string name = "bajs";
            return Color + name;
        }
        public string Color
        {
            get;
            set;
        }

        public void Move()
        {
            
            

        }

        public void Draw()
        {
            //int startX = Position.X;
            //int startY = Position.Y;

            //Console.SetCursorPosition(startX, startY);
        }
    }
}

