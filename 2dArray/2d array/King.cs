using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    public class King : IChessPiece
    {
        public string Name()
        {
            string name = "K";
            return Color() + name;
        }
        public string Color()
        {
            string color = "B";
            return color;
        }
        public void Move()
        {
            //DoStuff
        }
    }
}
