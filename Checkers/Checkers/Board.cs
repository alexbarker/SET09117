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
            Console.WriteLine("                         ╔════════════════════════════════════════════════╗                            ");
            Console.WriteLine("                         ║██████      ██████      ██████      ██████      ║                            ");
            Console.WriteLine("                         ║██████      ██████      ██████      ██████      ║                            ");
            Console.WriteLine("                         ║██████      ██████      ██████      ██████      ║                            ");
            Console.WriteLine("                         ║      ██████      ██████      ██████      ██████║                            ");
            Console.WriteLine("                         ║      ██████      ██████      ██████      ██████║                            ");
            Console.WriteLine("                         ║      ██████      ██████      ██████      ██████║                            ");
            Console.WriteLine("                         ║██████      ██████      ██████      ██████      ║                            ");
            Console.WriteLine("                         ║██████      ██████      ██████      ██████      ║                            ");
            Console.WriteLine("                         ║██████      ██████      ██████      ██████      ║                            ");
            Console.WriteLine("                         ║      ██████      ██████      ██████      ██████║                            ");
            Console.WriteLine("                         ║      ██████      ██████      ██████      ██████║                            ");
            Console.WriteLine("                         ║      ██████      ██████      ██████      ██████║                            ");
            Console.WriteLine("                         ║██████      ██████      ██████      ██████      ║                            ");
            Console.WriteLine("                         ║██████      ██████      ██████      ██████      ║                            ");
            Console.WriteLine("                         ║██████      ██████      ██████      ██████      ║                            ");
            Console.WriteLine("                         ║      ██████      ██████      ██████      ██████║                            ");
            Console.WriteLine("                         ║      ██████      ██████      ██████      ██████║                            ");
            Console.WriteLine("                         ║      ██████      ██████      ██████      ██████║                            ");
            Console.WriteLine("                         ║██████      ██████      ██████      ██████      ║                            ");
            Console.WriteLine("                         ║██████      ██████      ██████      ██████      ║                            ");
            Console.WriteLine("                         ║██████      ██████      ██████      ██████      ║                            ");
            Console.WriteLine("                         ║      ██████      ██████      ██████      ██████║                            ");
            Console.WriteLine("                         ║      ██████      ██████      ██████      ██████║                            ");
            Console.WriteLine("                         ║      ██████      ██████      ██████      ██████║                            ");
            Console.WriteLine("                         ╚════════════════════════════════════════════════╝                            ");


            // TO BE MOVED TO PIECE CLASS LATER
            // LONG-FORM-HARD-CODED VERSION
            Console.SetCursorPosition(28, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.SetCursorPosition(29, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("K");

            Console.SetCursorPosition(40, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.SetCursorPosition(41, 2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("K");

            Console.SetCursorPosition(52, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.SetCursorPosition(53, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");

            Console.SetCursorPosition(64, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.SetCursorPosition(65, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");

            Console.SetCursorPosition(34, 5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.SetCursorPosition(35, 5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");

            Console.SetCursorPosition(46, 5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.SetCursorPosition(47, 5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");

            Console.SetCursorPosition(58, 5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.SetCursorPosition(59, 5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");

            Console.SetCursorPosition(70, 5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.SetCursorPosition(71, 5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");

            Console.SetCursorPosition(28, 8);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.SetCursorPosition(29, 8);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");

            Console.SetCursorPosition(40, 8);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.SetCursorPosition(41, 8);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");

            Console.SetCursorPosition(52, 8);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.SetCursorPosition(53, 8);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");

            Console.SetCursorPosition(64, 8);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.SetCursorPosition(65, 8);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");

            //-----------------------------------------------------------------------//

            Console.SetCursorPosition(34, 17);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("█");
            Console.SetCursorPosition(35, 17);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("█");

            Console.SetCursorPosition(46, 17);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("█");
            Console.SetCursorPosition(47, 17);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("█");

            Console.SetCursorPosition(58, 17);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("█");
            Console.SetCursorPosition(59, 17);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("█");

            Console.SetCursorPosition(70, 17);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█");
            Console.SetCursorPosition(71, 17);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█");

            Console.SetCursorPosition(28, 20);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("█");
            Console.SetCursorPosition(29, 20);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("█");

            Console.SetCursorPosition(40, 20);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("█");
            Console.SetCursorPosition(41, 20);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("█");

            Console.SetCursorPosition(52, 20);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("█");
            Console.SetCursorPosition(53, 20);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("█");

            Console.SetCursorPosition(64, 20);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("█");
            Console.SetCursorPosition(65, 20);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("█");

            Console.SetCursorPosition(34, 23);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("█");
            Console.SetCursorPosition(35, 23);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("█");

            Console.SetCursorPosition(46, 23);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("█");
            Console.SetCursorPosition(47, 23);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("K");

            Console.SetCursorPosition(58, 23);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("█");
            Console.SetCursorPosition(59, 23);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("K");

            Console.SetCursorPosition(70, 23);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("█");
            Console.SetCursorPosition(71, 23);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("█");

            //-----------------------------------------------------------------------//
            Console.SetCursorPosition(1, 27);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("");
            Console.ReadLine();
            return;
        }
    }
        

}

