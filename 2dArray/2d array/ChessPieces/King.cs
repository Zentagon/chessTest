﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    public class King : IChessPiece
    {

        public Position position;

        public King (string color, Position pos)
        {
            this.Color = color;
            position = pos;
        }

        public string Name()
        {
            string name = "K";
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
