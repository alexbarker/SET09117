// SET09117 2017-8 TR1 001 - Algorithms and Data Structures
// Console Checkers
// Version 0.8.0
// Alexander Barker 
// 40333139
// Created on 14th October 2017
// Last Updated on 12th Novemeber 2017

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Game
    {
        public void NewPVPGame()
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
            move.AllowPVPMovement();

            Console.ReadLine();
        }

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

            // Insert AI calls stuff here

            Console.ReadLine();
        }

        public void LoadGame()
        {
            Board board = new Board();
            board.DrawBoard();

            Piece piece = new Piece();
            piece.SetPieces();

            Score scores = new Score();
            scores.SetScores();

            Console.SetCursorPosition(46, 18);
            Console.ForegroundColor = ConsoleColor.Black;

            // insert load file code here
            // Move move = new Move();
            // move.LoadGameData();
            // Ask user about game mode at some point


        }
    }
}
