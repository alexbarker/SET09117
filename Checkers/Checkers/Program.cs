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
            Console.SetWindowSize(136, 38);

            Menu menu = new Menu();
            menu.DrawTitle();
        }

        public void Delay(int wait)
        {
            System.Threading.Thread.Sleep(wait * 1000);
        }
    }
}
