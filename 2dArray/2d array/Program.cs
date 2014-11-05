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
    }
    class Program
    {
        private static void Main(string[] args)
        {
            ChessBoard chessBoard = new ChessBoard();

            Peasant blackBonde1= new Peasant();
            Peasant blackBonde2 = new Peasant();
            Peasant blackBonde3 = new Peasant();
            Peasant blackBonde4 = new Peasant();
            Peasant blackBonde5 = new Peasant();
            Peasant blackBonde6 = new Peasant();
            Peasant blackBonde7 = new Peasant();
            Peasant blackBonde8 = new Peasant();
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
