using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Game
    {
        public void SimulateNewGame()
        {
            Board board = new Board();
            board.DrawBoard();

            Piece piece = new Piece();
            piece.SetPieces();

            Score scores = new Score();
            scores.SetScores();

            Program delay = new Program();
            delay.Delay(2);

            scores.SimulateScores();

            Console.SetCursorPosition(1, 27);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("");
            Console.ReadLine();
        }

        public void NewGame()
        {
            Board board = new Board();
            board.DrawBoard();

            Piece piece = new Piece();
            piece.SetPieces();

            Score scores = new Score();
            scores.SetScores();

            // Variables for tracking player turn and scores
            //int player = 1;
            //int player1Score = 0;
            //int player2Score = 0;

            //Console.SetCursorPosition(46, 3);
            //Console.ForegroundColor = ConsoleColor.Black;

            // Display game state (for testing only)
            Console.SetCursorPosition(0, 24);
            Console.ForegroundColor = ConsoleColor.Black;
            /*
            for (int i = 0; i < 8; i++)
            {
                Console.Write(piece.piecePositionsX[i] + " ");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(piece.piecePositionsY[i] + " ");
            }
            Console.WriteLine("\n");
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    switch (piece.pieceValues[x,y])
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("0 ");
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("1 ");
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("2 ");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("K ");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("K ");
                            break;
                        default:
                            break;
                    }
                }
                Console.Write("\n");
            }
            */
            //scores.SimulateScores();
            // board.ReDrawBoard();
            Console.SetCursorPosition(46, 18);
            Console.ForegroundColor = ConsoleColor.Black;

            /*
            int upArrow = 0;
            int downArrow = 0;
            int leftArrow = 0;
            int rightArrow = 0;
            int whitePiece = 1;
            int blackPiece = 2;
            int whiteKingPiece = 3;
            int blackKingPiece = 4;
            int movementPositionX = 0;
            int movementPositionY = 0;

            movementPositionX = upArrow - downArrow;
            movementPositionY = rightArrow - leftArrow;
            */
            //restrict movement to array positions x,y
            //get new location by counting arrows
            //get piece colour by counting player turn
            //update board
            //
            //OR update array every key stroke

            Move move = new Move();
            move.AllowMovement();
            //move.overWritePiece();

            Console.ReadLine();
        }
    }
}
