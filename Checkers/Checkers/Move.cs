using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Move
    {
        Piece piece = new Piece();
        Board board = new Board();
        
        public void Changes(int [,] pieceValues, int movementPositionX, int movementPositionY, int holding, int piecetype1)
        {
            Console.SetCursorPosition(0, 24);
            Console.ForegroundColor = ConsoleColor.Black;

            for (int i = 0; i < 8; i++)
            {
                Console.Write(piece.piecePositionsX[i] + " ");
            }
            Console.WriteLine("");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(piece.piecePositionsY[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("x" + movementPositionX + " y" + movementPositionY + " Holding:" + holding + " PieceType:" + piecetype1);

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    switch (pieceValues[x, y])
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
        }

        public void AllowMovement()
        {
            int movementPositionX = 2;
            int movementPositionY = 5;
            int holding = 0;
            int piecetype1 = 0;

            Console.SetCursorPosition(piece.piecePositionsX[2], piece.piecePositionsY[5]);

                while (true)
                {

                var keyPress = Console.ReadKey(false).Key;
                switch (keyPress)
                {
                    case ConsoleKey.UpArrow:
                        
                        movementPositionX = movementPositionX - 1;
                        movementPositionY--;
                        board.ReDrawBoard();
                        piece.UpdatedPieces();
                        if (movementPositionX == -1 || movementPositionX == -2 || movementPositionX == 8 || movementPositionY == -1 || movementPositionY == 8)
                        {
                            movementPositionX = movementPositionX + 1;
                            movementPositionY++;
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                        else
                        {
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                        
                        break;
                    case ConsoleKey.DownArrow:
                        
                        movementPositionX = movementPositionX + 1;
                        movementPositionY++;
                        board.ReDrawBoard();
                        piece.UpdatedPieces();
                        if (movementPositionX == -1 || movementPositionX == -2 || movementPositionX == 8 || movementPositionY == -1 || movementPositionY == 8)
                        {
                            movementPositionX = movementPositionX - 1;
                            movementPositionY--;
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                        else
                        {
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        
                        movementPositionX = movementPositionX + 2;                    
                        board.ReDrawBoard();
                        piece.UpdatedPieces();
                        if (movementPositionX == -1 || movementPositionX == -2 || movementPositionX == 8 || movementPositionX == 9 || movementPositionY == -1 || movementPositionY == 8)
                        {
                            movementPositionX = movementPositionX - 2;
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                        else
                        {
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        
                        movementPositionX = movementPositionX - 2;
                        board.ReDrawBoard();
                        piece.UpdatedPieces();
                        if (movementPositionX == -1 || movementPositionX == -2 || movementPositionX == 8 || movementPositionX == 9 || movementPositionY == -1 || movementPositionY == 8)
                        {
                            movementPositionX = movementPositionX + 2;
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                        else
                        {
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                        break;
                    case ConsoleKey.Escape:

                        Changes(piece.pieceValues, movementPositionX, movementPositionY, holding, piecetype1);
                        Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        break;
                    case ConsoleKey.Q:
                        Console.Clear();
                        Menu menu = new Menu();
                        menu.DrawTitle();
                        break;
                    case ConsoleKey.U:
                        //call pieceValues minus 1, remove all other stuff
                        break;
                    case ConsoleKey.H:
                        //use the AI to pick a move, update turn etc
                        break;
                    case ConsoleKey.S:
                        //save to txt file
                        break;
                    case ConsoleKey.Spacebar:

                        if (holding == 0)
                        {
                            piecetype1 = piece.pieceValues[movementPositionY, movementPositionX];
                            holding++;
                            //piece.PickUpPiece(movementPositionX, movementPositionY);
                            piece.pieceValues[movementPositionY, movementPositionX] = 0;
                            board.ReDrawBoard();
                            piece.UpdatedPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                        else if (piecetype1 == piece.pieceValues[movementPositionY, movementPositionX])
                        {
                            //holding--;
                            //piece.DropPiece(movementPositionX, movementPositionY, piecetype1, holding);
                            //piece.pieceValues[movementPositionY, movementPositionX] = piecetype1;
                            board.ReDrawBoard();
                            piece.UpdatedPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                            //piecetype1 = 0;
                        }
                        else
                        {
                            holding--;
                            // piece.DropPiece(movementPositionX, movementPositionY, piecetype1, holding);
                            piece.pieceValues[movementPositionY, movementPositionX] = piecetype1;
                            board.ReDrawBoard();
                            piece.UpdatedPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                            piecetype1 = 0;
                        }
                        break;
                }
            }
        }
    }
}
