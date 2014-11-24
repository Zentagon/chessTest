using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    class SetupWhiteSide
    {
        public string DefaultSetupW(string[,] input)
        {
            int x = 8;
            int y = 8;
            string[,] board = new string[x, y];
            Peasant WhiteBonde1 = new Peasant("W", new Position(6, 0));
            Peasant WhiteBonde2 = new Peasant("W", new Position(6, 1));
            Peasant WhiteBonde3 = new Peasant("W", new Position(6, 2));
            Peasant WhiteBonde4 = new Peasant("W", new Position(6, 3));
            Peasant WhiteBonde5 = new Peasant("W", new Position(6, 4));
            Peasant WhiteBonde6 = new Peasant("W", new Position(6, 5));
            Peasant WhiteBonde7 = new Peasant("W", new Position(6, 6));
            Peasant WhiteBonde8 = new Peasant("W", new Position(6, 7));
            King king = new King("W", new Position(7, 4));
            Queen queen = new Queen("W", new Position(7, 3));
            Bishop bishop = new Bishop("W", new Position(7, 2));
            Bishop bishop2 = new Bishop("W", new Position(7, 5));
            Tower tower = new Tower("W", new Position(7, 0));
            Tower tower2 = new Tower("W", new Position(7, 7));
            Crusader crusader = new Crusader("W", new Position(7, 6));
            Crusader crusader2 = new Crusader("W", new Position(7, 1));
            board[7, 5] = bishop2.Name();
            board[7, 2] = bishop.Name();
            board[7, 7] = tower2.Name();
            board[7, 0] = tower.Name();
            board[7, 3] = queen.Name();
            board[7, 4] = king.Name();
            board[7, 6] = crusader2.Name();
            board[7, 1] = crusader.Name();
            board[6, 0] = WhiteBonde1.Name();
            board[6, 1] = WhiteBonde2.Name();
            board[6, 2] = WhiteBonde3.Name();
            board[6, 3] = WhiteBonde4.Name();
            board[6, 4] = WhiteBonde5.Name();
            board[6, 5] = WhiteBonde6.Name();
            board[6, 6] = WhiteBonde7.Name();
            board[6, 7] = WhiteBonde8.Name();
            input[6, 0] = board[6, 0];
            input[6, 1] = board[6, 1];
            input[6, 2] = board[6, 2];
            input[6, 3] = board[6, 3];
            input[6, 4] = board[6, 4];
            input[6, 5] = board[6, 5];
            input[6, 6] = board[6, 6];
            input[6, 7] = board[6, 7];
            input[7, 5] = board[7, 5];
            input[7, 2] = board[7, 2];
            input[7, 7] = board[7, 7];
            input[7, 0] = board[7, 0];
            input[7, 3] = board[7, 3];
            input[7, 4] = board[7, 4];
            input[7, 6] = board[7, 6];
            input[7, 1] = board[7, 1];
            return input[0, 0];
        }
    }
}
