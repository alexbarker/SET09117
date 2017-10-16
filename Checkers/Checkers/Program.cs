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
            Console.Title = "ConsoleCheckers";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetWindowSize(160, 40);

            Board board = new Board();
            board.DrawBoard();

            // Menu menu = new menu();
            // menu.begin();

            //Console.WriteLine();
            //Console.ReadLine();
        }
    }
}
