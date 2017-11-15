using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    /// <summary>
    /// SET09117 2017-8 TR1 001 - Algorithms and Data Structures
    /// Console Checkers
    /// Version 0.9.2
    /// Alexander Barker 
    /// 40333139
    /// Created on 14th October 2017
    /// Last Updated on 15th November 2017
    /// </summary>
    /// <summary>
    /// Piece.cs - This file initalizes the data structures for storing game boards, positions, moves and game states.
    /// </summary>

    public class Piece
    {
        /// <summary>
        /// Initializes normal arrays, multi-dimentional arrays and dictionaries.
        /// </summary>
        public int[,] pieceValues = new int[8, 8];
        public int[] piecePositionsX = { 46, 52, 58, 64, 70, 76, 82, 88 };          // Required X-coordinates to center pieces on each black square.
        public int[] piecePositionsY = { 3, 6, 9, 12, 15, 18, 21, 24 };             // Required Y-coordinates to center pieces on each black square.

        public Dictionary<int, int[,]> moveList = new Dictionary<int, int[,]>();    // The dictionary data structure used to store all moves.
        public Dictionary<int, int[]> gameState = new Dictionary<int, int[]>();     // The dictionary data structure used to store all game states.

        /// <summary>
        /// Populates the 2d array with starting piece data.
        /// 0 - Empty
        /// 1 - White
        /// 2 - Black
        /// 3 - White King
        /// 4 - Black King
        /// </summary>
        public Piece()
        {
            pieceValues = new int[,]{ { 0, 1, 0, 1, 0, 1, 0, 1 },
                                      { 1, 0, 1, 0, 1, 0, 1, 0 },
                                      { 0, 1, 0, 1, 0, 1, 0, 1 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 2, 0, 2, 0, 2, 0, 2, 0 },
                                      { 0, 2, 0, 2, 0, 2, 0, 2 },
                                      { 2, 0, 2, 0, 2, 0, 2, 0 } };
        }

        /// <summary>
        /// This function is used to display the relevant game pieces according to the current game board.
        /// </summary>
        public void SetPieces()
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    switch (pieceValues[y, x])
                    {
                        case 0:
                            break;
                        case 1:
                            Console.SetCursorPosition((piecePositionsX[x]), (piecePositionsY[y]));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("██");
                            break;
                        case 2:
                            Console.SetCursorPosition((piecePositionsX[x]), (piecePositionsY[y]));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("██");
                            break;
                        case 3:
                            Console.SetCursorPosition((piecePositionsX[x]), (piecePositionsY[y]));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("█K");
                            break;
                        case 4:
                            Console.SetCursorPosition((piecePositionsX[x]), (piecePositionsY[y]));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("█K");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
