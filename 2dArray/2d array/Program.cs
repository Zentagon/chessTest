﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2d_array
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool valid = true;
            int x = 8; // row
            int y = 8; // column
            string[,] board = new string[x, y];
            Move move = new Move();

            while (true)
            {
                Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[0, 0], board[0, 1], board[0, 2], board[0, 3], board[0, 4], board[0, 5], board[0, 6], board[0, 7]);
                Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[1, 0], board[1, 1], board[1, 2], board[1, 3], board[1, 4], board[1, 5], board[1, 6], board[1, 7]);
                Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[2, 0], board[2, 1], board[2, 2], board[2, 3], board[2, 4], board[2, 5], board[2, 6], board[2, 7]);
                Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[3, 0], board[3, 1], board[3, 2], board[3, 3], board[3, 4], board[3, 5], board[3, 6], board[3, 7]);
                Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[4, 0], board[4, 1], board[4, 2], board[4, 3], board[4, 4], board[4, 5], board[4, 6], board[4, 7]);
                Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[5, 0], board[5, 1], board[5, 2], board[5, 3], board[5, 4], board[5, 5], board[5, 6], board[5, 7]);
                Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[6, 0], board[6, 1], board[6, 2], board[6, 3], board[6, 4], board[6, 5], board[6, 6], board[6, 7]);
                Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[7, 0], board[7, 1], board[7, 2], board[7, 3], board[7, 4], board[7, 5], board[7, 6], board[7, 7]);
                Console.WriteLine("-------------------------");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "A1":
                        x = 7;
                        y = 0;
                        board[x, y] = "BP";
                        break;
                    case "B1":
                        x = 7;
                        y = 1;
                        board[x, y] = "BP";
                        break;
                    case "C1":
                        x = 7;
                        y = 2;
                        board[x, y] = "BP";
                        break;
                }
                Console.Clear();
            }
        }
    }
    public class Move
    {
        public void MoveCheck(string input)
        {
            if (input.Contains("d") || input.Contains("D"))
            {
                //DoStuff
            }
        }
    }
}
