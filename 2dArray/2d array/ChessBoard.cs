﻿using System;
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
        public IChessPiece[,] board = new IChessPiece[x, y];
     
      
        
        Position plays = new Position();
        public void start()
        {

            // Sets out Black pawns
            board[0, 6] = new Pawn("B", new Position(0, 6));
            board[1, 6] = new Pawn("B", new Position(1, 6));
            board[2, 6] = new Pawn("B", new Position(2, 6));
            board[3, 6] = new Pawn("B", new Position(3, 6));
            board[4, 6] = new Pawn("B", new Position(4, 6));
            board[5, 6] = new Pawn("B", new Position(5, 6));
            board[6, 6] = new Pawn("B", new Position(6, 6));
            board[7, 6] = new Pawn("B", new Position(7, 6));
            // Sets out White pawns
            board[0, 1] = new Pawn("W", new Position(0, 1));
            board[1, 1] = new Pawn("W", new Position(1, 1));
            board[2, 1] = new Pawn("W", new Position(2, 1));
            board[3, 1] = new Pawn("W", new Position(3, 1));
            board[4, 1] = new Pawn("W", new Position(4, 1));
            board[5, 1] = new Pawn("W", new Position(5, 1));
            board[6, 1] = new Pawn("W", new Position(6, 1));
            board[7, 1] = new Pawn("W", new Position(7, 1));
            // Sets out White King
            board[4, 0] = new King("W", new Position(4, 0));
            // Sets out Black Kings
            board[4, 7] = new King("B", new Position(4, 7));
            // Sets out White Queen
            board[3, 0] = new Queen("W", new Position(3, 0));
            // Sets out Black Queen
            board[3, 7] = new Queen("B", new Position(3, 7));
            // Sets out White Tower
            board[0, 0] = new Tower("W", new Position(0, 0));
            board[7, 0] = new Tower("W", new Position(7, 0));
            // Sets out Black Tower
            board[0, 7] = new Tower("B", new Position(0, 7));
            board[7, 7] = new Tower("B", new Position(7, 7));
            // Sets out White Crusader
            board[1, 0] = new Crusader("W", new Position(1,0));
            board[6, 0] = new Crusader("W", new Position(6, 0));
            // Sets out Black Crusader
            board[1, 7] = new Crusader("B", new Position(1, 7));
            board[6, 7] = new Crusader("B", new Position(6, 7));
            // Sets out white Bishop
            board[2, 0] = new Bishop("W", new Position(2, 0));
            board[5, 0] = new Bishop("W", new Position(5, 0));
            // Sets out Black Bishop
            board[2, 7] = new Bishop("B", new Position(2, 7));
            board[5, 7] = new Bishop("B", new Position(5, 7));
           
            
        }
        //public void Movits()
        //{
            
        //}

        // Prints out board to screen with a 2d Array
        public void PrintBoard()
        {
            Console.WriteLine("   AlphaChess v.1.33.7 | Copyright 2014 c The Game Geeks at EC");
            Console.WriteLine("   --------------------------------------------------------------");
            Console.WriteLine("                Black Side   ");
            Console.WriteLine(@"
 1 |  [ {0} ] ( {1} ) [ {2} ] ( {3} ) [ {4} ] ( {5} ) [ {6} ] ( {7} )   
 2 |  ( {8} ) [ {9} ] ( {10} ) [ {11} ] ( {12} ) [ {13} ] ( {14} ) [ {15} ]   
 3 |  [  {16}  ] (  {17}  ) [  {18}  ] (  {19}  ) [  {20}  ] (  {21}  ) [  {22}  ] (  {23}  )  
 4 |  (  {24}  ) [  {25}  ] (  {26}  ) [  {27}  ] (  {28}  ) [  {29}  ] (  {30}  ) [  {31}  ]   
 5 |  [  {32}  ] (  {33}  ) [  {34}  ] (  {35}  ) [  {36}  ] (  {37}  ) [  {38}  ] (  {39}  )   
 6 |  (  {40}  ) [  {41}  ] (  {42}  ) [  {43}  ] (  {44}  ) [  {45}  ] (  {46}  ) [  {47}  ]   
 7 |  [ {48} ] ( {49} ) [ {50} ] ( {51} ) [ {52} ] ( {53} ) [ {54} ] ( {55} )  
 8 |  ( {56} ) [ {57} ] ( {58} ) [ {59} ] ( {60} ) [ {61} ] ( {62} ) [ {63} ]   ",

                board[0, 7], board[1, 7], board[2, 7], board[3, 7], board[4, 7], board[5, 7], board[6, 7], board[7, 7],
                board[0, 6], board[1, 6], board[2, 6], board[3, 6], board[4, 6], board[5, 6], board[6, 6], board[7, 6],
                board[0, 5], board[1, 5], board[2, 5], board[3, 5], board[4, 5], board[5, 5], board[6, 5], board[7, 5],
                board[0, 4], board[1, 4], board[2, 4], board[3, 4], board[4, 4], board[5, 4], board[6, 4], board[7, 4],
                board[0, 3], board[1, 3], board[2, 3], board[3, 3], board[4, 3], board[5, 3], board[6, 3], board[7, 3],
                board[0, 2], board[1, 2], board[2, 2], board[3, 2], board[4, 2], board[5, 2], board[6, 2], board[7, 2],
                board[0, 1], board[1, 1], board[2, 1], board[3, 1], board[4, 1], board[5, 1], board[6, 1], board[7, 1],
                board[0, 0], board[1, 0], board[2, 0], board[3, 0], board[4, 0], board[5, 0], board[6, 0], board[7, 0]);

            Console.WriteLine("\r\n                White Side   ");

            Console.WriteLine("   ------------------------------------------------------------\r\n" +
                              "         A      B     C      D       E      F      G      H");
        }
    }
}