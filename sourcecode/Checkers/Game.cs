using System;
using System.IO;
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
    /// Game.cs - This file will take the users choice from the menu and initialize the coressponding game mode.
    /// </summary>

    class Game
    {
        /// <summary>
        /// This function will set up the required functions for a new player verus player game.
        /// </summary> 
        public void NewPVPGame()
        {
            Board board = new Board();
            board.DrawBoard();                              // Displays the starting board via the Board class.

            Piece piece = new Piece();
            piece.SetPieces();                              // Displays the starting pieces via the Piece class.

            Score scores = new Score();
            scores.SetScores();                             // Displays the starting scores via the Score class.

            Console.SetCursorPosition(46, 18);
            Console.ForegroundColor = ConsoleColor.Black;   // Sets the cursor starting position.

            Move move = new Move();
            move.AllowPVPMovement();                        // Calls the AllowPVPMovement() function via the Move class.

            Console.ReadLine();
        }

        /// <summary>
        /// This function will set up the required functions for a new player versus computer game.
        /// </summary> 
        public void NewPVCGame()
        {
            Board board = new Board();
            board.DrawBoard();

            Piece piece = new Piece();
            piece.SetPieces();

            Score scores = new Score();
            scores.SetScores();

            Console.SetCursorPosition(46, 18);
            Console.ForegroundColor = ConsoleColor.Black;

            Move move = new Move();
            move.AllowPVCMovement();

            Console.ReadLine();
        }

        /// <summary>
        /// This function will set up the required functions for a new computer vs computer game.
        /// </summary> 
        public void NewCVCGame()
        {
            Board board = new Board();
            board.DrawBoard();

            Piece piece = new Piece();
            piece.SetPieces();

            Score scores = new Score();
            scores.SetScores();

            Console.SetCursorPosition(46, 18);
            Console.ForegroundColor = ConsoleColor.Black;

            Move move = new Move();
            move.AllowCVCMovement();

            Console.ReadLine();
        }

        /// <summary>
        /// This function will set up the required functions for a player versus player game based on the current save file.
        /// </summary> 
        public void LoadPVPGame()
        {
            Board board = new Board();
            board.DrawBoard();

            Piece piece = new Piece();
            piece.SetPieces();

            Score scores = new Score();
            scores.SetScores();

            Console.SetCursorPosition(46, 18);
            Console.ForegroundColor = ConsoleColor.Black;

            Move move = new Move();
            move.loadFile = true;
            move.AllowPVPMovement();

            Console.ReadLine();
        }

        /// <summary>
        /// This function will set up the required functions for a player versus computer game based on the current save file.
        /// </summary> 
        public void LoadPVCGame()
        {
            Board board = new Board();
            board.DrawBoard();

            Piece piece = new Piece();
            piece.SetPieces();

            Score scores = new Score();
            scores.SetScores();

            Console.SetCursorPosition(46, 18);
            Console.ForegroundColor = ConsoleColor.Black;

            Move move = new Move();
            move.loadFile = true;
            move.AllowPVCMovement();

            Console.ReadLine();
        }
    }
}
