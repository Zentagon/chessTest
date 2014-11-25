using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    class Menu
    {
        public void MenuStart()
        {
            Console.WriteLine("   AlphaChess v.1.33.7 | Copyright 2014 c The Game Geeks at EC");
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
                    Console.WriteLine("");
                    Console.WriteLine(" PAWNS aka P");
                    Console.WriteLine(" Move: 2 or 1 squares foward at first move, afterwards only 1 foward.");
                    Console.WriteLine(" Attack: can only attack an enemy if it stands snett framför.");
                    Console.WriteLine("");
                    Console.WriteLine(" Tower aka T");
                    Console.WriteLine(" Move: Can Move all the way in both horizonal and vertical. Can be blocked");
                    Console.WriteLine(" Attack: Move all the way untill an is reached enemy.");
                    Console.WriteLine("");
                    Console.WriteLine(" Crusader aka KNIGHT aka C");
                    Console.WriteLine("Move: 2 Steps to a direction and then one square to the Right/Left");
                    Console.WriteLine("Attack: Gotta land on the enemy to have it killed");
                    Console.WriteLine("");
                    Console.WriteLine(" BISHOP aka B");
                    Console.WriteLine("Move: no restrictions in distance for each move, but is limited to diagonal movement. ");
                    Console.WriteLine("");
                    Console.WriteLine(" QUEEN aka Q");
                    Console.WriteLine("Move: Horizontal, Vertical and diagonal untill it reaches a friedly or enemy.");
                    Console.WriteLine("");
                    Console.WriteLine("UNIQUE: if a pawn reaches the other players end, then a new QUEEN will spawn.");
                    Console.WriteLine(" KING aka K");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    // SVAR PÅ OM ALLT ÄR FÖRSTÅTT
                    Console.WriteLine("");
                    Console.WriteLine(" Is it all understood?");
                    Console.WriteLine("");
                    var answer = Console.ReadKey();

                    switch (answer.Key)
                    {
                        case ConsoleKey.Y:
                            Console.WriteLine("");
                            Console.WriteLine("Great, let's game!");
                            Console.WriteLine("");
                            Console.Clear();
                            break;
                        case ConsoleKey.N:
                            Console.Clear();
                            Console.WriteLine("Oh.. I will explain it one more time! But more simple this time.. ");
                            Console.WriteLine("");
                            break;
                    }


                    break;
            }
        }
    }

}
