using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2d_array
{
    public class ChessBoard
    {
        public static int x = 8;
        public static int y = 8;
        public string[,] board = new string[x, y];

    public void PrintBoard()
    {






        

            Console.WriteLine("   AlphaChess v.1.33.7 | Copyright 2014 c The Game Geeks at EC");
            Console.WriteLine("   ----------------------------------------");
            Console.WriteLine("                Black Side   ");
            Console.WriteLine("");
            Console.Write("8 | ");
       Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[0, 0], board[0, 1], board[0, 2],
                board[0, 3], board[0, 4], board[0, 5], board[0, 6], board[0, 7]);
            Console.Write("7 | ");  
       Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[1, 0], board[1, 1], board[1, 2],
                board[1, 3], board[1, 4], board[1, 5], board[1, 6], board[1, 7]);
            Console.Write("6 | ");     
        Console.WriteLine("[ {0} ] [ {1} ] [ {2} ] [ {3} ] [ {4} ] [ {5} ] [ {6} ] [ {7} ]", board[2, 0], board[2, 1], board[2, 2],
                board[2, 3], board[2, 4], board[2, 5], board[2, 6], board[2, 7]);
            Console.Write("5 | ");  
        Console.WriteLine("[ {0} ] [ {1} ] [ {2} ] [ {3} ] [ {4} ] [ {5} ] [ {6} ] [ {7} ]", board[3, 0], board[3, 1], board[3, 2],
                board[3, 3], board[3, 4], board[3, 5], board[3, 6], board[3, 7]);
            Console.Write("4 | ");     
        Console.WriteLine("[ {0} ] [ {1} ] [ {2} ] [ {3} ] [ {4} ] [ {5} ] [ {6} ] [ {7} ]", board[4, 0], board[4, 1], board[4, 2],
                board[4, 3], board[4, 4], board[4, 5], board[4, 6], board[4, 7]);
            Console.Write("3 | ");     
        Console.WriteLine("[ {0} ] [ {1} ] [ {2} ] [ {3} ] [ {4} ] [ {5} ] [ {6} ] [ {7} ]", board[5, 0], board[5, 1], board[5, 2],
                board[5, 3], board[5, 4], board[5, 5], board[5, 6], board[5, 7]);
            Console.Write("2 | " );    
        Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[6, 0], board[6, 1], board[6, 2],
                board[6, 3], board[6, 4], board[6, 5], board[6, 6], board[6, 7]);
            Console.Write("1 | " );    
        Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", board[7, 0], board[7, 1], board[7, 2],
                board[7, 3], board[7, 4], board[7, 5], board[7, 6], board[7, 7]);
        Console.WriteLine("   ----------------------------------------");
       
        Console.Write("     A"); Console.Write("     B"); Console.Write("    C"); Console.Write("    D"); Console.Write("    E"); Console.Write("    F"); Console.Write("    G"); Console.WriteLine("    H");
            
        }
    }
}