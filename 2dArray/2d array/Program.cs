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
            new Menu();

            Player P1 = new Player("White");
            Player P2 = new Player("Black");
            var turn = P1; // P1 börjar

            while (true)
            {
                //Vits tur
                var WhitePieces = P1.GetPieces();
                var BlackPieces = P2.GetPieces();

               
            




            // SPELET STARTAR 
            ChessBoard chessBoard = new ChessBoard();
            SetupBlackSide blackside = new SetupBlackSide();
            SetupWhiteSide whiteSide = new SetupWhiteSide();
            whiteSide.DefaultSetupW(chessBoard.board);
            blackside.DefaultSetup(chessBoard.board);

            while (true)
            {
                chessBoard.PrintBoard();
                Console.WriteLine("   ----------------------------------------");
                Console.WriteLine("    Which chesspiece do you want to move?");
                var whatmove = Console.ReadLine();
                Console.WriteLine("    Where do you want to move it? ");
                var moveto = Console.ReadKey();

                string choice = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
        }
