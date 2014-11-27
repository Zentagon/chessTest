﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
﻿using _2d_array;

namespace _2d_array
{
    public class Move
    {

        private Position currentPosition;

        public Move(Position position)
        {
            currentPosition = position;
        }

        public List<Position> PawnMove()
        {
            List<Position> moveList = new List<Position>();


            moveList.Add(new Position(0, 1));  //Forward

            List<Position> newList = new List<Position>();
            int antalSteg = 1;
            foreach (var item in moveList)
            {


                for (int i = 0; i < antalSteg; i++)
                {
                    var stegX = item.X + currentPosition.X;
                    var stegY = item.Y + currentPosition.Y;
                    newList.Add(new Position(stegX, stegY));
                }

            }
            return newList;
        }
       
    }
}