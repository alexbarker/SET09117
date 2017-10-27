using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Menu
    {
        public void DrawTitle()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                                                                               40333139 Alex Barker 2017");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                            .oooooo.   oooo                            oooo                                                       ");
            Console.WriteLine("                           d8P'  `Y8b  `888                            `888                                                       ");
            Console.WriteLine("                          888           888 .oo.    .ooooo.   .ooooo.   888  oooo   .ooooo.  oooo d8b  .oooo.o                    ");
            Console.WriteLine("                          888           888P\"Y88b  d88' `88b d88' `\"Y8  888 .8P'   d88' `88b `888\"\"8P d88(  ^8                ");
            Console.WriteLine("                          888           888   888  888ooo888 888        888888.    888ooo888  888     `\"Y88b.                    ");
            Console.WriteLine("                          `88b    ooo   888   888  888    .o 888   .o8  888 `88b.  888    .o  888     o.  )88b                    ");
            Console.WriteLine("                           `Y8bood8P'  o888o o888o `Y8bod8P' `Y8bod8P' o888o o888o `Y8bod8P' d888b    8\"\"888P'                  ");
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                           ╔════════════════════════════════════════════════╗                   ");
            Console.WriteLine("                                           ║                   Main Menu                    ║                   ");
            Console.WriteLine("                                           ╠═════╦══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  1  ║  New Game                                ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  2  ║  Load Game                               ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  3  ║  Tutorial                                ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  4  ║  Quit                                    ║                   ");
            Console.WriteLine("                                           ╚═════╩══════════════════════════════════════════╝                   ");

            Program delay = new Program();
            delay.Delay(2);
            NewGameSelection();
        }

        public void MenuSelection()
        {
            Game startGame = new Game();
            startGame.NewGame();
        }

        public void NewGameSelection()
        {
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                           ╔════════════════════════════════════════════════╗                   ");
            Console.WriteLine("                                           ║                   New Game                     ║                   ");
            Console.WriteLine("                                           ╠═════╦══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  1  ║  Player Vs. Player                       ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  2  ║  Player Vs. Computer (Easy)              ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  3  ║  Player Vs. Computer (Hard)              ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  4  ║  Computer Vs. Computer                   ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  5  ║  Quit                                    ║                   ");
            Console.WriteLine("                                           ╚═════╩══════════════════════════════════════════╝                   ");

            Program delay = new Program();
            delay.Delay(2);
            MenuSelection();
        }
    }
}
