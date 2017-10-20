using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Game
    {
        public void NewGame()
        {
            Board board = new Board();
            board.DrawBoard();

            Piece piece = new Piece();
            piece.DisplayPieces();

            Score scores = new Score();
            scores.SetScores();

            Program delay = new Program();
            delay.Delay(5);

            scores.ScoreDisplayer(2,1);

            Console.SetCursorPosition(1, 27);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("");
            Console.ReadLine();

            //start game logic here//
            //-----------------------------------------------------------------------//


        }
    }
}
