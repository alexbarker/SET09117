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
    /// Score.cs - This file stores the score designs and returns the required design.
    /// </summary>

    class Score
    {
        /// <summary>
        /// This function is responsible for selecting the required score design based on the current game scores.
        /// </summary>
        /// <param name="player">Sets the current player.</param>
        /// <param name="playerOneScore">Sets the current P1 score.</param>
        /// <param name="playerTwoScore">Sets the current P2 score.</param>
        public void ScoreUpdater(int player, int playerOneScore, int playerTwoScore)
        {

            string[] zero = new string[]  {"  .oooo.     .oooo.  ",     // String array to store each score design.
                                           " d8P'`Y8b   d8P'`Y8b ",
                                           "888    888 888    888",
                                           "888    888 888    888",
                                           "888    888 888    888",
                                           "`88b  d88' `88b  d88'",
                                           " `Y8bd8P'   `Y8bd8P' "};

            string[] one = new string[]   {"  .oooo.       .o    ",
                                           " d8P'`Y8b    o888    ",
                                           "888    888    888    ",
                                           "888    888    888    ",
                                           "888    888    888    ",
                                           "`88b  d88'    888    ",
                                           " `Y8bd8P'    o888o   "};

            string[] two = new string[]   {"  .oooo.     .oooo.  ",
                                           " d8P'`Y8b  .dP\"\"Y88b ",
                                           "888    888       ]8P'",
                                           "888    888     .d8P' ",
                                           "888    888   .dP'    ",
                                           "`88b  d88' .oP     .o",
                                           " `Y8bd8P'  8888888888"};

            string[] three = new string[] {"  .oooo.     .oooo.  ",
                                           " d8P'`Y8b  .dP\"\"Y88b ",
                                           "888    888       ]8P'",
                                           "888    888     <88b. ",
                                           "888    888      `88b.",
                                           "`88b  d88' o.   .88P ",
                                           " `Y8bd8P'  `8bd88P'  "};

            string[] four = new string[]  {"  .oooo.         .o  ",
                                           " d8P'`Y8b      .d88  ",
                                           "888    888   .d'888  ",
                                           "888    888 .d'  888  ",
                                           "888    888 88ooo888oo",
                                           "`88b  d88'      888  ",
                                           " `Y8bd8P'      o888o "};

            string[] five = new string[]  {"  .oooo.     oooooooo",
                                           " d8P'`Y8b   dP\"\"\"\"\"\"\"",
                                           "888    888 d88888b.  ",
                                           "888    888     `Y88b ",
                                           "888    888       ]88 ",
                                           "`88b  d88' o.   .88P ",
                                           " `Y8bd8P'  `8bd88P'  " };

            string[] six = new string[]   {"  .oooo.       .ooo  ",
                                           " d8P'`Y8b    .88'    ",
                                           "888    888  d88'     ",
                                           "888    888 d888P\"Ybo.",
                                           "888    888 Y88[   ]88",
                                           "`88b  d88' `Y88   88P",
                                           " `Y8bd8P'   `88bod8' "};

            string[] seven = new string[] {"  .oooo.    ooooooooo",
                                           " d8P'`Y8b  d\"\"\"\"\"\"\"8'",
                                           "888    888       .8' ",
                                           "888    888      .8'  ",
                                           "888    888     .8'   ",
                                           "`88b  d88'    .8'    ",
                                           " `Y8bd8P'    .8'     "};

            string[] eight = new string[] {"  .oooo.    .ooooo.  ",
                                           " d8P'`Y8b  d88'   `8.",
                                           "888    888 Y88..  .8'",
                                           "888    888  `88888b. ",
                                           "888    888 .8'  ``88b",
                                           "`88b  d88' `8.   .88P",
                                           " `Y8bd8P'   `boood8' " };

            string[] nine = new string[]  {"  .oooo.    .ooooo.  ",
                                           " d8P'`Y8b  888' `Y88.",
                                           "888    888 888    888",
                                           "888    888  `Vbood888",
                                           "888    888       888'",
                                           "`88b  d88'     .88P' ",
                                           " `Y8bd8P'    .oP'    " };

            string[] ten = new string[]   {"     .o     .oooo.   ",
                                           "   o888    d8P'`Y8b  ",
                                           "    888   888    888 ",
                                           "    888   888    888 ",
                                           "    888   888    888 ",
                                           "    888   `88b  d88' ",
                                           "   o888o   `Y8bd8P'  " };

            string[] eleven = new string[]{"     .o       .o     ",
                                           "   o888     o888     ",
                                           "    888      888     ",
                                           "    888      888     ",
                                           "    888      888     ",
                                           "    888      888     ",
                                           "   o888o    o888o    " };

            string[] twelve = new string[]{"     .o     .oooo.   ",
                                           "   o888   .dP\"\"Y88b  ",
                                           "    888         ]8P' ",
                                           "    888       .d8P'  ",
                                           "    888     .dP'     ",
                                           "    888   .oP     .o ",
                                           "   o888o  8888888888 " };
            if (player == 1)
            {
                // Selects and displays the correct score desing based on player one's score.
                switch (playerOneScore)                             
                {
                    case 0:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 7));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(zero[i]);
                        }
                        break;
                    case 1:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 7));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(one[i]);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 7));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(two[i]);
                        }
                        break;
                    case 3:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 7));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(three[i]);
                        }
                        break;
                    case 4:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 7));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(four[i]);
                        }
                        break;
                    case 5:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 7));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(five[i]);
                        }
                        break;
                    case 6:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 7));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(six[i]);
                        }
                        break;
                    case 7:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 7));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(seven[i]);
                        }
                        break;
                    case 8:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 7));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(eight[i]);
                        }
                        break;
                    case 9:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 7));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(nine[i]);
                        }
                        break;
                    case 10:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 7));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(ten[i]);
                        }
                        break;
                    case 11:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 7));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(eleven[i]);
                        }
                        break;
                    case 12:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 7));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(twelve[i]);
                        }
                        break;
                }
            }
            else
            {
                // Selects and displays the correct score desing based on player two's score.
                switch (playerTwoScore)
                {
                    case 0:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 18));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(zero[i]);
                        }
                        break;
                    case 1:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 18));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(one[i]);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 18));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(two[i]);
                        }
                        break;
                    case 3:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 18));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(three[i]);
                        }
                        break;
                    case 4:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 18));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(four[i]);
                        }
                        break;
                    case 5:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 18));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(five[i]);
                        }
                        break;
                    case 6:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 18));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(six[i]);
                        }
                        break;
                    case 7:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 18));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(seven[i]);
                        }
                        break;
                    case 8:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 18));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(eight[i]);
                        }
                        break;
                    case 9:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 18));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(nine[i]);
                        }
                        break;
                    case 10:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 18));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(ten[i]);
                        }
                        break;
                    case 11:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 18));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(eleven[i]);
                        }
                        break;
                    case 12:
                        for (int i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(104, (i + 18));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(twelve[i]);
                        }
                        break;
                }
            }
        }

        // Displays the starting score designs.
        public void SetScores()
        {
            string[] zerozero = new string[] {"  .oooo.     .oooo.  ",
                                              " d8P'`Y8b   d8P'`Y8b ",
                                              "888    888 888    888",
                                              "888    888 888    888",
                                              "888    888 888    888",
                                              "`88b  d88' `88b  d88'",
                                              " `Y8bd8P'   `Y8bd8P' "};

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 7));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(zerozero[i]);
            }

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 18));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(zerozero[i]);
            }
        }
    }
}
