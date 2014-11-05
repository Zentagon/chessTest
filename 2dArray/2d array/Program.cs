using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2d_array
{
    class ChessBoard
    {
        public static int x = 8;
        public static int y = 8;
        public string[,] board = new string[x, y];

        public void PrintBoard()
        {
            Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[0, 0], board[0, 1], board[0, 2], board[0, 3], board[0, 4], board[0, 5], board[0, 6], board[0, 7]);
            Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[1, 0], board[1, 1], board[1, 2], board[1, 3], board[1, 4], board[1, 5], board[1, 6], board[1, 7]);
            Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[2, 0], board[2, 1], board[2, 2], board[2, 3], board[2, 4], board[2, 5], board[2, 6], board[2, 7]);
            Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[3, 0], board[3, 1], board[3, 2], board[3, 3], board[3, 4], board[3, 5], board[3, 6], board[3, 7]);
            Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[4, 0], board[4, 1], board[4, 2], board[4, 3], board[4, 4], board[4, 5], board[4, 6], board[4, 7]);
            Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[5, 0], board[5, 1], board[5, 2], board[5, 3], board[5, 4], board[5, 5], board[5, 6], board[5, 7]);
            Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[6, 0], board[6, 1], board[6, 2], board[6, 3], board[6, 4], board[6, 5], board[6, 6], board[6, 7]);
            Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[7, 0], board[7, 1], board[7, 2], board[7, 3], board[7, 4], board[7, 5], board[7, 6], board[7, 7]);
        }
    }
    class Program
    {
        private static void Main(string[] args)
        {
            //int x = 8; // row
            //int y = 8; // column
            //string[,] board = new string[x, y];
            ChessBoard chessBoard = new ChessBoard();

            Peasant blackBonde1= new Peasant();
            Peasant blackBonde2 = new Peasant();
            Peasant blackBonde3 = new Peasant();
            Peasant blackBonde4 = new Peasant();
            Peasant blackBonde5 = new Peasant();
            Peasant blackBonde6 = new Peasant();
            Peasant blackBonde7 = new Peasant();
            Peasant blackBonde8 = new Peasant();
            //board[7, 1] = blackBonde1.Name(); board[6, 1] = blackBonde2.Name(); board[5, 1] = blackBonde3.Name(); board[4, 1] = blackBonde4.Name(); board[3, 1] = blackBonde5.Name(); board[2, 1] = blackBonde6.Name(); board[1, 1] = blackBonde7.Name(); board[0, 1] = blackBonde8.Name();

            while (true)
            {

                //Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[0, 0], board[0, 1], board[0, 2], board[0, 3], board[0, 4], board[0, 5], board[0, 6], board[0, 7]);
                //Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[1, 0], board[1, 1], board[1, 2], board[1, 3], board[1, 4], board[1, 5], board[1, 6], board[1, 7]);
                //Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[2, 0], board[2, 1], board[2, 2], board[2, 3], board[2, 4], board[2, 5], board[2, 6], board[2, 7]);
                //Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[3, 0], board[3, 1], board[3, 2], board[3, 3], board[3, 4], board[3, 5], board[3, 6], board[3, 7]);
                //Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[4, 0], board[4, 1], board[4, 2], board[4, 3], board[4, 4], board[4, 5], board[4, 6], board[4, 7]);
                //Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[5, 0], board[5, 1], board[5, 2], board[5, 3], board[5, 4], board[5, 5], board[5, 6], board[5, 7]);
                //Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[6, 0], board[6, 1], board[6, 2], board[6, 3], board[6, 4], board[6, 5], board[6, 6], board[6, 7]);
                //Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[7, 0], board[7, 1], board[7, 2], board[7, 3], board[7, 4], board[7, 5], board[7, 6], board[7, 7]);
                Console.WriteLine("-------------------------");
                string choice = Console.ReadLine();
                if (choice == "Kalle")
                {
                }
                


                //Console.Write("Which: ");
                //string piece = Console.ReadLine();
                //board[x, y] = move.MoveCheck(choice);
                //switch (choice)
                //{
                //    case "A1":
                //        x = 7;
                //        y = 0;
                //        board[x, y] = "BP";
                //        break;
                //    case "B1":
                //        x = 7;
                //        y = 1;
                //        board[x, y] = "BP";
                //        break;
                //    case "C1":
                //        x = 7;
                //        y = 2;
                //        board[x, y] = "BP";
                //        break;
                //}
                

                Console.Clear();
            }
            
            
        }
    }

    public class Position
    {
        
    }
    public class Peasant : Position
    {
        public string Name()
        {
            string name = "BP";
            return name;
        }

        public void Move()
        {
            int x = 0;
            int y = 0;
            string[,] hello = new string[x, y];
        }
    }

    //public string MoveCheck(string input)
        //{
        //    int x = 0, y = 0;
        //    string[,] plats =new string[x, y];
        //    if (input.Contains("A")){y = 0;}
        //    else {if (input.Contains("B")){y = 1;}
        //        else {if (input.Contains("C")) {y=2;}
        //            else {if (input.Contains("D")){y = 3;}
        //                 else {if (input.Contains("E")) {y=4;}
        //                }
        //            }
        //        }
        //    }
        //    if (input.Contains("1")) {x=7;}
        //    else {if (input.Contains("2")) {x=6;}
        //        else{if (input.Contains("3")) {x=5;}
        //            else{if (input.Contains("4")){x=4;}
        //                else{if (input.Contains("5")){x=3;}
        //                }
        //            }
        //        }
        //    }
        
        //    return plats[x, y] = "BP";
        
}
