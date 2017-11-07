// SET09117 2017-8 TR1 001 - Algorithms and Data Structures
// Console Checkers
// Version 0.6.0
// Alexander Barker 
// 40333139
// Created on 14th October 2017
// Last Updated on 7th Novemeber 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "ConsoleCheckers";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetWindowSize(136, 38);
            Console.Clear();

            Menu menu = new Menu();
            menu.DrawTitle();
        }

        public void Delay(int wait)
        {
            System.Threading.Thread.Sleep(wait * 1000);
        }
    }
}
