using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    class SetupBlackSide
    {
          // När spelet startar så läses denna in först, assignerar default platser för pjäser.
        public string DefaultSetup(string[,] input)
        {
            
            int x = 8;
            int y = 8;
            string[,] board = new string[x, y];
            Peasant blackBonde1 = new Peasant("B", new Position(1,0));
            Peasant blackBonde2 = new Peasant("B", new Position(1,1));
            Peasant blackBonde3 = new Peasant("B", new Position(1,2));
            Peasant blackBonde4 = new Peasant("B", new Position(1,3));
            Peasant blackBonde5 = new Peasant("B", new Position(1,4));
            Peasant blackBonde6 = new Peasant("B", new Position(1,5));
            Peasant blackBonde7 = new Peasant("B", new Position(1,6));
            Peasant blackBonde8 = new Peasant("B", new Position(1,7));
            King king = new King("B", new Position(0, 4));
            Queen queen = new Queen("B", new Position(0,3));
            Bishop bishop = new Bishop("B", new Position(0,2));
            Bishop bishop2 = new Bishop("B", new Position(0,5));
            Tower tower = new Tower("B", new Position(0,0));
            Tower tower2 = new Tower("B", new Position(0,7));
            Crusader crusader = new Crusader("B", new Position(0,1));
            Crusader crusader2 = new Crusader("B", new Position(0,6));
            board[0, 5] = bishop2.Name();
            board[0, 2] = bishop.Name();
            board[0, 7] = tower2.Name();
            board[0, 0] = tower.Name();
            board[0, 3] = queen.Name();
            board[0, 4] = king.Name();
            board[0, 6] = crusader2.Name();
            board[0, 1] = crusader.Name();
            board[1, 0] = blackBonde1.Name();
            board[1, 1] = blackBonde2.Name();
            board[1, 2] = blackBonde3.Name();
            board[1, 3] = blackBonde4.Name();
            board[1, 4] = blackBonde5.Name();
            board[1, 5] = blackBonde6.Name();
            board[1, 6] = blackBonde7.Name();
            board[1, 7] = blackBonde8.Name();
            input[1, 0] = board[1, 0];
            input[1, 1] = board[1, 1];
            input[1, 2] = board[1, 2];
            input[1, 3] = board[1, 3];
            input[1, 4] = board[1, 4];
            input[1, 5] = board[1, 5];
            input[1, 6] = board[1, 6];
            input[1, 7] = board[1, 7];
            input[0, 5] = board[0, 5];
            input[0, 2] = board[0, 2];
            input[0, 7] = board[0, 7];
            input[0, 0] = board[0, 0];
            input[0, 3] = board[0, 3];
            input[0, 4] = board[0, 4];
            input[0, 6] = board[0, 6];
            input[0, 1] = board[0, 1];
            return input[7, 7];
          }
     }
}
