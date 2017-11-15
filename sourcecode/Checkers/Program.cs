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
    /// Program.cs - This file initializes the program window design and calls for the main menu.
    /// </summary>

    internal class Program
    {
        /// <summary>
        /// Program.cs - This file initializes the program window design and calls for the main menu.
        /// </summary>
        
        /// <param name="args">Starting point of the application.</param>
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "ConsoleCheckers";              // Sets the name of the application in the title bar.
            Console.BackgroundColor = ConsoleColor.Gray;    // Sets the colour of the application background.
            Console.ForegroundColor = ConsoleColor.Black;   // Sets the initial text colour.
            Console.SetWindowSize(136, 38);                 // Sets the application window size.
            Console.Clear();    

            Menu menu = new Menu();
            menu.DrawTitle();
        }

        /// <summary>
        /// This function is responsible for selecting the required score design based on the current game scores.
        /// </summary>
        /// <param name="wait">Stores the time parameter *100 for milliseconds</param>
        public void Delay(int wait)
        {
            System.Threading.Thread.Sleep(wait * 100);
        }
    }
}
