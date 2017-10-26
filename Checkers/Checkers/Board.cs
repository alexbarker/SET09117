using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Board
    {     
        public int[,] whiteSquares = new int[8, 8];

        public Board()
        {
            whiteSquares = new int[,]{ { 0, 1, 0, 1, 0, 1, 0, 1 },
                                       { 1, 0, 1, 0, 1, 0, 1, 0 },
                                       { 0, 1, 0, 1, 0, 1, 0, 1 },
                                       { 1, 0, 1, 0, 1, 0, 1, 0 },
                                       { 0, 1, 0, 1, 0, 1, 0, 1 },
                                       { 1, 0, 1, 0, 1, 0, 1, 0 },
                                       { 0, 1, 0, 1, 0, 1, 0, 1 },
                                       { 1, 0, 1, 0, 1, 0, 1, 0 } };
        }

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
            Console.WriteLine("        (h) - Hint                        ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("        (s) - Save                        ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("        (q) - Quit                        ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("                                          ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("                                          ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("          ╔═════════════════════╗         ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("          ║    INSTRUCTIONS     ║         ║       ██████      ██████      ██████      ██████ ║         ╚═════════════════════╝");
            Console.WriteLine("          ╚═════════════════════╝         ║       ██████      ██████      ██████      ██████ ║                                ");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║                PLAYER TWO      ");
            Console.WriteLine("        Use the Spacebar to pick up       ║ ██████      ██████      ██████      ██████       ║         ╔═════════════════════╗");
            Console.WriteLine("        a piece.                          ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("        Navigate using the arrow keys.    ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("                                          ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("                                          ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("                                          ║ ██████      ██████      ██████      ██████       ║         ╚═════════════════════╝");
            Console.WriteLine("                                          ╚══════════════════════════════════════════════════╝                                ");
            Console.WriteLine("                                                                                                                              ");

            //-----------------------------------------------------------------------//

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(104, 5);
            Console.Write("██    PLAYER ONE");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(104, 16);
            Console.Write("██    PLAYER TWO");

            //-----------------------------------------------------------------------//

            Piece piece = new Piece();

            for (int z = 0; z < 8; z++)
            {
                for (int y = 0; y < 8; y++)
                {
                    switch (whiteSquares[z,y])
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

        public void ReDrawBoard()
        {
            Piece piece = new Piece();

            for (int z = 0; z < 8; z++)
            {
                for (int y = 0; y < 8; y++)
                {
                    switch (whiteSquares[z, y])
                    {
                        case 0:
                            for (int x = 0; x < 3; x++)
                            {
                                Console.SetCursorPosition((piece.piecePositionsX[z] - 2), ((piece.piecePositionsY[y] - 1) + x));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("██████");
                            }
                            break;
                        case 1:
                            for (int x = 0; x < 3; x++)
                            {
                                Console.SetCursorPosition((piece.piecePositionsX[z] - 2), ((piece.piecePositionsY[y] - 1) + x));
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("██████");
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

