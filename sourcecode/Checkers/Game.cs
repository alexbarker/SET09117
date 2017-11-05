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
            piece.SetPieces();

            Score scores = new Score();
            scores.SetScores();

            Console.SetCursorPosition(46, 18);
            Console.ForegroundColor = ConsoleColor.Black;

            Move move = new Move();
            move.AllowMovement();

            Console.ReadLine();
        }
    }
}
