// SET09117 2017-8 TR1 001 - Algorithms and Data Structures
// Console Checkers
// Version 0.8.0
// Alexander Barker 
// 40333139
// Created on 14th October 2017
// Last Updated on 12th Novemeber 2017

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
            Console.WriteLine("                                                                                                                                  ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                            .oooooo.   oooo                            oooo                                                       ");
            Console.WriteLine("                           d8P'  `Y8b  `888                            `888                                                       ");
            Console.WriteLine("                          888           888 .oo.    .ooooo.   .ooooo.   888  oooo   .ooooo.  oooo d8b  .oooo.o                    ");
            Console.WriteLine("                          888           888P\"Y88b  d88' `88b d88' `\"Y8  888 .8P'   d88' `88b `888\"\"8P d88(  ^8                ");
            Console.WriteLine("                          888           888   888  888ooo888 888        888888.    888ooo888  888     `\"Y88b.                    ");
            Console.WriteLine("                          `88b    ooo   888   888  888    .o 888   .o8  888 `88b.  888    .o  888     o.  )88b                    ");
            Console.WriteLine("                           `Y8bood8P'  o888o o888o `Y8bod8P' `Y8bod8P' o888o o888o `Y8bod8P' d888b    8\"\"888P'                  ");
            Console.WriteLine("                                                                                                                                  ");
            Console.WriteLine("                                                                                                                                  ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                           ╔════════════════════════════════════════════════╗                   ");
            Console.WriteLine("                                           ║                   Main Menu                    ║                   ");
            Console.WriteLine("                                           ╠═════╦══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  a  ║  New Game                                ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  b  ║  Load Game                               ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  q  ║  Quit                                    ║                   ");
            Console.WriteLine("                                           ╚═════╩══════════════════════════════════════════╝                   ");

            MenuSelection();
        }

        public void NewGameSelection()
        {
            Console.SetCursorPosition(0, 11);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                                                                                ");
            Console.WriteLine("                                           ╔════════════════════════════════════════════════╗                   ");
            Console.WriteLine("                                           ║                   New Game                     ║                   ");
            Console.WriteLine("                                           ╠═════╦══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  c  ║  Player Vs Player                        ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  d  ║  Player Vs Computer                      ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  e  ║  Computer Vs Computer                    ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  f  ║  Back                                    ║                   ");
            Console.WriteLine("                                           ╚═════╩══════════════════════════════════════════╝                   ");

            MenuSelection();
        }

        public void MenuSelection()
        {
            while (true)
            {
                var keyPress = Console.ReadKey(false).Key;
                switch (keyPress)
                {
                    case ConsoleKey.A:
                        NewGameSelection();
                        break;
                    case ConsoleKey.B:
                        Game loadGame = new Game();
                        loadGame.LoadGame();
                        break;

                    case ConsoleKey.C:
                        Game startPVPGame = new Game();
                        startPVPGame.NewPVPGame();
                        break;
                    case ConsoleKey.D:
                        Game startPVCGame = new Game();
                        startPVCGame.NewPVCGame();
                        break;

                    case ConsoleKey.E:
                        Game startCVCGame = new Game();
                        startCVCGame.NewCVCGame();
                        break;

                    case ConsoleKey.F:
                        Console.Clear();
                        Menu menu = new Menu();
                        menu.DrawTitle();
                        break;

                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
