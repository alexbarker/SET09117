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
    /// Menu.cs - This file contains the main menu of the application. Displays title screen and menus based on user choice.
    /// </summary> 
    
    class Menu
    {
        /// <summary>
        /// This function will draw the title screen and main menu.
        /// </summary> 
        public void DrawTitle()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Version 0.9.2                                                                                                         Alex Barker - 2017");
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

        /// <summary>
        /// This function will draw the new game menu.
        /// </summary> 
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

        /// <summary>
        /// This function will draw the load game menu.
        /// </summary> 
        public void LoadGameSelection()
        {
            Console.SetCursorPosition(0, 11);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                                                                                ");
            Console.WriteLine("                                           ╔════════════════════════════════════════════════╗                   ");
            Console.WriteLine("                                           ║                   Load Game                    ║                   ");
            Console.WriteLine("                                           ╠═════╦══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  g  ║  Player Vs Player                        ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  h  ║  Player Vs Computer                      ║                   ");
            Console.WriteLine("                                           ╠═════╬══════════════════════════════════════════╣                   ");
            Console.WriteLine("                                           ║  f  ║  Back                                    ║                   ");
            Console.WriteLine("                                           ╚═════╩══════════════════════════════════════════╝                   ");
            Console.WriteLine("                                                                                                                ");
            Console.WriteLine("                                                                                                                ");

            MenuSelection();
        }

        /// <summary>
        /// This function will take the user input and proceed to the relevent function.
        /// </summary> 
        public void MenuSelection()
        {
            while (true)            // Will wait for keypress signal via the keyboard.
            {
                var keyPress = Console.ReadKey(false).Key;
                switch (keyPress)
                {
                    case ConsoleKey.A:                              // "a" will display the new game menu.
                        NewGameSelection();
                        break;

                    case ConsoleKey.B:                              // "b" will call LoadGameSelection() within the Game class.
                        Game loadGame = new Game();
                        LoadGameSelection();
                        break;

                    case ConsoleKey.C:                              // "c" will call startPVPGame.NewPVPGame() within the Game class.
                        Game startPVPGame = new Game();
                        startPVPGame.NewPVPGame();
                        break;

                    case ConsoleKey.D:                              // "d" will call startPVCGame.NewPVCGame() within the Game class.
                        Game startPVCGame = new Game();
                        startPVCGame.NewPVCGame();
                        break;

                    case ConsoleKey.E:                              // "e" will call startCVCGame.NewCVCGame() within the Game class.        
                        Game startCVCGame = new Game();
                        startCVCGame.NewCVCGame();
                        break;

                    case ConsoleKey.F:                              // "f" will clear the console re-draw the main title.
                        Console.Clear();
                        DrawTitle();
                        break;

                    case ConsoleKey.G:                              // "g" will call loadPVPGame.LoadPVPGame() within the Game class.
                        Console.Clear();
                        Game loadPVPGame = new Game();
                        loadPVPGame.LoadPVPGame();
                        break;

                    case ConsoleKey.H:                              // "h" will call loadPVCGame.LoadPVCGame() within the Game class.
                        Console.Clear();
                        Game loadPVCGame = new Game();
                        loadPVCGame.LoadPVCGame();
                        break;

                    case ConsoleKey.Q:                              // "q" Will shut down the application.
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
