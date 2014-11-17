using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    public class Crusader : IChessPiece
    {
          public string Name="C";
        public string Color;
        public Position position;
 
        public Crusader(string Color, Position pos)
        {
            this.Color = Color;
            position = pos;
        }

        //public string Name()
        //{
        //    string name = "C";
        //    return Color() + name;
        //}
        //public string Color()
        //{
        //    string color = "B";
        //    return color;
        //}

        //public string Name2()
        //{
        //    string name2 = "C";
        //    return Color2() + name2;
        //}
        //public string Color2()
        //{
        //    string color2 = "W";
        //    return color2;
        //}
        //public void Move()
        //{
        //    //DoStuff
        //}
    }
}
