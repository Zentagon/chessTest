using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _2d_array;

namespace _2d_array
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            ChessBoard chessBoard = new ChessBoard();
            SetupBlackSide blackSide = new SetupBlackSide();

            blackSide.DefaultSetup(chessBoard.board);
            while (true)
            {
                chessBoard.PrintBoard();
                Console.WriteLine("-----------------------");
                string choice = Console.ReadLine();
                Console.Clear();
            }
        }
    }

    public class Peasant
    {
        public string Name()
        {
            string name = "P";
            return Color() + name;
        }
        public string Color()
        {
            string color = "B";
            return color;
        }
        public void Move()
        {
            int x = 0;
            int y = 0;
            string[,] hello = new string[x, y];
        }
    }
}