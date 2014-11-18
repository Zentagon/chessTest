using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    public class Peasant : IChessPiece
    {

        public Position position;

        public Peasant(string color, Position pos)
        {
            this.Color = color;
            position = pos;
        }

        public string Name()
        {
            string name = "P";
            return name;
        }


        public string Color
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public void Move()
        {
            //DoStuff
        }
    }
}

