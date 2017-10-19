using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Board
    {
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
            Console.WriteLine("        (p) - Pause                       ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("        (q) - Quit                        ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("                                          ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("                                          ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("          ╔═════════════════════╗         ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("          ║    INSTRUCTIONS     ║         ║       ██████      ██████      ██████      ██████ ║         ╚═════════════════════╝");
            Console.WriteLine("          ╚═════════════════════╝         ║       ██████      ██████      ██████      ██████ ║                                ");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║                PLAYER TWO      ");
            Console.WriteLine("        No game logic implemented yet     ║ ██████      ██████      ██████      ██████       ║         ╔═════════════════════╗");
            Console.WriteLine("        No user input implemented yet     ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("                                          ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
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

            int[] whiteLocationsX = { 44, 56, 68, 80 };
            int[] whiteLocationsY = { 2, 3, 4 };

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.SetCursorPosition((whiteLocationsX[x]), (whiteLocationsY[y]));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("██████");

                    int temp1 = whiteLocationsX[x] + 6;
                    int temp2 = whiteLocationsY[y] + 3;
                    Console.SetCursorPosition((temp1), (temp2));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("██████");

                    Console.SetCursorPosition((whiteLocationsX[x]), (temp2+3));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("██████");

                    Console.SetCursorPosition((temp1), (temp2+6));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("██████");

                    Console.SetCursorPosition((whiteLocationsX[x]), (temp2 + 9));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("██████");

                    Console.SetCursorPosition((temp1), (temp2 + 12));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("██████");

                    Console.SetCursorPosition((whiteLocationsX[x]), (temp2 + 15));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("██████");

                    Console.SetCursorPosition((temp1), (temp2 + 18));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("██████");
                }
            }
            return;
        }
    }
}

