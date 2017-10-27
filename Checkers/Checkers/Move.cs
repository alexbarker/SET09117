using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Move
    {
        Score score = new Score();
        Piece piece = new Piece();
        Board board = new Board();
        public int movementPositionX = 2;
        public int movementPositionY = 5;
        public int holding = 0;
        public int pieceType = 0;
        public int player = 2;
        public int playerOneScore = 0;
        public int playerTwoScore = 0;

        public void Changes(int [,] pieceValues, int movementPositionX, int movementPositionY, int holding, int pieceType)
        {
            Console.SetCursorPosition(0, 24);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n");
            Console.WriteLine("x" + movementPositionX + " y" + movementPositionY + " Holding:" + holding + " PieceType:" + pieceType + " Player:" + player + " s1:" + playerOneScore + " s2:" + playerTwoScore + "  ");

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
                        piece.SetPieces();
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
                        piece.SetPieces();
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
                        piece.SetPieces();
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
                        piece.SetPieces();
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

                        Changes(piece.pieceValues, movementPositionX, movementPositionY, holding, pieceType);
                        Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        break;
                    case ConsoleKey.Q:
                        Console.Clear();
                        Menu menu = new Menu();
                        menu.DrawTitle();
                        break;
                    case ConsoleKey.U:
                        //call pieceValues[current - 1], check score, turn -1, check player and piece type
                        break;
                    case ConsoleKey.H:
                        //use the AI to pick a move, update turn etc
                        break;
                    case ConsoleKey.S:
                        //save to txt file
                        break;
                    case ConsoleKey.Spacebar:
                        // INSERT VALID PICKUP CHECKER HERE
                        if (holding == 0)
                        {
                            // INSERT VALID PICKUP CHECKER HERE
                            pieceType = piece.pieceValues[movementPositionY, movementPositionX];
                            holding++;
                            piece.pieceValues[movementPositionY, movementPositionX] = 0;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                        else if (pieceType == piece.pieceValues[movementPositionY, movementPositionX])
                        {
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                        else
                        {
                            if (player == 2)
                            {  
                                // INSERT VALID MOVE CHECKER HERE
                                playerTwoScore++;
                                score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                                // INSERT WIN CHECKER HERE
                                player--;
                            }
                            else
                            {   // INSERT VALID MOVE CHECKER HERE                             
                                playerOneScore++;
                                score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                                // INSERT WIN CHECKER HERE 
                                player++;
                            }

                            // INSERT VALID MOVE CHECKER HERE
                            holding--;  
                            piece.pieceValues[movementPositionY, movementPositionX] = pieceType;
                            board.ReDrawBoard();
                            piece.SetPieces();                            
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                            pieceType = 0;
                            // INSERT PLAYER TURN UPDATE HERE
                            // INSERT SAVE MOVE HERE
                        }
                        break;
                }
            }
        }
    }
}
