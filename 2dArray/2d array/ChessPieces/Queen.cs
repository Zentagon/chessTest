﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    public class Queen : IChessPiece
    {
        public Position position;
        public Queen(string color, Position pos)
        {
            this.Color = color;
            position = pos;
        }
        public string Name()
        {
            string name = "Q";
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

        public override string ToString()
        {
            return Name();
        }
        public void Draw()
        {
            //int startX = Position.X;
            //int startY = Position.Y;

            //Console.SetCursorPosition(startX, startY);
        }
    }
}