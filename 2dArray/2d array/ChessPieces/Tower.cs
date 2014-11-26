using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    public class Tower : IChessPiece
    {
        public Position position;
        public Tower(string color, Position pos)
        {
            this.Color = color;
            position = pos;
        }

        public string Name()
        {
            string name = "T";
            return Color + name;
        }
       public string Color
        {
            get;
            set;
        }
        public void Move()
        {
            //DoStuff
        }
    }
}
