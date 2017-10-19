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
            Console.WriteLine("                                                                                                               40333139 Alex Barker 2017");
            Console.WriteLine("\n");
            Console.WriteLine("                            .oooooo.   oooo                            oooo                                                       ");
            Console.WriteLine("                           d8P'  `Y8b  `888                            `888                                                       ");
            Console.WriteLine("                          888           888 .oo.    .ooooo.   .ooooo.   888  oooo   .ooooo.  oooo d8b  .oooo.o                    ");
            Console.WriteLine("                          888           888P\"Y88b  d88' `88b d88' `\"Y8  888 .8P'   d88' `88b `888\"\"8P d88(  ^8                ");
            Console.WriteLine("                          888           888   888  888ooo888 888        888888.    888ooo888  888     `\"Y88b.                    ");
            Console.WriteLine("                          `88b    ooo   888   888  888    .o 888   .o8  888 `88b.  888    .o  888     o.  )88b                    ");
            Console.WriteLine("                           `Y8bood8P'  o888o o888o `Y8bod8P' `Y8bod8P' o888o o888o `Y8bod8P' d888b    8\"\"888P'                  ");
            Console.WriteLine("\n\n");
            Console.WriteLine("                                           ╔════════════════════════════════════════════════╗                   ");
            Console.WriteLine("                                           ║                   Main Menu                    ║                   ");
            Console.WriteLine("                                           ╠═════╦══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  1  ║                                          ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  2  ║                                          ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  3  ║                                          ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  4  ║                                          ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  5  ║                                          ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  6  ║                                          ║                   ");
            Console.WriteLine("                                           ╚═════╩══════════════════════════════════════════╝                   ");

            Program delay = new Program();
            delay.Delay(5);
            MenuSelection();
        }

        public void MenuSelection()
        {
            Game startGame = new Game();
            startGame.NewGame();
        }

        //Console.ReadLine();
    }
}
