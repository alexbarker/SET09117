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
        public int startingPositionX = 0;
        public int startingPositionY = 0;
        public int holding = 0;
        public int turn = 0;
        public int pieceType = 0;
        public int player = 2;
        public int playerOneScore = 0;
        public int playerTwoScore = 0;
        bool valid = false;
        bool validJump = false;

        public bool ValidateNormalMove(int[,] pieceValues, int player, int pieceType, int holding, int playerOneScore, int playerTwoScore, int turn, int movementPositionX, int movementPositionY, int startingPositionX, int startingPositionY)
        {
            switch (pieceType)
            {
                case 1:

                    if ((piece.pieceValues[movementPositionY, movementPositionX] == 0) && ((movementPositionY == startingPositionY + 1 && movementPositionX == startingPositionX + 1) || (movementPositionY == startingPositionY + 1 && movementPositionX == startingPositionX - 1)))
                    {
                        valid = true;
                        piece.pieceValues[movementPositionY, movementPositionX] = pieceType;
                        board.ReDrawBoard();
                        piece.SetPieces();
                        Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);

                        if (movementPositionY == 7)
                        {
                            pieceType = 3;
                            piece.pieceValues[movementPositionY, movementPositionX] = pieceType;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                    }
                    else
                    {
                        valid = false;
                    }
                    break;
                case 2:

                    if ((piece.pieceValues[movementPositionY, movementPositionX] == 0) && ((movementPositionY == startingPositionY - 1 && movementPositionX == startingPositionX + 1) || (movementPositionY == startingPositionY - 1 && movementPositionX == startingPositionX - 1)))
                    {
                        valid = true;
                        piece.pieceValues[movementPositionY, movementPositionX] = pieceType;
                        board.ReDrawBoard();
                        piece.SetPieces();
                        Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);

                        if (movementPositionY == 0)
                        {
                            pieceType = 4;
                            piece.pieceValues[movementPositionY, movementPositionX] = pieceType;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                    }

                    else
                    {
                        valid = false;
                    }
                    break;
                case 3:

                    if ((piece.pieceValues[movementPositionY, movementPositionX] == 0) && ((movementPositionY == startingPositionY + 1 && movementPositionX == startingPositionX + 1) || (movementPositionY == startingPositionY + 1 && movementPositionX == startingPositionX - 1) || (movementPositionY == startingPositionY - 1 && movementPositionX == startingPositionX + 1) || (movementPositionY == startingPositionY - 1 && movementPositionX == startingPositionX - 1)))
                    {
                        valid = true;
                        piece.pieceValues[movementPositionY, movementPositionX] = pieceType;
                        board.ReDrawBoard();
                        piece.SetPieces();
                        Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                    }

                    else
                    {
                        valid = false;
                    }
                    break;
                case 4:

                    if ((piece.pieceValues[movementPositionY, movementPositionX] == 0) && ((movementPositionY == startingPositionY + 1 && movementPositionX == startingPositionX + 1) || (movementPositionY == startingPositionY + 1 && movementPositionX == startingPositionX - 1) || (movementPositionY == startingPositionY - 1 && movementPositionX == startingPositionX + 1) || (movementPositionY == startingPositionY - 1 && movementPositionX == startingPositionX - 1)))
                    {
                        valid = true;
                        piece.pieceValues[movementPositionY, movementPositionX] = pieceType;
                        board.ReDrawBoard();
                        piece.SetPieces();
                        Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                    }

                    else
                    {
                        valid = false;
                    }
                    break;
            }
            return valid;
        }

        public bool ValidateJumpMove(int[,] pieceValues, int player, int pieceType, int holding, int playerOneScore, int playerTwoScore, int turn, int movementPositionX, int movementPositionY, int startingPositionX, int startingPositionY)
        {
            if ((movementPositionX + 1 == -1) || (movementPositionX + 1 == 8) || (movementPositionX - 1 == -1) || (movementPositionX - 1 == 8) || (movementPositionY + 1 == -1) || (movementPositionY + 1 == 8) || (movementPositionY - 1 == -1) || (movementPositionY - 1 == 8))
            {
                validJump = false;
                return validJump;
            }
            else
            {
                switch (pieceType)
                {
                    case 1:

                        if ((piece.pieceValues[movementPositionY, movementPositionX] == 2 || piece.pieceValues[movementPositionY, movementPositionX] == 4) && (movementPositionY == startingPositionY + 1 && movementPositionX == startingPositionX + 1) && (piece.pieceValues[movementPositionY + 1, movementPositionX + 1] == 0))
                        {
                            validJump = true;
                            piece.pieceValues[movementPositionY, movementPositionX] = 0;
                            piece.pieceValues[movementPositionY + 1, movementPositionX + 1] = pieceType;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                            if (movementPositionY + 1 == 7)
                            {
                                pieceType = 3;
                                piece.pieceValues[movementPositionY+1, movementPositionX+1] = pieceType;
                                board.ReDrawBoard();
                                piece.SetPieces();
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                            }
                        }

                        else if ((piece.pieceValues[movementPositionY, movementPositionX] == 2 || piece.pieceValues[movementPositionY, movementPositionX] == 4) && (movementPositionY == startingPositionY + 1 && movementPositionX == startingPositionX - 1) && (piece.pieceValues[movementPositionY + 1, movementPositionX - 1] == 0))
                        {
                            validJump = true;
                            piece.pieceValues[movementPositionY, movementPositionX] = 0;
                            piece.pieceValues[movementPositionY + 1, movementPositionX - 1] = pieceType;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);

                            if (movementPositionY + 1 == 7)
                            {
                                pieceType = 3;
                                piece.pieceValues[movementPositionY+1, movementPositionX-1] = pieceType;
                                board.ReDrawBoard();
                                piece.SetPieces();
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                            }
                        }

                        else
                        {
                            validJump = false;
                        }
                        break;
                    case 2:

                        if ((piece.pieceValues[movementPositionY, movementPositionX] == 1 || piece.pieceValues[movementPositionY, movementPositionX] == 3) && (movementPositionY == startingPositionY - 1 && movementPositionX == startingPositionX + 1) && (piece.pieceValues[movementPositionY - 1, movementPositionX + 1] == 0))
                        {
                            validJump = true;
                            piece.pieceValues[movementPositionY, movementPositionX] = 0;
                            piece.pieceValues[movementPositionY - 1, movementPositionX + 1] = pieceType;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);

                            if (movementPositionY - 1 == 0)
                            {
                                pieceType = 4;
                                piece.pieceValues[movementPositionY-1, movementPositionX+1] = pieceType;
                                board.ReDrawBoard();
                                piece.SetPieces();
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                            }
                        }

                        else if ((piece.pieceValues[movementPositionY, movementPositionX] == 1 || piece.pieceValues[movementPositionY, movementPositionX] == 3) && (movementPositionY == startingPositionY - 1 && movementPositionX == startingPositionX - 1) && (piece.pieceValues[movementPositionY - 1, movementPositionX - 1] == 0))
                        {
                            validJump = true;
                            piece.pieceValues[movementPositionY, movementPositionX] = 0;
                            piece.pieceValues[movementPositionY - 1, movementPositionX - 1] = pieceType;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);

                            if (movementPositionY - 1 == 0)
                            {
                                pieceType = 4;
                                piece.pieceValues[movementPositionY-1, movementPositionX-1] = pieceType;
                                board.ReDrawBoard();
                                piece.SetPieces();
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                            }
                        }

                        else
                        {
                            validJump = false;
                        }
                        break;
                    case 3:

                        if ((piece.pieceValues[movementPositionY, movementPositionX] == 2 || piece.pieceValues[movementPositionY, movementPositionX] == 4) && (movementPositionY == startingPositionY + 1 && movementPositionX == startingPositionX + 1) && (piece.pieceValues[movementPositionY + 1, movementPositionX + 1] == 0))
                        {
                            validJump = true;
                            piece.pieceValues[movementPositionY, movementPositionX] = 0;
                            piece.pieceValues[movementPositionY + 1, movementPositionX + 1] = pieceType;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }

                        else if ((piece.pieceValues[movementPositionY, movementPositionX] == 2 || piece.pieceValues[movementPositionY, movementPositionX] == 4) && (movementPositionY == startingPositionY - 1 && movementPositionX == startingPositionX + 1) && (piece.pieceValues[movementPositionY - 1, movementPositionX + 1] == 0))
                        {
                            validJump = true;
                            piece.pieceValues[movementPositionY, movementPositionX] = 0;
                            piece.pieceValues[movementPositionY - 1, movementPositionX + 1] = pieceType;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }

                        else if ((piece.pieceValues[movementPositionY, movementPositionX] == 2 || piece.pieceValues[movementPositionY, movementPositionX] == 4) && (movementPositionY == startingPositionY + 1 && movementPositionX == startingPositionX - 1) && (piece.pieceValues[movementPositionY + 1, movementPositionX - 1] == 0))
                        {
                            validJump = true;
                            piece.pieceValues[movementPositionY, movementPositionX] = 0;
                            piece.pieceValues[movementPositionY + 1, movementPositionX - 1] = pieceType;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }

                        else if ((piece.pieceValues[movementPositionY, movementPositionX] == 2 || piece.pieceValues[movementPositionY, movementPositionX] == 4) && (movementPositionY == startingPositionY - 1 && movementPositionX == startingPositionX - 1) && (piece.pieceValues[movementPositionY - 1, movementPositionX - 1] == 0))
                        {
                            validJump = true;
                            piece.pieceValues[movementPositionY, movementPositionX] = 0;
                            piece.pieceValues[movementPositionY - 1, movementPositionX - 1] = pieceType;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                        else
                        {
                            validJump = false;
                        }
                        break;
                    case 4:

                        if ((piece.pieceValues[movementPositionY, movementPositionX] == 1 || piece.pieceValues[movementPositionY, movementPositionX] == 3) && (movementPositionY == startingPositionY + 1 && movementPositionX == startingPositionX + 1) && (piece.pieceValues[movementPositionY + 1, movementPositionX + 1] == 0))
                        {
                            validJump = true;
                            piece.pieceValues[movementPositionY, movementPositionX] = 0;
                            piece.pieceValues[movementPositionY + 1, movementPositionX + 1] = pieceType;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }

                        else if ((piece.pieceValues[movementPositionY, movementPositionX] == 1 || piece.pieceValues[movementPositionY, movementPositionX] == 3) && (movementPositionY == startingPositionY - 1 && movementPositionX == startingPositionX + 1) && (piece.pieceValues[movementPositionY - 1, movementPositionX + 1] == 0))
                        {
                            validJump = true;
                            piece.pieceValues[movementPositionY, movementPositionX] = 0;
                            piece.pieceValues[movementPositionY - 1, movementPositionX + 1] = pieceType;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }

                        else if ((piece.pieceValues[movementPositionY, movementPositionX] == 1 || piece.pieceValues[movementPositionY, movementPositionX] == 3) && (movementPositionY == startingPositionY + 1 && movementPositionX == startingPositionX - 1) && (piece.pieceValues[movementPositionY + 1, movementPositionX - 1] == 0))
                        {
                            validJump = true;
                            piece.pieceValues[movementPositionY, movementPositionX] = 0;
                            piece.pieceValues[movementPositionY + 1, movementPositionX - 1] = pieceType;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }

                        else if ((piece.pieceValues[movementPositionY, movementPositionX] == 1 || piece.pieceValues[movementPositionY, movementPositionX] == 3) && (movementPositionY == startingPositionY - 1 && movementPositionX == startingPositionX - 1) && (piece.pieceValues[movementPositionY - 1, movementPositionX - 1] == 0))
                        {
                            validJump = true;
                            piece.pieceValues[movementPositionY, movementPositionX] = 0;
                            piece.pieceValues[movementPositionY - 1, movementPositionX - 1] = pieceType;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                        else
                        {
                            validJump = false;
                        }
                        break;
                }
                return validJump;
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

                        movementPositionX--;
                        movementPositionY--;
                        board.ReDrawBoard();
                        piece.SetPieces();
                        if (movementPositionX == -1 || movementPositionX == -2 || movementPositionX == 8 || movementPositionY == -1 || movementPositionY == 8)
                        {
                            movementPositionX++;
                            movementPositionY++;
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                        else
                        {
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        }
                        break;

                    case ConsoleKey.DownArrow:

                        movementPositionX++;
                        movementPositionY++;
                        board.ReDrawBoard();
                        piece.SetPieces();
                        if (movementPositionX == -1 || movementPositionX == -2 || movementPositionX == 8 || movementPositionY == -1 || movementPositionY == 8)
                        {
                            movementPositionX--;
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

                        Changes(piece.pieceValues, movementPositionX, movementPositionY, holding, pieceType, turn);
                        Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        break;

                    case ConsoleKey.Q:

                        Console.Clear();
                        Menu menu = new Menu();
                        menu.DrawTitle();
                        break;

                    case ConsoleKey.U:

                        // undo move
                        break;

                    case ConsoleKey.R:

                        // use the AI to pick a move, update turn etc
                        break;

                    case ConsoleKey.I:

                        // instant replay
                        break;

                    case ConsoleKey.S:

                        // save to txt file
                        break;

                    case ConsoleKey.Spacebar:

                        if (holding == 0)
                        {
                            if (piece.pieceValues[movementPositionY, movementPositionX] == 0)
                            {
                                board.ReDrawBoard();
                                piece.SetPieces();
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                            }
                            else if ((turn % 2 == 0) && (piece.pieceValues[movementPositionY, movementPositionX] % 2 == 0))
                            {
                                holding++;
                                pieceType = piece.pieceValues[movementPositionY, movementPositionX];
                                piece.pieceValues[movementPositionY, movementPositionX] = 0;
                                startingPositionX = movementPositionX;
                                startingPositionY = movementPositionY;
                                board.ReDrawBoard();
                                piece.SetPieces();
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                            }
                            else if ((turn % 2 != 0) && (piece.pieceValues[movementPositionY, movementPositionX] % 2 != 0))
                            {
                                holding++;
                                pieceType = piece.pieceValues[movementPositionY, movementPositionX];
                                piece.pieceValues[movementPositionY, movementPositionX] = 0;
                                startingPositionX = movementPositionX;
                                startingPositionY = movementPositionY;
                                board.ReDrawBoard();
                                piece.SetPieces();
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                            }
                        }
                        else if (holding == 1)
                        {
                            if (startingPositionY == movementPositionY && startingPositionX == movementPositionX)
                            {
                                piece.pieceValues[movementPositionY, movementPositionX] = pieceType;
                                board.ReDrawBoard();
                                piece.SetPieces();
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                                pieceType = 0;
                                holding--;
                                break;
                            }
                            if ((pieceType == piece.pieceValues[movementPositionY, movementPositionX]) || (pieceType == pieceType + 2))
                            {
                                board.ReDrawBoard();
                                piece.SetPieces();
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                            }
                            else if ((pieceType != piece.pieceValues[movementPositionY, movementPositionX]) && (piece.pieceValues[movementPositionY, movementPositionX] != pieceType + 2))
                            {
                                valid = ValidateNormalMove(piece.pieceValues, player, pieceType, holding, playerOneScore, playerTwoScore, turn, movementPositionX, movementPositionY, startingPositionX, startingPositionY);
                                validJump = ValidateJumpMove(piece.pieceValues, player, pieceType, holding, playerOneScore, playerTwoScore, turn, movementPositionX, movementPositionY, startingPositionX, startingPositionY);

                                if (player == 2 && validJump == true)
                                {
                                    playerTwoScore++;
                                    score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                                    if (playerTwoScore == 12)
                                    {
                                        Console.SetCursorPosition(58, 28);
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write("PLAYER TWO WINS!");
                                        break;
                                    }
                                    player--;
                                    holding--;
                                    turn++;
                                    Console.SetCursorPosition(98, 21);
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("    ");
                                    Console.SetCursorPosition(98, 10);
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("<██>");
                                    pieceType = 0;
                                    validJump = false;
                                    valid = false;
                                }
                                else if (player == 1 && validJump == true)
                                {     
                                    playerOneScore++;
                                    score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                                    if (playerOneScore == 12)
                                    {
                                        Console.SetCursorPosition(58, 28);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write("PLAYER ONE WINS!");
                                        break;
                                    }
                                    player++;
                                    holding--;
                                    turn++;
                                    Console.SetCursorPosition(98, 21);
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("<██>");
                                    Console.SetCursorPosition(98, 10);
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("    ");
                                    pieceType = 0;
                                    validJump = false;
                                    valid = false;
                                }
                                
                                else if (player == 2 && valid == true && validJump == false)
                                {
                                    player--;
                                    holding--;
                                    turn++;
                                    Console.SetCursorPosition(98, 21);
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("    ");
                                    Console.SetCursorPosition(98, 10);
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("<██>");
                                    pieceType = 0;
                                    valid = false;
                                    validJump = false;
                                }
                                else if (player == 1 && valid == true && validJump == false)
                                {
                                    player++;
                                    holding--;
                                    turn++;
                                    Console.SetCursorPosition(98, 21);
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("<██>");
                                    Console.SetCursorPosition(98, 10);
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("    ");
                                    pieceType = 0;
                                    valid = false;
                                    validJump = false;
                                }
                                board.ReDrawBoard();
                                piece.SetPieces();
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                                
                                //piece.undoPieceValues = (int[,])piece.pieceValues.Clone();
                            }
                        }
                        board.ReDrawBoard();
                        piece.SetPieces();
                        Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
                        break;
                        }               
                }
            }

        public void Changes(int[,] pieceValues, int movementPositionX, int movementPositionY, int holding, int pieceType, int turn)
        {
            Console.SetCursorPosition(0, 24);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n");
            Console.WriteLine("x" + movementPositionX + " y" + movementPositionY + " Holding:" + holding + " PieceType:" + pieceType + " Player:" + player + " s1:" + playerOneScore + " s2:" + playerTwoScore + "  " + "Turn: " + turn);

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
    }
}

