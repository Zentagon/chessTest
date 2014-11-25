﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercises_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            int[,] arr = new int[20, 20];
            //Add some random values to the array
            Random R = new Random();
            for (int i = 0; i < 100; i++)
            {
                int x = R.Next(20);
                int y = R.Next(20);
                arr[x, y] = 1;
            }
            while (true)
            {
                Console.Clear();
                game.Print(arr);
                //Process the array and get a modified array back
                arr = game.ProcessGame(arr);


            }
        }

    }
}

namespace Extra_Exercises_8
{
    class Game
    {

        internal protected int CountNeighbors(int x, int y, int[,] arr)
        {
            int count = 0;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x - 1, y - 1] > 0) count++;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x, y - 1] > 0) count++;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x + 1, y - 1] > 0) count++;

            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x - 1, y] > 0) count++;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x + 1, y] > 0) count++;

            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x - 1, y + 1] > 0) count++;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x, y + 1] > 0) count++;
            if (x > 0 && y > 0 && x < 19 && y < 19 && arr[x + 1, y + 1] > 0) count++;
            return count;
        }
        internal protected void Print(int[,] arr)
        {
            for (int y = 19; y >= 0; y--)
            {
                Console.Write(y + " ");
                for (int x = 0; x < 20; x++)
                {
                    int num = arr[x, y];
                    if (num > 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write("*");
                        Console.ResetColor();
                    }
                    else
                    {

                        Console.Write(' ');

                    }


                }

                Console.WriteLine();
            }
        }

        internal protected int[,] ProcessGame(int[,] arr)
        {
            int count = 0;
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    count = CountNeighbors(x, y, arr);
                    if (count < 2)
                    {
                        arr[x, y] = 0;
                    }
                    else if (count > 3)
                    {
                        arr[x, y] = 0;
                    }
                    else if (count == 3)
                    {
                        arr[x, y] = 1;
                    }


                }
            }
            return arr;

        }


    }
}