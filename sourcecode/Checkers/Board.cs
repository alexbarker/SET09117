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
    /// Version 1.0.1
    /// Alexander Barker 
    /// 40333139
    /// Created on 14th October 2017
    /// Last Updated on 16th November 2017
    /// </summary>
    /// <summary>
    /// Board.cs - This file will draw a the board design and re-draw squares as required.
    /// </summary>

    public class Board
    {
        /// <summary>
        /// Initializes a multi-dimentional array for re-drawing the board.
        /// </summary>
        public int[,] squares = new int[8, 8];
        Piece piece = new Piece();

        /// <summary>
        /// Populates the 2d array with board design data.
        /// 0 - Black square.
        /// 1 - White square.
        /// </summary>
        public Board()
        {
            squares = new int[,]{ { 0, 1, 0, 1, 0, 1, 0, 1 },
                                  { 1, 0, 1, 0, 1, 0, 1, 0 },
                                  { 0, 1, 0, 1, 0, 1, 0, 1 },
                                  { 1, 0, 1, 0, 1, 0, 1, 0 },
                                  { 0, 1, 0, 1, 0, 1, 0, 1 },
                                  { 1, 0, 1, 0, 1, 0, 1, 0 },
                                  { 0, 1, 0, 1, 0, 1, 0, 1 },
                                  { 1, 0, 1, 0, 1, 0, 1, 0 } };
        }

        /// <summary>
        /// This function draws the design and starting conditions for a game of checkers, including; Ledgend, Instructions, Game Board and Score. 
        /// </summary>
        public void DrawBoard()
        {
            Console.Clear();

            Console.WriteLine("                                                                                                                              ");
            Console.WriteLine("          ╔═════════════════════╗         ╔══════════════════════════════════════════════════╗         ╔═════════════════════╗");
            Console.WriteLine("          ║       LEGEND        ║         ║       ██████      ██████      ██████      ██████ ║         ║        SCORE        ║");
            Console.WriteLine("          ╚═════════════════════╝         ║       ██████      ██████      ██████      ██████ ║         ╚═════════════════════╝");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║                                ");
            Console.WriteLine("        (spacebar) - Pickup & Drop        ║ ██████      ██████      ██████      ██████       ║                PLAYER ONE      ");
            Console.WriteLine("        (u) - Undo Move                   ║ ██████      ██████      ██████      ██████       ║         ╔═════════════════════╗");
            Console.WriteLine("        (r) - Redo Move                   ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("        (s) - Save to File                ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("        (i) - Instant Replay              ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("        (q) - Quit                        ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("                                          ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("          ╔═════════════════════╗         ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("          ║    INSTRUCTIONS     ║         ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("          ╚═════════════════════╝         ║       ██████      ██████      ██████      ██████ ║         ╚═════════════════════╝");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║                                ");
            Console.WriteLine("        - Use the Spacebar to pick up     ║       ██████      ██████      ██████      ██████ ║                PLAYER TWO      ");
            Console.WriteLine("          and drop a piece.               ║ ██████      ██████      ██████      ██████       ║         ╔═════════════════════╗");
            Console.WriteLine("        - Navigate using arrow keys.      ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("        - No multi-jump rule.             ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("        - No force take rule.             ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("        - Score 12 to win!                ║       ██████      ██████      ██████      ██████ ║    <██> ║                     ║");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("          ╔═════════════════════╗         ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("          ║                     ║         ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("          ╚═════════════════════╝         ║ ██████      ██████      ██████      ██████       ║         ╚═════════════════════╝");
            Console.WriteLine("                                          ╚══════════════════════════════════════════════════╝                                ");
            Console.WriteLine("                                                                                                                              ");

            //-----------------------------------------------------------------------//

            Console.ForegroundColor = ConsoleColor.White;                           // Draws the player name and colour for player one.
            Console.SetCursorPosition(104, 5);
            Console.Write("██    PLAYER ONE");

            Console.ForegroundColor = ConsoleColor.DarkCyan;                        // Draws the player name and colour for player two.
            Console.SetCursorPosition(104, 16);
            Console.Write("██    PLAYER TWO");

            //-----------------------------------------------------------------------//

            for (int z = 0; z < 8; z++)                                             // Fills in the white squares to the starting board.
            {
                for (int y = 0; y < 8; y++)
                {
                    switch (squares[z,y])
                    {
                        case 0:
                            for (int x = 0; x < 3; x++)
                            {
                                Console.SetCursorPosition((piece.piecePositionsX[z]-2), ((piece.piecePositionsY[y]-1)+x));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("██████");
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
         return;
        }

        /// <summary>
        /// This function will re-draw black and white square after each move to ensure there are no graphical errors.
        /// </summary>
        public void ReDrawBoard()
        {
            for (int z = 0; z < 8; z++)
            {
                for (int y = 0; y < 8; y++)
                {
                    switch (squares[z, y])
                    {
                        case 0:
                            for (int x = 0; x < 3; x++)
                            {
                                Console.SetCursorPosition((piece.piecePositionsX[z] - 2), ((piece.piecePositionsY[y] - 1) + x));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("██████");                                    // White squares.
                            }
                            break;
                        case 1:
                            for (int x = 0; x < 3; x++)
                            {
                                Console.SetCursorPosition((piece.piecePositionsX[z] - 2), ((piece.piecePositionsY[y] - 1) + x));
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("██████");                                    // Black squares.
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}

