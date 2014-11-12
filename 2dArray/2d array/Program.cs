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
            SetupWhiteSide whiteSide = new SetupWhiteSide();
            whiteSide.DefaultSetupW(chessBoard.board);
            blackSide.DefaultSetup(chessBoard.board);
            while (true)
            {
                chessBoard.PrintBoard();
                Console.WriteLine("---------------------------------------");
                string choice = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}