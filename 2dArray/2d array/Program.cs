﻿using System;
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


            // DETTA ÄR MENYN
        Console.WriteLine("   AlphaChess v.1.33.7 | Copyright 2014 c The Geeks at EC");
        Console.WriteLine("   ----------------------------------");
        Console.WriteLine("   What do you want to do?");
        Console.WriteLine("   P.Play a game");
        Console.WriteLine("   I.Instructions");
        Console.WriteLine("   X.Exit");


var input = Console.ReadKey();

            switch (input.Key) //Switch on Key enum
            {

                    //PLAY
                case ConsoleKey.P:
                    Console.Clear();






                    break;
                    //EXIT
                case ConsoleKey.X:

                    // HÄR SKA FINNAS EN SHUTDOWN FÖR PROGRAMMET
                   
                    break;
               
              // INSTUKTIONER
                case ConsoleKey.I:
                    Console.Clear();
                    Console.WriteLine("   CHESS RULES & HOW-TO");
                    Console.WriteLine(" ----------------------------------");
                    Console.WriteLine(" Your objective is to kill the black king,");
                    Console.WriteLine(" it might sound very racist but it is not.");
                    Console.WriteLine(" Whenever something is 'killed', the square is replaced by your own chesspiece");
                    Console.WriteLine("");

                    Console.WriteLine(" There will always be 2 letters for a piece,");
                    Console.WriteLine(" first is for color and second is for character.");
                    Console.WriteLine("");
                    Console.WriteLine(" Every unit on the chessboard can move in a certain pattern:");
                    Console.WriteLine(" PAWNS aka P");
                    Console.WriteLine(" Move: 2 or 1 squares foward at first move, afterwards only 1 foward.");
                    Console.WriteLine(" Attack: can only attack an enemy if it stands snett framför.");
                    Console.WriteLine("");
                    Console.WriteLine(" Tower aka T");
                    Console.WriteLine(" Move: Can Move all the way in both horizonal and vertical. Can be blocked");
                    Console.WriteLine(" Attack: Move all the way untill an is reached enemy.");
                    Console.WriteLine("");
                    Console.WriteLine(" HORSE aka H");
                    Console.WriteLine("Move: 2 Steps to a direction and then one square to the Right/Left");
                    Console.WriteLine("Attack: Gotta land on the enemy to have it killed");
                    Console.WriteLine("");
                    Console.WriteLine(" CRUSADER aka C");
                    Console.WriteLine("");
                    Console.WriteLine(" QUEEN aka Q");
                    Console.WriteLine("");
                    Console.WriteLine(" KING aka K");
                    Console.WriteLine("");

                    // SVAR PÅ OM ALLT ÄR FÖRSTÅTT
                    Console.WriteLine(" Is it all understood?");
                    var answer = Console.ReadKey();
                    
                switch (answer.Key)
                    {
                        case ConsoleKey.Y:
                             Console.WriteLine("");
                             Console.WriteLine("Great, let's game!");
                             
                            break;
                        case ConsoleKey.N:
                            Console.Clear();
                            Console.WriteLine("Oh.. I will explain it one more time! But more simple this time.. ");
                            break;
                    }
                   

                    break;
            }


            // SPELET STARTAR 
      //  ChessBoard chessBoard = new ChessBoard();
      //  SetupBlackSide blackside = new SetupBlackSide();
      //  SetupWhiteSide whiteSide = new SetupWhiteSide();
      //  whiteSide.DefaultSetupW(chessBoard.board);
      //  blackside.DefaultSetup(chessBoard.board);
      //
      //  while (true)
      //  {
      //      chessBoard.PrintBoard();
      //      Console.WriteLine("   ----------------------------------------");
      //      Console.WriteLine("    Which chesspiece do you want to move?");
      //      var whatmove = Console.ReadLine();
      //      Console.WriteLine("    Where do you want to move it? ");
      //      var moveto = Console.ReadKey();
      //
      //      string choice = Console.ReadLine();
      //      Console.Clear();
      //  }
        }
    }
}