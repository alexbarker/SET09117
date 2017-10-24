using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Score
    {
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
                Console.SetCursorPosition(104, (i+7));
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

        public void ScoreDisplayer(int player, int score)
        {
            string[] zerozero = new string[]  {"  .oooo.     .oooo.  ",
                                               " d8P'`Y8b   d8P'`Y8b ",
                                               "888    888 888    888",
                                               "888    888 888    888",
                                               "888    888 888    888",
                                               "`88b  d88' `88b  d88'",
                                               " `Y8bd8P'   `Y8bd8P' "};

            string[] zeroone = new string[]   {"  .oooo.       .o    ",
                                               " d8P'`Y8b    o888    ",
                                               "888    888    888    ",
                                               "888    888    888    ",
                                               "888    888    888    ",
                                               "`88b  d88'    888    ",
                                               " `Y8bd8P'    o888o   "};

            string[] zerotwo = new string[]   {"  .oooo.     .oooo.  ",
                                               " d8P'`Y8b  .dP\"\"Y88b ",
                                               "888    888       ]8P'",
                                               "888    888     .d8P' ",
                                               "888    888   .dP'    ",
                                               "`88b  d88' .oP     .o",
                                               " `Y8bd8P'  8888888888"};

            string[] zerothree = new string[] {"  .oooo.     .oooo.  ",
                                               " d8P'`Y8b  .dP\"\"Y88b ",
                                               "888    888       ]8P'",
                                               "888    888     <88b. ",
                                               "888    888      `88b.",
                                               "`88b  d88' o.   .88P ",
                                               " `Y8bd8P'  `8bd88P'  "};

            string[] zerofour = new string[]  {"  .oooo.         .o  ",
                                               " d8P'`Y8b      .d88  ",
                                               "888    888   .d'888  ",
                                               "888    888 .d'  888  ",
                                               "888    888 88ooo888oo",
                                               "`88b  d88'      888  ",
                                               " `Y8bd8P'      o888o "};

            string[] zerofive = new string[]  {"  .oooo.     oooooooo",
                                               " d8P'`Y8b   dP\"\"\"\"\"\"\"",
                                               "888    888 d88888b.  ",
                                               "888    888     `Y88b ",
                                               "888    888       ]88 ",
                                               "`88b  d88' o.   .88P ",
                                               " `Y8bd8P'  `8bd88P'  " };

            string[] zerosix = new string[]   {"  .oooo.       .ooo  ",
                                               " d8P'`Y8b    .88'    ",
                                               "888    888  d88'     ",
                                               "888    888 d888P\"Ybo.",
                                               "888    888 Y88[   ]88",
                                               "`88b  d88' `Y88   88P",
                                               " `Y8bd8P'   `88bod8' "};

            string[] zeroseven = new string[] {"  .oooo.    ooooooooo",
                                               " d8P'`Y8b  d\"\"\"\"\"\"\"8'",
                                               "888    888       .8' ",
                                               "888    888      .8'  ",
                                               "888    888     .8'   ",
                                               "`88b  d88'    .8'    ",
                                               " `Y8bd8P'    .8'     "};

            string[] zeroeight = new string[] {"  .oooo.    .ooooo.  ",
                                               " d8P'`Y8b  d88'   `8.",
                                               "888    888 Y88..  .8'",
                                               "888    888  `88888b. ",
                                               "888    888 .8'  ``88b",
                                               "`88b  d88' `8.   .88P",
                                               " `Y8bd8P'   `boood8' " };

            string[] zeronine = new string[]  {"  .oooo.    .ooooo.  ",
                                               " d8P'`Y8b  888' `Y88.",
                                               "888    888 888    888",
                                               "888    888  `Vbood888",
                                               "888    888       888'",
                                               "`88b  d88'     .88P' ",
                                               " `Y8bd8P'    .oP'    " };

            string[] ten = new string[]       {"     .o     .oooo.   ",
                                               "   o888    d8P'`Y8b  ",
                                               "    888   888    888 ",
                                               "    888   888    888 ",
                                               "    888   888    888 ",
                                               "    888   `88b  d88' ",
                                               "   o888o   `Y8bd8P'  " };

            string[] eleven = new string[]    {"     .o       .o     ",
                                               "   o888     o888     ",
                                               "    888      888     ",
                                               "    888      888     ",
                                               "    888      888     ",
                                               "    888      888     ",
                                               "   o888o    o888o    " };

            string[] twelve = new string[]    {"     .o     .oooo.   ",
                                               "   o888   .dP\"\"Y88b  ",
                                               "    888         ]8P' ",
                                               "    888       .d8P'  ",
                                               "    888     .dP'     ",
                                               "    888   .oP     .o ",
                                               "   o888o  8888888888 " };

            for (int i = 0; i < 7; i++)
                {
                    Console.SetCursorPosition(104, (i + 7));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(zerotwo[i]);
                }

                for (int i = 0; i < 7; i++)
                {
                    Console.SetCursorPosition(104, (i + 18));
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write(zerothree[i]);
                }
        }

        public void ClearScores()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 7));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("                     ");
            }

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 18));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("                     ");
            }
        }

        public void SimulateScores()
        {
            string[] zerozero = new string[]  {"  .oooo.     .oooo.  ",
                                               " d8P'`Y8b   d8P'`Y8b ",
                                               "888    888 888    888",
                                               "888    888 888    888",
                                               "888    888 888    888",
                                               "`88b  d88' `88b  d88'",
                                               " `Y8bd8P'   `Y8bd8P' "};

            string[] zeroone = new string[]   {"  .oooo.       .o    ",
                                               " d8P'`Y8b    o888    ",
                                               "888    888    888    ",
                                               "888    888    888    ",
                                               "888    888    888    ",
                                               "`88b  d88'    888    ",
                                               " `Y8bd8P'    o888o   "};

            string[] zerotwo = new string[]   {"  .oooo.     .oooo.  ",
                                               " d8P'`Y8b  .dP\"\"Y88b ",
                                               "888    888       ]8P'",
                                               "888    888     .d8P' ",
                                               "888    888   .dP'    ",
                                               "`88b  d88' .oP     .o",
                                               " `Y8bd8P'  8888888888"};

            string[] zerothree = new string[] {"  .oooo.     .oooo.  ",
                                               " d8P'`Y8b  .dP\"\"Y88b ",
                                               "888    888       ]8P'",
                                               "888    888     <88b. ",
                                               "888    888      `88b.",
                                               "`88b  d88' o.   .88P ",
                                               " `Y8bd8P'  `8bd88P'  "};

            string[] zerofour = new string[]  {"  .oooo.         .o  ",
                                               " d8P'`Y8b      .d88  ",
                                               "888    888   .d'888  ",
                                               "888    888 .d'  888  ",
                                               "888    888 88ooo888oo",
                                               "`88b  d88'      888  ",
                                               " `Y8bd8P'      o888o "};

            string[] zerofive = new string[]  {"  .oooo.     oooooooo",
                                               " d8P'`Y8b   dP\"\"\"\"\"\"\"",
                                               "888    888 d88888b.  ",
                                               "888    888     `Y88b ",
                                               "888    888       ]88 ",
                                               "`88b  d88' o.   .88P ",
                                               " `Y8bd8P'  `8bd88P'  " };

            string[] zerosix = new string[]   {"  .oooo.       .ooo  ",
                                               " d8P'`Y8b    .88'    ",
                                               "888    888  d88'     ",
                                               "888    888 d888P\"Ybo.",
                                               "888    888 Y88[   ]88",
                                               "`88b  d88' `Y88   88P",
                                               " `Y8bd8P'   `88bod8' "};

            string[] zeroseven = new string[] {"  .oooo.    ooooooooo",
                                               " d8P'`Y8b  d\"\"\"\"\"\"\"8'",
                                               "888    888       .8' ",
                                               "888    888      .8'  ",
                                               "888    888     .8'   ",
                                               "`88b  d88'    .8'    ",
                                               " `Y8bd8P'    .8'     "};

            string[] zeroeight = new string[] {"  .oooo.    .ooooo.  ",
                                               " d8P'`Y8b  d88'   `8.",
                                               "888    888 Y88..  .8'",
                                               "888    888  `88888b. ",
                                               "888    888 .8'  ``88b",
                                               "`88b  d88' `8.   .88P",
                                               " `Y8bd8P'   `boood8' " };

            string[] zeronine = new string[]  {"  .oooo.    .ooooo.  ",
                                               " d8P'`Y8b  888' `Y88.",
                                               "888    888 888    888",
                                               "888    888  `Vbood888",
                                               "888    888       888'",
                                               "`88b  d88'     .88P' ",
                                               " `Y8bd8P'    .oP'    " };

            string[] ten = new string[]       {"     .o     .oooo.   ",
                                               "   o888    d8P'`Y8b  ",
                                               "    888   888    888 ",
                                               "    888   888    888 ",
                                               "    888   888    888 ",
                                               "    888   `88b  d88' ",
                                               "   o888o   `Y8bd8P'  " };

            string[] eleven = new string[]    {"     .o       .o     ",
                                               "   o888     o888     ",
                                               "    888      888     ",
                                               "    888      888     ",
                                               "    888      888     ",
                                               "    888      888     ",
                                               "   o888o    o888o    " };

            string[] twelve = new string[]    {"     .o     .oooo.   ",
                                               "   o888   .dP\"\"Y88b  ",
                                               "    888         ]8P' ",
                                               "    888       .d8P'  ",
                                               "    888     .dP'     ",
                                               "    888   .oP     .o ",
                                               "   o888o  8888888888 " };

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 7));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(zeroone[i]);
            }

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 18));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(zeroone[i]);
            }

            Program delay = new Program();
            delay.Delay(1);

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 7));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(zerotwo[i]);
            }

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 18));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(zerotwo[i]);
            }

            delay.Delay(1);

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 7));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(zerothree[i]);
            }

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 18));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(zerothree[i]);
            }

            delay.Delay(1);

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 7));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(zerofour[i]);
            }

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 18));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(zerofour[i]);
            }

            delay.Delay(1);

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 7));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(zerofive[i]);
            }

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 18));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(zerofive[i]);
            }

            delay.Delay(1);

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 7));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(zerosix[i]);
            }

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 18));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(zerosix[i]);
            }

            delay.Delay(1);

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 7));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(zeroseven[i]);
            }

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 18));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(zeroseven[i]);
            }

            delay.Delay(1);

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 7));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(zeroeight[i]);
            }

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 18));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(zeroeight[i]);
            }

            delay.Delay(1);

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 7));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(zeronine[i]);
            }

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 18));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(zeronine[i]);
            }

            delay.Delay(1);

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 7));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(ten[i]);
            }

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 18));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(ten[i]);
            }

            delay.Delay(1);

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 7));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(eleven[i]);
            }

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 18));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(eleven[i]);
            }

            delay.Delay(1);

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 7));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(twelve[i]);
            }

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(104, (i + 18));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(twelve[i]);
            }
        }
    }
}
