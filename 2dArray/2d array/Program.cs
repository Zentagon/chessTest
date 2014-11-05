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
    public class StartPositionBlackSide
    {
        // När spelet startar så läses denna in först, assignerar default platser för pjäser.
        private static int x = 8;
        private static int y = 8;
        private string[,] defaultSlot = new string[x, y];
        Peasant blackBonde1 = new Peasant();
        Peasant blackBonde2 = new Peasant();
        Peasant blackBonde3 = new Peasant();
        Peasant blackBonde4 = new Peasant();
        Peasant blackBonde5 = new Peasant();
        Peasant blackBonde6 = new Peasant();
        Peasant blackBonde7 = new Peasant();
        Peasant blackBonde8 = new Peasant();
        public void DefaultSetup()
        {
            defaultSlot[1, 0] = blackBonde1.Name();
            defaultSlot[1, 1] = blackBonde2.Name();
            defaultSlot[1, 2] = blackBonde3.Name();
            defaultSlot[1, 3] = blackBonde4.Name();
            defaultSlot[1, 4] = blackBonde5.Name();
            defaultSlot[1, 5] = blackBonde6.Name();
            defaultSlot[1, 6] = blackBonde7.Name();
            defaultSlot[1, 7] = blackBonde8.Name();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            ChessBoard chessBoard = new ChessBoard();

            Peasant blackBonde1 = new Peasant();
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
}