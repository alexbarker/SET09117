// SET09117 2017-8 TR1 001 - Algorithms and Data Structures
// Console Checkers
// Version 0.8.0
// Alexander Barker 
// 40333139
// Created on 14th October 2017
// Last Updated on 12th Novemeber 2017

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Checkers
{
    class Move
    {
        Score score = new Score();
        Piece piece = new Piece();
        Board board = new Board();
        Game game = new Game();
        Program delay = new Program();

        public int[] gameData = new int[6];
        public int[] replayGameData = new int[6];

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
        public int dictionaryIndex = 1;

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
                                piece.pieceValues[movementPositionY + 1, movementPositionX + 1] = pieceType;
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
                                piece.pieceValues[movementPositionY + 1, movementPositionX - 1] = pieceType;
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
                                piece.pieceValues[movementPositionY - 1, movementPositionX + 1] = pieceType;
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
                                piece.pieceValues[movementPositionY - 1, movementPositionX - 1] = pieceType;
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

        public void AllowPVPMovement()
        {
            Console.SetCursorPosition(piece.piecePositionsX[2], piece.piecePositionsY[5]);
            piece.moveList.Add(0, (int[,])piece.pieceValues.Clone());
            piece.moveList.Add(1, (int[,])piece.pieceValues.Clone());
            gameData[0] = playerOneScore;
            gameData[1] = playerTwoScore;
            gameData[2] = turn;
            gameData[3] = player;
            gameData[4] = movementPositionX;
            gameData[5] = movementPositionY;
            piece.gameState.Add(0, (int[])gameData.Clone());
            piece.gameState.Add(1, (int[])gameData.Clone());

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
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                        }
                        else
                        {
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
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
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                        }
                        else
                        {
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                        }
                        break;

                    case ConsoleKey.RightArrow:

                        movementPositionX = movementPositionX + 2;
                        board.ReDrawBoard();
                        piece.SetPieces();
                        if (movementPositionX == -1 || movementPositionX == -2 || movementPositionX == 8 || movementPositionX == 9 || movementPositionY == -1 || movementPositionY == 8)
                        {
                            movementPositionX = movementPositionX - 2;
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                        }
                        else
                        {
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                        }
                        break;

                    case ConsoleKey.LeftArrow:

                        movementPositionX = movementPositionX - 2;
                        board.ReDrawBoard();
                        piece.SetPieces();
                        if (movementPositionX == -1 || movementPositionX == -2 || movementPositionX == 8 || movementPositionX == 9 || movementPositionY == -1 || movementPositionY == 8)
                        {
                            movementPositionX = movementPositionX + 2;
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                        }
                        else
                        {
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                        }
                        break;

                    case ConsoleKey.Escape:

                        Changes(piece.pieceValues, movementPositionX, movementPositionY, holding, pieceType, turn);
                        Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                        break;

                    case ConsoleKey.Q:

                        Console.Clear();
                        Menu menu = new Menu();
                        menu.DrawTitle();
                        break;

                    case ConsoleKey.U:

                        foreach (KeyValuePair<int, int[,]> pair in piece.moveList)
                        {
                            if (piece.moveList.ContainsKey((dictionaryIndex - 1)) == true)
                            {
                                piece.pieceValues = (int[,])piece.moveList[(dictionaryIndex - 1)].Clone();
                            }
                        }

                        foreach (KeyValuePair<int, int[]> pair in piece.gameState)
                        {
                            if (piece.gameState.ContainsKey((dictionaryIndex - 1)) == true)
                            {
                                gameData = (int[])piece.gameState[(dictionaryIndex - 1)].Clone();
                                playerOneScore = gameData[0];
                                playerTwoScore = gameData[1];
                                turn = gameData[2];
                                player = gameData[3];
                                movementPositionX = gameData[4];
                                movementPositionY = gameData[5];
                            }
                        }

                        if (player == 2)
                        {
                            Console.SetCursorPosition(98, 21);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("<██>");
                            Console.SetCursorPosition(98, 10);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("    ");
                        }
                        if (player == 1)
                        {
                            Console.SetCursorPosition(98, 21);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("    ");
                            Console.SetCursorPosition(98, 10);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("<██>");
                        }

                        dictionaryIndex++;
                        piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                        piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                        score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                        score.ScoreUpdater((player + 1), playerOneScore, playerTwoScore);
                        score.ScoreUpdater((player - 1), playerOneScore, playerTwoScore);
                        board.ReDrawBoard();
                        piece.SetPieces();
                        Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                        break;

                    case ConsoleKey.R:

                        foreach (KeyValuePair<int, int[,]> pair in piece.moveList)
                        {
                            if (piece.moveList.ContainsKey(dictionaryIndex - 1) == true)
                            {
                                piece.pieceValues = (int[,])piece.moveList[dictionaryIndex - 1].Clone();
                            }
                        }

                        foreach (KeyValuePair<int, int[]> pair in piece.gameState)
                        {
                            if (piece.gameState.ContainsKey(dictionaryIndex - 1) == true)
                            {
                                gameData = (int[])piece.gameState[dictionaryIndex - 1].Clone();
                                playerOneScore = gameData[0];
                                playerTwoScore = gameData[1];
                                turn = gameData[2];
                                player = gameData[3];
                                movementPositionX = gameData[4];
                                movementPositionY = gameData[5];
                            }
                        }

                        if (player == 2)
                        {
                            Console.SetCursorPosition(98, 21);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("<██>");
                            Console.SetCursorPosition(98, 10);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("    ");
                        }
                        if (player == 1)
                        {
                            Console.SetCursorPosition(98, 21);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("    ");
                            Console.SetCursorPosition(98, 10);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("<██>");
                        }

                        dictionaryIndex++;
                        piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                        piece.gameState.Add((dictionaryIndex), (int[])gameData.Clone());
                        score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                        score.ScoreUpdater((player + 1), playerOneScore, playerTwoScore);
                        score.ScoreUpdater((player - 1), playerOneScore, playerTwoScore);
                        board.ReDrawBoard();
                        piece.SetPieces();
                        Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                        break;

                    case ConsoleKey.I:

                        foreach (KeyValuePair<int, int[,]> pair in piece.moveList)
                        {
                            piece.pieceValues = (int[,])piece.moveList[pair.Key].Clone();
                            board.ReDrawBoard();
                            piece.SetPieces();

                            replayGameData = (int[])piece.gameState[pair.Key].Clone();
                            playerOneScore = replayGameData[0];
                            playerTwoScore = replayGameData[1];
                            turn = replayGameData[2];
                            player = replayGameData[3];
                            movementPositionX = replayGameData[4];
                            movementPositionY = replayGameData[5];
                            score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                            score.ScoreUpdater((player + 1), playerOneScore, playerTwoScore);
                            score.ScoreUpdater((player - 1), playerOneScore, playerTwoScore);

                            delay.Delay(1);
                            //if (ConsoleKey.P: break;)
                        }

                        score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                        score.ScoreUpdater((player + 1), playerOneScore, playerTwoScore);
                        score.ScoreUpdater((player - 1), playerOneScore, playerTwoScore);
                        board.ReDrawBoard();
                        piece.SetPieces();
                        Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                        break;

                    case ConsoleKey.S:

                        break;

                    case ConsoleKey.Spacebar:

                        if (holding == 0)
                        {
                            if (piece.pieceValues[movementPositionY, movementPositionX] == 0)
                            {
                                board.ReDrawBoard();
                                piece.SetPieces();
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
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
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
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
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                            }
                        }
                        else if (holding == 1)
                        {
                            if (startingPositionY == movementPositionY && startingPositionX == movementPositionX)
                            {
                                piece.pieceValues[movementPositionY, movementPositionX] = pieceType;
                                board.ReDrawBoard();
                                piece.SetPieces();
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                                pieceType = 0;
                                holding--;
                                break;
                            }
                            if ((pieceType == piece.pieceValues[movementPositionY, movementPositionX]) || (pieceType == pieceType + 2))
                            {
                                board.ReDrawBoard();
                                piece.SetPieces();
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                            }
                            else if ((pieceType != piece.pieceValues[movementPositionY, movementPositionX]) && (piece.pieceValues[movementPositionY, movementPositionX] != pieceType + 2))
                            {
                                valid = ValidateNormalMove(piece.pieceValues, player, pieceType, holding, playerOneScore, playerTwoScore, turn, movementPositionX, movementPositionY, startingPositionX, startingPositionY);
                                validJump = ValidateJumpMove(piece.pieceValues, player, pieceType, holding, playerOneScore, playerTwoScore, turn, movementPositionX, movementPositionY, startingPositionX, startingPositionY);

                                if (player == 2 && validJump == true)
                                {
                                    dictionaryIndex++;
                                    playerTwoScore++;
                                    score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                                    if (playerTwoScore == 12)
                                    {
                                        Console.SetCursorPosition(62, 28);
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write("PLAYER TWO WINS!");
                                        piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                                        gameData[0] = playerOneScore;
                                        gameData[1] = playerTwoScore;
                                        gameData[2] = turn;
                                        gameData[3] = player;
                                        gameData[4] = movementPositionX;
                                        gameData[5] = movementPositionY;
                                        piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                                        Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
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
                                    piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                                    gameData[0] = playerOneScore;
                                    gameData[1] = playerTwoScore;
                                    gameData[2] = turn;
                                    gameData[3] = player;
                                    gameData[4] = movementPositionX;
                                    gameData[5] = movementPositionY;
                                    piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                                }

                                else if (player == 1 && validJump == true)
                                {
                                    dictionaryIndex++;
                                    playerOneScore++;
                                    score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                                    if (playerOneScore == 12)
                                    {
                                        Console.SetCursorPosition(62, 28);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write("PLAYER ONE WINS!");
                                        piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                                        gameData[0] = playerOneScore;
                                        gameData[1] = playerTwoScore;
                                        gameData[2] = turn;
                                        gameData[3] = player;
                                        gameData[4] = movementPositionX;
                                        gameData[5] = movementPositionY;
                                        piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                                        Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
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
                                    piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                                    gameData[0] = playerOneScore;
                                    gameData[1] = playerTwoScore;
                                    gameData[2] = turn;
                                    gameData[3] = player;
                                    gameData[4] = movementPositionX;
                                    gameData[5] = movementPositionY;
                                    piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                                }

                                else if (player == 2 && valid == true && validJump == false)
                                {
                                    dictionaryIndex++;
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
                                    piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                                    gameData[0] = playerOneScore;
                                    gameData[1] = playerTwoScore;
                                    gameData[2] = turn;
                                    gameData[3] = player;
                                    gameData[4] = movementPositionX;
                                    gameData[5] = movementPositionY;
                                    piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                                }

                                else if (player == 1 && valid == true && validJump == false)
                                {
                                    dictionaryIndex++;
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
                                    piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                                    gameData[0] = playerOneScore;
                                    gameData[1] = playerTwoScore;
                                    gameData[2] = turn;
                                    gameData[3] = player;
                                    gameData[4] = movementPositionX;
                                    gameData[5] = movementPositionY;
                                    piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                                }
                                board.ReDrawBoard();
                                piece.SetPieces();
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                            }
                        }
                        board.ReDrawBoard();
                        piece.SetPieces();
                        Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                        break;
                }
            }
        }

        public void AllowPVCMovement()
        {
            Console.SetCursorPosition(piece.piecePositionsX[2], piece.piecePositionsY[5]);
            piece.moveList.Add(0, (int[,])piece.pieceValues.Clone());
            piece.moveList.Add(1, (int[,])piece.pieceValues.Clone());
            gameData[0] = playerOneScore;
            gameData[1] = playerTwoScore;
            gameData[2] = turn;
            gameData[3] = player;
            gameData[4] = movementPositionX;
            gameData[5] = movementPositionY;
            piece.gameState.Add(0, (int[])gameData.Clone());
            piece.gameState.Add(1, (int[])gameData.Clone());

            while (true)
            {
                if (player == 2)
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
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                            }
                            else
                            {
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
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
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                            }
                            else
                            {
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                            }
                            break;

                        case ConsoleKey.RightArrow:

                            movementPositionX = movementPositionX + 2;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            if (movementPositionX == -1 || movementPositionX == -2 || movementPositionX == 8 || movementPositionX == 9 || movementPositionY == -1 || movementPositionY == 8)
                            {
                                movementPositionX = movementPositionX - 2;
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                            }
                            else
                            {
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                            }
                            break;

                        case ConsoleKey.LeftArrow:

                            movementPositionX = movementPositionX - 2;
                            board.ReDrawBoard();
                            piece.SetPieces();
                            if (movementPositionX == -1 || movementPositionX == -2 || movementPositionX == 8 || movementPositionX == 9 || movementPositionY == -1 || movementPositionY == 8)
                            {
                                movementPositionX = movementPositionX + 2;
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                            }
                            else
                            {
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                            }
                            break;

                        case ConsoleKey.Escape:

                            Changes(piece.pieceValues, movementPositionX, movementPositionY, holding, pieceType, turn);
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                            break;

                        case ConsoleKey.Q:

                            Console.Clear();
                            Menu menu = new Menu();
                            menu.DrawTitle();
                            break;

                        case ConsoleKey.U:

                            foreach (KeyValuePair<int, int[,]> pair in piece.moveList)
                            {
                                if (piece.moveList.ContainsKey((dictionaryIndex - 1)) == true)
                                {
                                    piece.pieceValues = (int[,])piece.moveList[(dictionaryIndex - 1)].Clone();
                                }
                            }

                            foreach (KeyValuePair<int, int[]> pair in piece.gameState)
                            {
                                if (piece.gameState.ContainsKey((dictionaryIndex - 1)) == true)
                                {
                                    gameData = (int[])piece.gameState[(dictionaryIndex - 1)].Clone();
                                    playerOneScore = gameData[0];
                                    playerTwoScore = gameData[1];
                                    turn = gameData[2];
                                    player = gameData[3];
                                    movementPositionX = gameData[4];
                                    movementPositionY = gameData[5];
                                }
                            }

                            if (player == 2)
                            {
                                Console.SetCursorPosition(98, 21);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("<██>");
                                Console.SetCursorPosition(98, 10);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("    ");
                            }
                            if (player == 1)
                            {
                                Console.SetCursorPosition(98, 21);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("    ");
                                Console.SetCursorPosition(98, 10);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("<██>");
                            }

                            dictionaryIndex++;
                            piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                            piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                            score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                            score.ScoreUpdater((player + 1), playerOneScore, playerTwoScore);
                            score.ScoreUpdater((player - 1), playerOneScore, playerTwoScore);
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                            break;

                        case ConsoleKey.R:

                            foreach (KeyValuePair<int, int[,]> pair in piece.moveList)
                            {
                                if (piece.moveList.ContainsKey(dictionaryIndex - 1) == true)
                                {
                                    piece.pieceValues = (int[,])piece.moveList[dictionaryIndex - 1].Clone();
                                }
                            }

                            foreach (KeyValuePair<int, int[]> pair in piece.gameState)
                            {
                                if (piece.gameState.ContainsKey(dictionaryIndex - 1) == true)
                                {
                                    gameData = (int[])piece.gameState[dictionaryIndex - 1].Clone();
                                    playerOneScore = gameData[0];
                                    playerTwoScore = gameData[1];
                                    turn = gameData[2];
                                    player = gameData[3];
                                    movementPositionX = gameData[4];
                                    movementPositionY = gameData[5];
                                }
                            }

                            if (player == 2)
                            {
                                Console.SetCursorPosition(98, 21);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("<██>");
                                Console.SetCursorPosition(98, 10);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("    ");
                            }
                            if (player == 1)
                            {
                                Console.SetCursorPosition(98, 21);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("    ");
                                Console.SetCursorPosition(98, 10);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("<██>");
                            }

                            dictionaryIndex++;
                            piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                            piece.gameState.Add((dictionaryIndex), (int[])gameData.Clone());
                            score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                            score.ScoreUpdater((player + 1), playerOneScore, playerTwoScore);
                            score.ScoreUpdater((player - 1), playerOneScore, playerTwoScore);
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                            break;

                        case ConsoleKey.I:

                            foreach (KeyValuePair<int, int[,]> pair in piece.moveList)
                            {
                                piece.pieceValues = (int[,])piece.moveList[pair.Key].Clone();
                                board.ReDrawBoard();
                                piece.SetPieces();

                                replayGameData = (int[])piece.gameState[pair.Key].Clone();
                                playerOneScore = replayGameData[0];
                                playerTwoScore = replayGameData[1];
                                turn = replayGameData[2];
                                player = replayGameData[3];
                                movementPositionX = replayGameData[4];
                                movementPositionY = replayGameData[5];
                                score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                                score.ScoreUpdater((player + 1), playerOneScore, playerTwoScore);
                                score.ScoreUpdater((player - 1), playerOneScore, playerTwoScore);

                                delay.Delay(1);
                            }

                            score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                            score.ScoreUpdater((player + 1), playerOneScore, playerTwoScore);
                            score.ScoreUpdater((player - 1), playerOneScore, playerTwoScore);
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                            break;

                        case ConsoleKey.S:
                            Console.Clear();
                            break;

                        case ConsoleKey.Spacebar:

                            if (holding == 0)
                            {
                                if (piece.pieceValues[movementPositionY, movementPositionX] == 0)
                                {
                                    board.ReDrawBoard();
                                    piece.SetPieces();
                                    Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
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
                                    Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                                }
                            }
                            else if (holding == 1)
                            {
                                if (startingPositionY == movementPositionY && startingPositionX == movementPositionX)
                                {
                                    piece.pieceValues[movementPositionY, movementPositionX] = pieceType;
                                    board.ReDrawBoard();
                                    piece.SetPieces();
                                    Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                                    pieceType = 0;
                                    holding--;
                                    break;
                                }
                                if ((pieceType == piece.pieceValues[movementPositionY, movementPositionX]) || (pieceType == pieceType + 2))
                                {
                                    board.ReDrawBoard();
                                    piece.SetPieces();
                                    Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                                }
                                else if ((pieceType != piece.pieceValues[movementPositionY, movementPositionX]) && (piece.pieceValues[movementPositionY, movementPositionX] != pieceType + 2))
                                {
                                    valid = ValidateNormalMove(piece.pieceValues, player, pieceType, holding, playerOneScore, playerTwoScore, turn, movementPositionX, movementPositionY, startingPositionX, startingPositionY);
                                    validJump = ValidateJumpMove(piece.pieceValues, player, pieceType, holding, playerOneScore, playerTwoScore, turn, movementPositionX, movementPositionY, startingPositionX, startingPositionY);

                                    if (player == 2 && validJump == true)
                                    {
                                        dictionaryIndex++;
                                        playerTwoScore++;
                                        score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                                        if (playerTwoScore == 12)
                                        {
                                            Console.SetCursorPosition(62, 28);
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.Write("PLAYER TWO WINS!");
                                            piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                                            gameData[0] = playerOneScore;
                                            gameData[1] = playerTwoScore;
                                            gameData[2] = turn;
                                            gameData[3] = player;
                                            gameData[4] = movementPositionX;
                                            gameData[5] = movementPositionY;
                                            piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);
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
                                        piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                                        gameData[0] = playerOneScore;
                                        gameData[1] = playerTwoScore;
                                        gameData[2] = turn;
                                        gameData[3] = player;
                                        gameData[4] = movementPositionX;
                                        gameData[5] = movementPositionY;
                                        piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                                    }

                                    else if (player == 2 && valid == true && validJump == false)
                                    {
                                        dictionaryIndex++;
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
                                        piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                                        gameData[0] = playerOneScore;
                                        gameData[1] = playerTwoScore;
                                        gameData[2] = turn;
                                        gameData[3] = player;
                                        gameData[4] = movementPositionX;
                                        gameData[5] = movementPositionY;
                                        piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                                    }

                                    board.ReDrawBoard();
                                    piece.SetPieces();
                                    Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                                }
                            }
                            board.ReDrawBoard();
                            piece.SetPieces();
                            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                            break;
                    }
                }
                else if (player == 1)
                {
                    PickAWhiteMove();

                    valid = false;
                    validJump = false;
                    board.ReDrawBoard();
                    piece.SetPieces();
                    Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                }
            }
        }

        public int[] aiPieceLocationsWhite = new int[2];
        public List<int[]> aiPiecesWhite = new List<int[]>();
        public List<int[]> aiValidMoves = new List<int[]>();
        public List<int[]> aiValidJumpMoves = new List<int[]>();
        public List<int[]> aiValidStartingPositions = new List<int[]>();
        public List<int[]> aiValidJumpStartingPositions = new List<int[]>();
        public List<int[]> removeTakenPiece = new List<int[]>();

        public void PickAWhiteMove()
        {
            Random rnd = new Random();

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    switch (piece.pieceValues[y, x])
                    {
                        case 0:
                            break;
                        case 1:
                            aiPieceLocationsWhite[1] = x;
                            aiPieceLocationsWhite[0] = y;
                            aiPiecesWhite.Add((int[])aiPieceLocationsWhite.Clone());
                            //System.Console.WriteLine("\n----" + aiPieceLocationsWhite[0] + " " + aiPieceLocationsWhite[1]);
                            break;
                        case 2:
                            break;
                        case 3:
                            aiPieceLocationsWhite[1] = x;
                            aiPieceLocationsWhite[0] = y;
                            aiPiecesWhite.Add((int[])aiPieceLocationsWhite.Clone());
                            //System.Console.WriteLine("\n----" + aiPieceLocationsWhite[0] + " " + aiPieceLocationsWhite[1]);
                            break;
                        case 4:
                            break;
                        default:
                            break;

                    }
                }
            }

            foreach (int[] item in aiPiecesWhite)
            {
                int[] temp1 = (int[])item.Clone();

                startingPositionX = item[1];
                startingPositionY = item[0];
                //System.Console.WriteLine("\n---------------" + startingPositionX + " " + startingPositionY);
                //System.Console.WriteLine("- " + piece.pieceValues[startingPositionY, startingPositionX]);

                if ((startingPositionX + 1 == -1) || (startingPositionX + 1 == 8) || (startingPositionX - 1 == -1) || (startingPositionX - 1 == 8) || (startingPositionY + 1 == -1) || (startingPositionY + 1 == 8) || (startingPositionY - 1 == -1) || (startingPositionY - 1 == 8))
                {
                    if ((startingPositionY == 0 && startingPositionX > 0 && startingPositionX < 7) && (piece.pieceValues[(startingPositionY + 1), (startingPositionX + 1)] == 0))
                    {
                        int[] ints2 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidStartingPositions.Add((int[])ints2.Clone());
                        //System.Console.WriteLine("a " + piece.pieceValues[startingPositionY, startingPositionX]);
                        int[] ints = new[] { (startingPositionY + 1), (startingPositionX + 1) };
                        aiValidMoves.Add((int[])ints.Clone());
                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                        Array.Clear(ints2, 0, ints2.Length);
                        Array.Clear(ints, 0, ints.Length);
                    }
                    if ((startingPositionY == 0 && startingPositionX > 0 && startingPositionX <= 7) && (piece.pieceValues[(startingPositionY + 1), (startingPositionX - 1)] == 0))
                    {
                        int[] ints2 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidStartingPositions.Add((int[])ints2.Clone());
                        //System.Console.WriteLine("b " + piece.pieceValues[startingPositionY, startingPositionX]);
                        int[] ints = new[] { (startingPositionY + 1), (startingPositionX - 1) };
                        aiValidMoves.Add((int[])ints.Clone());
                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                        Array.Clear(ints2, 0, ints2.Length);
                        Array.Clear(ints, 0, ints.Length);
                    }
                    if ((startingPositionX == 0 && startingPositionY > 0 && startingPositionY < 7) && (piece.pieceValues[(startingPositionY + 1), (startingPositionX + 1)] == 0))
                    {
                        int[] ints2 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidStartingPositions.Add((int[])ints2.Clone());
                        //System.Console.WriteLine("c " + piece.pieceValues[startingPositionY, startingPositionX]);
                        int[] ints = new[] { (startingPositionY + 1), (startingPositionX + 1) };
                        aiValidMoves.Add((int[])ints.Clone());
                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                        Array.Clear(ints2, 0, ints2.Length);
                        Array.Clear(ints, 0, ints.Length);
                    }
                    if ((startingPositionX == 7 && startingPositionY > 0 && startingPositionY <= 7) && (piece.pieceValues[(startingPositionY + 1), (startingPositionX - 1)] == 0))
                    {
                        int[] ints2 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidStartingPositions.Add((int[])ints2.Clone());
                        //System.Console.WriteLine("d " + piece.pieceValues[startingPositionY, startingPositionX]);
                        int[] ints = new[] { (startingPositionY + 1), (startingPositionX - 1) };
                        aiValidMoves.Add((int[])ints.Clone());
                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                        Array.Clear(ints2, 0, ints2.Length);
                        Array.Clear(ints, 0, ints.Length);
                    }
                    //-------------------------------------------------------------//
                    //-----------------------King Stuff----------------------------//
                    //------------------------------------------------------------//
                    if ((piece.pieceValues[startingPositionY, startingPositionX] == 3) && (startingPositionY == 7 && startingPositionX > 0 && startingPositionX < 7) && (piece.pieceValues[(startingPositionY - 1), (startingPositionX - 1)] == 0))
                    {
                        int[] ints2 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidStartingPositions.Add((int[])ints2.Clone());
                        //System.Console.WriteLine("AAA " + piece.pieceValues[startingPositionY, startingPositionX]);
                        int[] ints = new[] { (startingPositionY - 1), (startingPositionX - 1) };
                        aiValidMoves.Add((int[])ints.Clone());
                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                        Array.Clear(ints2, 0, ints2.Length);
                        Array.Clear(ints, 0, ints.Length);
                    }
                    if ((piece.pieceValues[startingPositionY, startingPositionX] == 3) && (startingPositionY == 7 && startingPositionX > 0 && startingPositionX <= 7) && (piece.pieceValues[(startingPositionY - 1), (startingPositionX + 1)] == 0))
                    {
                        int[] ints2 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidStartingPositions.Add((int[])ints2.Clone());
                        //System.Console.WriteLine("BBB " + piece.pieceValues[startingPositionY, startingPositionX]);
                        int[] ints = new[] { (startingPositionY - 1), (startingPositionX + 1) };
                        aiValidMoves.Add((int[])ints.Clone());
                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                        Array.Clear(ints2, 0, ints2.Length);
                        Array.Clear(ints, 0, ints.Length);
                    }
                    if ((piece.pieceValues[startingPositionY, startingPositionX] == 3) && (startingPositionX > 0 && startingPositionY > 0 && startingPositionY < 7) && (piece.pieceValues[(startingPositionY - 1), (startingPositionX - 1)] == 0))
                    {
                        int[] ints2 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidStartingPositions.Add((int[])ints2.Clone());
                        //System.Console.WriteLine("CCC " + piece.pieceValues[startingPositionY, startingPositionX]);
                        int[] ints = new[] { (startingPositionY - 1), (startingPositionX - 1) };
                        aiValidMoves.Add((int[])ints.Clone());
                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                        Array.Clear(ints2, 0, ints2.Length);
                        Array.Clear(ints, 0, ints.Length);
                    }
                    if ((piece.pieceValues[startingPositionY, startingPositionX] == 3) && (startingPositionX < 7 && startingPositionY > 0 && startingPositionY <= 7) && (piece.pieceValues[(startingPositionY - 1), (startingPositionX + 1)] == 0))
                    {
                        int[] ints2 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidStartingPositions.Add((int[])ints2.Clone());
                        //System.Console.WriteLine("DDD " + piece.pieceValues[startingPositionY, startingPositionX]);
                        int[] ints = new[] { (startingPositionY - 1), (startingPositionX + 1) };
                        aiValidMoves.Add((int[])ints.Clone());
                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                        Array.Clear(ints2, 0, ints2.Length);
                        Array.Clear(ints, 0, ints.Length);
                    }
                }
                else
                {
                    if ((piece.pieceValues[startingPositionY, startingPositionX] == 3) && (piece.pieceValues[startingPositionY - 1, startingPositionX - 1] == 0))
                    {
                        int[] ints3 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidStartingPositions.Add((int[])ints3.Clone());
                        //System.Console.WriteLine("e " + piece.pieceValues[startingPositionY, startingPositionX]);
                        int[] ints1 = new[] { (startingPositionY - 1), (startingPositionX - 1) };
                        aiValidMoves.Add((int[])ints1.Clone());
                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                        Array.Clear(ints3, 0, ints3.Length);
                        Array.Clear(ints1, 0, ints1.Length);
                    }
                    if ((piece.pieceValues[startingPositionY, startingPositionX] == 3) && (piece.pieceValues[startingPositionY - 1, startingPositionX + 1] == 0))
                    {
                        int[] ints3 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidStartingPositions.Add((int[])ints3.Clone());
                        //System.Console.WriteLine("f " + piece.pieceValues[startingPositionY, startingPositionX]);
                        int[] ints1 = new[] { (startingPositionY - 1), (startingPositionX + 1) };
                        aiValidMoves.Add((int[])ints1.Clone());
                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                        Array.Clear(ints3, 0, ints3.Length);
                        Array.Clear(ints1, 0, ints1.Length);
                    }
                    if (((piece.pieceValues[startingPositionY, startingPositionX] == 3) || (piece.pieceValues[startingPositionY, startingPositionX] == 1)) && (piece.pieceValues[(startingPositionY + 1), (startingPositionX + 1)] == 0)) 
                    {
                        int[] ints2 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidStartingPositions.Add((int[])ints2.Clone());
                        //System.Console.WriteLine("g " + piece.pieceValues[startingPositionY, startingPositionX]);
                        int[] ints = new[] { (startingPositionY + 1), (startingPositionX + 1) };
                        aiValidMoves.Add((int[])ints.Clone());
                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                        Array.Clear(ints2, 0, ints2.Length);
                        Array.Clear(ints, 0, ints.Length);
                    }
                    if (((piece.pieceValues[startingPositionY, startingPositionX] == 3) || (piece.pieceValues[startingPositionY, startingPositionX] == 1)) && (piece.pieceValues[startingPositionY + 1, startingPositionX - 1] == 0))
                    {
                        int[] ints3 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidStartingPositions.Add((int[])ints3.Clone());
                        //System.Console.WriteLine("h " + piece.pieceValues[startingPositionY, startingPositionX]);
                        int[] ints1 = new[] { (startingPositionY + 1), (startingPositionX - 1) };
                        aiValidMoves.Add((int[])ints1.Clone());
                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                        Array.Clear(ints3, 0, ints3.Length);
                        Array.Clear(ints1, 0, ints1.Length);
                    }
                }
                Array.Clear(temp1, 0, temp1.Length);
            }

            //-----------------------------------------------------------------------------------------------------------------------//
            //------------------------------------jump stuff-------------------------------------------------------------------------//
            //-----------------------------------------------------------------------------------------------------------------------//

            foreach (int[] item in aiPiecesWhite)
            {
                int[] temp1 = (int[])item.Clone();

                startingPositionX = item[1];
                startingPositionY = item[0];
                //System.Console.WriteLine("\n---------------" + startingPositionX + " " + startingPositionY);

                if ((startingPositionX + 2 == -2) || (startingPositionX + 2 == -1) || (startingPositionX + 2 == 9) || (startingPositionX + 2 == 8) || (startingPositionX - 2 == -2) || (startingPositionX - 2 == -1) || (startingPositionX - 2 == 9) || (startingPositionX - 2 == 8) || (startingPositionY + 2 == -2) || (startingPositionY + 2 == -1) || (startingPositionY + 2 == 9) || (startingPositionY + 2 == 8) || (startingPositionY - 2 == -2) || (startingPositionY - 2 == -1) || (startingPositionY - 2 == 8) || (startingPositionY - 2 == 9))
                //if ((startingPositionX + 1 != 8) || (startingPositionX - 1 != -1)|| (startingPositionY + 1 != 8) || (startingPositionY - 1 != -1))
                {
                    if ((startingPositionY == 0 && startingPositionX >= 0 && startingPositionX < 7) && ((piece.pieceValues[(startingPositionY + 1), (startingPositionX + 1)] == 2) || (piece.pieceValues[(startingPositionY + 1), (startingPositionX + 1)] == 4)) && (piece.pieceValues[(startingPositionY + 2), (startingPositionX + 2)] == 0))
                    {
                        int[] ints1 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidJumpStartingPositions.Add((int[])ints1.Clone());
                        Array.Clear(ints1, 0, ints1.Length);
                        //System.Console.WriteLine("a " + piece.pieceValues[startingPositionY, startingPositionX]);

                        int[] removeTakenPiece1 = new[] { (startingPositionY + 1), (startingPositionX + 1) };
                        removeTakenPiece.Add((int[])removeTakenPiece1.Clone());
                        Array.Clear(removeTakenPiece1, 0, removeTakenPiece1.Length);

                        int[] ints2 = new[] { (startingPositionY + 2), (startingPositionX + 2) };
                        aiValidJumpMoves.Add((int[])ints2.Clone());                                               
                        Array.Clear(ints2, 0, ints2.Length);

                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                    }
                    if ((startingPositionY == 0 && startingPositionX > 1 && startingPositionX <= 7) && ((piece.pieceValues[(startingPositionY + 1), (startingPositionX - 1)] == 2) || (piece.pieceValues[(startingPositionY + 1), (startingPositionX - 1)] == 4)) && (piece.pieceValues[(startingPositionY + 2), (startingPositionX - 2)] == 0))
                    {
                        int[] ints3 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidJumpStartingPositions.Add((int[])ints3.Clone());
                        Array.Clear(ints3, 0, ints3.Length);
                        //System.Console.WriteLine("b " + piece.pieceValues[startingPositionY, startingPositionX]);

                        int[] removeTakenPiece2 = new[] { (startingPositionY + 1), (startingPositionX - 1) };
                        removeTakenPiece.Add((int[])removeTakenPiece2.Clone());
                        Array.Clear(removeTakenPiece2, 0, removeTakenPiece2.Length);

                        int[] ints4 = new[] { (startingPositionY + 2), (startingPositionX - 2) };
                        aiValidJumpMoves.Add((int[])ints4.Clone());                                              
                        Array.Clear(ints4, 0, ints4.Length);

                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                    }
                    if ((startingPositionX == 0 && startingPositionY >= 0 && startingPositionY < 7) && ((piece.pieceValues[(startingPositionY + 1), (startingPositionX + 1)] == 2) || (piece.pieceValues[(startingPositionY + 1), (startingPositionX + 1)] == 4)) && (piece.pieceValues[(startingPositionY + 2), (startingPositionX + 2)] == 0))
                    {
                        int[] ints5 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidJumpStartingPositions.Add((int[])ints5.Clone());
                        Array.Clear(ints5, 0, ints5.Length);
                        //System.Console.WriteLine("c " + piece.pieceValues[startingPositionY, startingPositionX]);

                        int[] removeTakenPiece3 = new[] { (startingPositionY + 1), (startingPositionX + 1) };
                        removeTakenPiece.Add((int[])removeTakenPiece3.Clone());
                        Array.Clear(removeTakenPiece3, 0, removeTakenPiece3.Length);

                        int[] ints6 = new[] { (startingPositionY + 2), (startingPositionX + 2) };
                        aiValidJumpMoves.Add((int[])ints6.Clone());                        
                        Array.Clear(ints6, 0, ints6.Length);

                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);

                    }
                    if ((startingPositionX == 7 && startingPositionY >= 0 && startingPositionY < 6) && ((piece.pieceValues[(startingPositionY + 1), (startingPositionX - 1)] == 2) || (piece.pieceValues[(startingPositionY + 1), (startingPositionX - 1)] == 4)) && (piece.pieceValues[(startingPositionY + 2), (startingPositionX - 2)] == 0))
                    {
                        int[] ints7 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidJumpStartingPositions.Add((int[])ints7.Clone());
                        Array.Clear(ints7, 0, ints7.Length);
                        //System.Console.WriteLine("d " + piece.pieceValues[startingPositionY, startingPositionX]);

                        int[] removeTakenPiece4 = new[] { (startingPositionY + 1), (startingPositionX - 1) };
                        removeTakenPiece.Add((int[])removeTakenPiece4.Clone());
                        Array.Clear(removeTakenPiece4, 0, removeTakenPiece4.Length);

                        int[] ints8 = new[] { (startingPositionY + 2), (startingPositionX - 2) };
                        aiValidJumpMoves.Add((int[])ints8.Clone());
                        Array.Clear(ints8, 0, ints8.Length);

                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                    }
                    //-------------------------------------------------------------//
                    //-----------------------King Stuff----------------------------//
                    //------------------------------------------------------------//
                    if ((piece.pieceValues[startingPositionY, startingPositionX] == 3) && (startingPositionY == 7 && startingPositionX >= 0 && startingPositionX < 7) && ((piece.pieceValues[(startingPositionY - 1), (startingPositionX - 1)] == 2) || (piece.pieceValues[(startingPositionY - 1), (startingPositionX - 1)] == 4)) && (piece.pieceValues[(startingPositionY - 2), (startingPositionX - 2)] == 0))
                    {
                        int[] ints1 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidJumpStartingPositions.Add((int[])ints1.Clone());
                        Array.Clear(ints1, 0, ints1.Length);
                        //System.Console.WriteLine("AAA " + piece.pieceValues[startingPositionY, startingPositionX]);

                        int[] removeTakenPiece1 = new[] { (startingPositionY - 1), (startingPositionX - 1) };
                        removeTakenPiece.Add((int[])removeTakenPiece1.Clone());
                        Array.Clear(removeTakenPiece1, 0, removeTakenPiece1.Length);

                        int[] ints2 = new[] { (startingPositionY - 2), (startingPositionX - 2) };
                        aiValidJumpMoves.Add((int[])ints2.Clone());
                        Array.Clear(ints2, 0, ints2.Length);

                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                    }
                    if ((piece.pieceValues[startingPositionY, startingPositionX] == 3) && (startingPositionY == 7 && startingPositionX > 1 && startingPositionX <= 7) && ((piece.pieceValues[(startingPositionY - 1), (startingPositionX + 1)] == 2) || (piece.pieceValues[(startingPositionY - 1), (startingPositionX + 1)] == 4)) && (piece.pieceValues[(startingPositionY - 2), (startingPositionX + 2)] == 0))
                    {
                        int[] ints3 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidJumpStartingPositions.Add((int[])ints3.Clone());
                        Array.Clear(ints3, 0, ints3.Length);
                        //System.Console.WriteLine("BBB " + piece.pieceValues[startingPositionY, startingPositionX]);

                        int[] removeTakenPiece2 = new[] { (startingPositionY - 1), (startingPositionX + 1) };
                        removeTakenPiece.Add((int[])removeTakenPiece2.Clone());
                        Array.Clear(removeTakenPiece2, 0, removeTakenPiece2.Length);

                        int[] ints4 = new[] { (startingPositionY - 2), (startingPositionX + 2) };
                        aiValidJumpMoves.Add((int[])ints4.Clone());
                        Array.Clear(ints4, 0, ints4.Length);

                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                    }
                    if ((piece.pieceValues[startingPositionY, startingPositionX] == 3) && (startingPositionX == 0 && startingPositionY >= 0 && startingPositionY < 7) && ((piece.pieceValues[(startingPositionY + 1), (startingPositionX + 1)] == 2) || (piece.pieceValues[(startingPositionY + 1), (startingPositionX + 1)] == 4)) && (piece.pieceValues[(startingPositionY + 2), (startingPositionX + 2)] == 0))
                    {
                        int[] ints5 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidJumpStartingPositions.Add((int[])ints5.Clone());
                        Array.Clear(ints5, 0, ints5.Length);
                        //System.Console.WriteLine("CCC " + piece.pieceValues[startingPositionY, startingPositionX]);

                        int[] removeTakenPiece3 = new[] { (startingPositionY + 1), (startingPositionX + 1) };
                        removeTakenPiece.Add((int[])removeTakenPiece3.Clone());
                        Array.Clear(removeTakenPiece3, 0, removeTakenPiece3.Length);

                        int[] ints6 = new[] { (startingPositionY + 2), (startingPositionX + 2) };
                        aiValidJumpMoves.Add((int[])ints6.Clone());
                        Array.Clear(ints6, 0, ints6.Length);

                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);

                    }
                    if ((piece.pieceValues[startingPositionY, startingPositionX] == 3) && (startingPositionX == 7 && startingPositionY >= 0 && startingPositionY < 6) && ((piece.pieceValues[(startingPositionY + 1), (startingPositionX - 1)] == 2) || (piece.pieceValues[(startingPositionY + 1), (startingPositionX - 1)] == 4)) && (piece.pieceValues[(startingPositionY + 2), (startingPositionX - 2)] == 0))
                    {
                        int[] ints7 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidJumpStartingPositions.Add((int[])ints7.Clone());
                        Array.Clear(ints7, 0, ints7.Length);
                        //System.Console.WriteLine("DDD " + piece.pieceValues[startingPositionY, startingPositionX]);

                        int[] removeTakenPiece4 = new[] { (startingPositionY + 1), (startingPositionX - 1) };
                        removeTakenPiece.Add((int[])removeTakenPiece4.Clone());
                        Array.Clear(removeTakenPiece4, 0, removeTakenPiece4.Length);

                        int[] ints8 = new[] { (startingPositionY + 2), (startingPositionX - 2) };
                        aiValidJumpMoves.Add((int[])ints8.Clone());
                        Array.Clear(ints8, 0, ints8.Length);

                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                    }


                }
                else
                {
                    if (((piece.pieceValues[startingPositionY, startingPositionX] == 3) && ((piece.pieceValues[(startingPositionY - 1), (startingPositionX - 1)] == 2) || (piece.pieceValues[(startingPositionY - 1), (startingPositionX - 1)] == 4)) && (piece.pieceValues[(startingPositionY - 2), (startingPositionX - 2)] == 0)))
                    {
                        int[] ints9 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidJumpStartingPositions.Add((int[])ints9.Clone());
                        Array.Clear(ints9, 0, ints9.Length);
                        //System.Console.WriteLine("e " + piece.pieceValues[startingPositionY, startingPositionX]);

                        int[] removeTakenPiece5 = new[] { (startingPositionY - 1), (startingPositionX - 1) };
                        removeTakenPiece.Add((int[])removeTakenPiece5.Clone());
                        Array.Clear(removeTakenPiece5, 0, removeTakenPiece5.Length);

                        int[] ints10 = new[] { (startingPositionY - 2), (startingPositionX - 2) };
                        aiValidJumpMoves.Add((int[])ints10.Clone());
                        Array.Clear(ints10, 0, ints10.Length);

                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                    }
                    if (((piece.pieceValues[startingPositionY, startingPositionX] == 3) && ((piece.pieceValues[(startingPositionY - 1), (startingPositionX + 1)] == 2) || (piece.pieceValues[(startingPositionY - 1), (startingPositionX + 1)] == 4)) && (piece.pieceValues[(startingPositionY - 2), (startingPositionX + 2)] == 0)))
                    {
                        int[] ints11 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidJumpStartingPositions.Add((int[])ints11.Clone());
                        Array.Clear(ints11, 0, ints11.Length);
                        //System.Console.WriteLine("f " + piece.pieceValues[startingPositionY, startingPositionX]);

                        int[] removeTakenPiece6 = new[] { (startingPositionY - 1), (startingPositionX - 1) };
                        removeTakenPiece.Add((int[])removeTakenPiece6.Clone());
                        Array.Clear(removeTakenPiece6, 0, removeTakenPiece6.Length);

                        int[] ints12 = new[] { (startingPositionY - 2), (startingPositionX - 2) };
                        aiValidJumpMoves.Add((int[])ints12.Clone());
                        Array.Clear(ints12, 0, ints12.Length);
                    }
                        if (((piece.pieceValues[startingPositionY, startingPositionX] == 3) || (piece.pieceValues[startingPositionY, startingPositionX] == 1)) && ((piece.pieceValues[(startingPositionY + 1), (startingPositionX + 1)] == 2) || (piece.pieceValues[(startingPositionY + 1), (startingPositionX + 1)] == 4)) && (piece.pieceValues[(startingPositionY + 2), (startingPositionX + 2)] == 0))
                    {
                        int[] ints9 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidJumpStartingPositions.Add((int[])ints9.Clone());
                        Array.Clear(ints9, 0, ints9.Length);
                        //System.Console.WriteLine("g " + piece.pieceValues[startingPositionY, startingPositionX]);

                        int[] removeTakenPiece5 = new[] { (startingPositionY + 1), (startingPositionX + 1) };
                        removeTakenPiece.Add((int[])removeTakenPiece5.Clone());
                        Array.Clear(removeTakenPiece5, 0, removeTakenPiece5.Length);

                        int[] ints10 = new[] { (startingPositionY + 2), (startingPositionX + 2) };
                        aiValidJumpMoves.Add((int[])ints10.Clone());
                        Array.Clear(ints10, 0, ints10.Length);

                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                    }
                    if (((piece.pieceValues[startingPositionY, startingPositionX] == 3) || (piece.pieceValues[startingPositionY, startingPositionX] == 1)) && ((piece.pieceValues[(startingPositionY + 1), (startingPositionX - 1)] == 2) || (piece.pieceValues[(startingPositionY + 1), (startingPositionX - 1)] == 4)) && (piece.pieceValues[(startingPositionY + 2), (startingPositionX - 2)] == 0))
                    {
                        int[] ints11 = new[] { (startingPositionY), (startingPositionX) };
                        aiValidJumpStartingPositions.Add((int[])ints11.Clone());
                        Array.Clear(ints11, 0, ints11.Length);
                        //System.Console.WriteLine("h " + piece.pieceValues[startingPositionY, startingPositionX]);

                        int[] removeTakenPiece6 = new[] { (startingPositionY + 1), (startingPositionX - 1) };
                        removeTakenPiece.Add((int[])removeTakenPiece6.Clone());
                        Array.Clear(removeTakenPiece6, 0, removeTakenPiece6.Length);

                        int[] ints12 = new[] { (startingPositionY + 2), (startingPositionX - 2) };
                        aiValidJumpMoves.Add((int[])ints12.Clone());
                        Array.Clear(ints12, 0, ints12.Length);

                        //System.Console.WriteLine("\n----------------------------" + startingPositionX + " " + startingPositionY);
                    }
                }
                startingPositionX = 0;
                startingPositionY = 0;
                Array.Clear(temp1, 0, temp1.Length);
            }
           
            /*
            foreach (int[] item in aiValidMoves)
            {
                int[] temp2 = (int[])item.Clone();
                int temp111 = temp2[1];
                int temp222 = temp2[0];
                //Console.SetCursorPosition(50, 40);
                System.Console.WriteLine("--------------" + temp111 + " p " + temp222);
                System.Console.WriteLine(" " + piece.pieceValues[temp222, temp111]);
            }
            */

            delay.Delay(1);

            while (valid == false)
            {                                
                if (aiValidMoves.Count == 0 && aiValidJumpMoves.Count == 0)
                {
                    Console.SetCursorPosition(90, 27);
                    System.Console.WriteLine("------VAILD MOVES COUNT HIT ZERO------");
                    player = 2;
                    break;
                }

                if (aiValidJumpMoves.Count == 0)
                {
                    int chosenMove = rnd.Next(aiValidMoves.Count);
                    int[] temp = (int[])aiValidMoves[chosenMove].Clone();
                    movementPositionX = temp[1];
                    movementPositionY = temp[0];
                    int[] temp2 = (int[])aiValidStartingPositions[chosenMove].Clone();
                    startingPositionX = temp2[1];
                    startingPositionY = temp2[0];

                    pieceType = piece.pieceValues[startingPositionY, startingPositionX];
                    //System.Console.WriteLine("\n" + aiValidStartingPositions.Count + " " + aiValidMoves.Count + " - " + chosenMove + " -start- " + temp2[1] + " x " + temp2[0] + " -move- " + temp[1] + " x " + temp[0]);
                    //System.Console.WriteLine("XXX " + piece.pieceValues[startingPositionY, startingPositionX]);
                    if (pieceType == 3)
                    {
                        //System.Console.WriteLine("Z3Z " + piece.pieceValues[startingPositionY, startingPositionX]);
                        //System.Console.WriteLine("\n" + aiValidStartingPositions.Count + " " + aiValidMoves.Count + " - " + chosenMove + " -start- " + temp2[1] + " x " + temp2[0] + " -move- " + temp[1] + " x " + temp[0] + "----" + pieceType);

                        valid = ValidateNormalMove(piece.pieceValues, player, pieceType, holding, playerOneScore, playerTwoScore, turn, movementPositionX, movementPositionY, startingPositionX, startingPositionY);

                        if (player == 1 && valid == true)
                        {
                            dictionaryIndex++;
                            player++;
                            turn++;
                            Console.SetCursorPosition(98, 21);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("<██>");
                            Console.SetCursorPosition(98, 10);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("    ");
                            piece.pieceValues[startingPositionY, startingPositionX] = 0;
                            gameData[0] = playerOneScore;
                            gameData[1] = playerTwoScore;
                            gameData[2] = turn;
                            gameData[3] = player;
                            gameData[4] = movementPositionX;
                            gameData[5] = movementPositionY;
                            piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                            piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                            Array.Clear(temp, 0, temp.Length);
                            Array.Clear(temp2, 0, temp.Length);
                            chosenMove = 0;
                            valid = false;
                            break;
                        }
                        else
                        {
                            valid = false;
                        }
                    }
                    else if (pieceType == 1)
                    {
                        //System.Console.WriteLine("\n" + aiValidStartingPositions.Count + " " + aiValidMoves.Count + " - " + chosenMove + " -start- " + temp2[1] + " x " + temp2[0] + " -move- " + temp[1] + " x " + temp[0]);
                        //System.Console.WriteLine("Y1Y " + piece.pieceValues[startingPositionY, startingPositionX]);
                        valid = ValidateNormalMove(piece.pieceValues, player, pieceType, holding, playerOneScore, playerTwoScore, turn, movementPositionX, movementPositionY, startingPositionX, startingPositionY);

                        if (pieceType == 1 && player == 1 && valid == true)
                        {
                            dictionaryIndex++;
                            player++;
                            turn++;
                            Console.SetCursorPosition(98, 21);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("<██>");
                            Console.SetCursorPosition(98, 10);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("    ");
                            piece.pieceValues[startingPositionY, startingPositionX] = 0;
                            gameData[0] = playerOneScore;
                            gameData[1] = playerTwoScore;
                            gameData[2] = turn;
                            gameData[3] = player;
                            gameData[4] = movementPositionX;
                            gameData[5] = movementPositionY;
                            piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                            piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                            Array.Clear(temp, 0, temp.Length);
                            Array.Clear(temp2, 0, temp.Length);
                            chosenMove = 0;
                            valid = false;
                            break;
                        }
                        else
                        {
                            valid = false;
                        }
                    }
                }

                else if (aiValidJumpMoves.Count > 0)
                {
                    int chosenMove4 = rnd.Next(aiValidJumpMoves.Count);
                    int[] temp4 = (int[])aiValidJumpMoves[chosenMove4].Clone();
                    movementPositionX = temp4[1];
                    movementPositionY = temp4[0];
                    int[] temp5 = (int[])aiValidJumpStartingPositions[chosenMove4].Clone();
                    startingPositionX = temp5[1];
                    startingPositionY = temp5[0];
                    int[] temp6 = (int[])removeTakenPiece[chosenMove4].Clone();
                    int removeX = temp6[1];
                    int removeY = temp6[0];

                    pieceType = piece.pieceValues[startingPositionY, startingPositionX];

                    if (pieceType == 3)
                    {
                        movementPositionX = removeX;
                        movementPositionY = removeY;
                        validJump = ValidateJumpMove(piece.pieceValues, player, pieceType, holding, playerOneScore, playerTwoScore, turn, movementPositionX, movementPositionY, startingPositionX, startingPositionY);
                        movementPositionX = temp4[1];
                        movementPositionY = temp4[0];

                        //System.Console.WriteLine("Z3Z " + piece.pieceValues[startingPositionY, startingPositionX]);

                        if (player == 1 && validJump == true)
                        {
                            dictionaryIndex++;
                            playerOneScore++;
                            score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                            if (playerOneScore == 12)
                            {
                                Console.SetCursorPosition(62, 28);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("PLAYER ONE WINS!");
                                player++;
                                piece.pieceValues[startingPositionY, startingPositionX] = 0;
                                piece.pieceValues[removeY, removeX] = 0;
                                piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                                gameData[0] = playerOneScore;
                                gameData[1] = playerTwoScore;
                                gameData[2] = turn;
                                gameData[3] = player;
                                gameData[4] = movementPositionX;
                                gameData[5] = movementPositionY;
                                piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                                break;
                            }

                            player++;
                            turn++;
                            Console.SetCursorPosition(98, 21);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("<██>");
                            Console.SetCursorPosition(98, 10);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("    ");
                            piece.pieceValues[startingPositionY, startingPositionX] = 0;
                            piece.pieceValues[removeY, removeX] = 0;
                            gameData[0] = playerOneScore;
                            gameData[1] = playerTwoScore;
                            gameData[2] = turn;
                            gameData[3] = player;
                            gameData[4] = movementPositionX;
                            gameData[5] = movementPositionY;
                            piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                            piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                            Array.Clear(temp4, 0, temp4.Length);
                            Array.Clear(temp5, 0, temp4.Length);
                            Array.Clear(temp6, 0, temp4.Length);
                            chosenMove4 = 0;
                            validJump = false;
                            valid = false;
                            break;
                        }
                        else
                        {
                            validJump = false;
                        }
                    }
                    else if (pieceType == 1)
                    {
                        //System.Console.WriteLine("\n" + aiValidJumpStartingPositions.Count + " " + aiValidJumpMoves.Count + " - " + chosenMove4 + " -start- " + temp5[1] + " x " + temp5[0] + " -move- " + temp4[1] + " x " + temp4[0]);
                        movementPositionX = removeX;
                        movementPositionY = removeY;
                        validJump = ValidateJumpMove(piece.pieceValues, player, pieceType, holding, playerOneScore, playerTwoScore, turn, movementPositionX, movementPositionY, startingPositionX, startingPositionY);
                        movementPositionX = temp4[1];
                        movementPositionY = temp4[0];

                        if (player == 1 && validJump == true)
                        {
                            dictionaryIndex++;
                            playerOneScore++;
                            score.ScoreUpdater(player, playerOneScore, playerTwoScore);
                            if (playerOneScore == 12)
                            {
                                Console.SetCursorPosition(62, 28);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("PLAYER ONE WINS!");
                                player++;
                                piece.pieceValues[startingPositionY, startingPositionX] = 0;
                                piece.pieceValues[removeY, removeX] = 0;
                                piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                                gameData[0] = playerOneScore;
                                gameData[1] = playerTwoScore;
                                gameData[2] = turn;
                                gameData[3] = player;
                                gameData[4] = movementPositionX;
                                gameData[5] = movementPositionY;
                                piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                                Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[movementPositionY]);
                                break;
                            }

                            player++;
                            turn++;
                            Console.SetCursorPosition(98, 21);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("<██>");
                            Console.SetCursorPosition(98, 10);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("    ");
                            piece.pieceValues[startingPositionY, startingPositionX] = 0;
                            piece.pieceValues[removeY, removeX] = 0;
                            gameData[0] = playerOneScore;
                            gameData[1] = playerTwoScore;
                            gameData[2] = turn;
                            gameData[3] = player;
                            gameData[4] = movementPositionX;
                            gameData[5] = movementPositionY;
                            piece.gameState.Add(dictionaryIndex, (int[])gameData.Clone());
                            piece.moveList.Add(dictionaryIndex, (int[,])piece.pieceValues.Clone());
                            Array.Clear(temp4, 0, temp4.Length);
                            Array.Clear(temp5, 0, temp4.Length);
                            Array.Clear(temp6, 0, temp4.Length);
                            chosenMove4 = 0;
                            validJump = false;
                            valid = false;
                            break;
                        }
                        else
                        {
                            validJump = false;
                        }
                    }
                }
            }

            board.ReDrawBoard();
            piece.SetPieces();
            Console.SetCursorPosition(piece.piecePositionsX[movementPositionX], piece.piecePositionsY[(movementPositionY)]);

            Array.Clear(aiPieceLocationsWhite, 0, aiPieceLocationsWhite.Length);
            aiPiecesWhite.Clear();
            aiValidMoves.Clear();
            aiValidStartingPositions.Clear();
            aiValidJumpMoves.Clear();
            aiValidJumpStartingPositions.Clear();
            removeTakenPiece.Clear();
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

            foreach (KeyValuePair<int, int[,]> pair in piece.moveList)
            {
                Console.WriteLine(pair.Key);

                int[,] temp = new int[8, 8];

                temp = (int[,])piece.moveList[pair.Key].Clone();

                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        switch (temp[x, y])
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

            foreach (KeyValuePair<int, int[]> pair in piece.gameState)
            {
                int[] temp1 = new int[6];

                temp1 = (int[])piece.gameState[pair.Key].Clone();

                Console.WriteLine(pair.Key + "-" + temp1[0] + "-" + temp1[1] + "-" + temp1[2] + "-" + temp1[3] + "-" + temp1[4] + "-" + temp1[5]);
            }
        }
    }
}

