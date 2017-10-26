using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Piece
    {
        public int[,] pieceValues = new int[8, 8];
        public int[] piecePositionsX = { 46, 52, 58, 64, 70, 76, 82, 88 };
        public int[] piecePositionsY = { 3, 6, 9, 12, 15, 18, 21, 24 };

        public Piece()
        {
            // Vertical Board
            
            pieceValues = new int[,]{ { 0, 3, 0, 1, 0, 1, 0, 1 },
                                      { 1, 0, 1, 0, 1, 0, 1, 0 },
                                      { 0, 1, 0, 1, 0, 1, 0, 1 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 0, 0, 0, 0, 0, 0, 0, 0 },
                                      { 2, 0, 2, 0, 2, 0, 2, 0 },
                                      { 0, 2, 0, 2, 0, 2, 0, 2 },
                                      { 4, 0, 2, 0, 2, 0, 2, 0 } };
 
            /*
            // Horizontal Board
            pieceValues = new int[,]{ { 0, 1, 0, 0, 0, 2, 0, 4 },
                                      { 3, 0, 1, 0, 0, 0, 2, 0 },
                                      { 0, 1, 0, 0, 0, 2, 0, 2 },
                                      { 1, 0, 1, 0, 0, 0, 2, 0 },
                                      { 0, 1, 0, 0, 0, 2, 0, 2 },
                                      { 1, 0, 1, 0, 0, 0, 2, 0 },
                                      { 0, 1, 0, 0, 0, 2, 0, 2 },
                                      { 1, 0, 1, 0, 0, 0, 2, 0 } };
                                      */
        }

        public void SetPieces()
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    switch (pieceValues[y, x])
                    {
                        case 0:
                            break;
                        case 1:
                            Console.SetCursorPosition((piecePositionsX[x]), (piecePositionsY[y]));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("██");
                            break;
                        case 2:
                            Console.SetCursorPosition((piecePositionsX[x]), (piecePositionsY[y]));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("██");
                            break;
                        case 3:
                            Console.SetCursorPosition((piecePositionsX[x]), (piecePositionsY[y]));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("█K");
                            break;
                        case 4:
                            Console.SetCursorPosition((piecePositionsX[x]), (piecePositionsY[y]));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("█K");
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public void UpdatedPieces()
        {
            Move move = new Move();

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    switch (pieceValues[y, x])
                    {
                        case 0:
                            break;
                        case 1:
                            Console.SetCursorPosition((piecePositionsX[x]), (piecePositionsY[y]));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("██");
                            break;
                        case 2:
                            Console.SetCursorPosition((piecePositionsX[x]), (piecePositionsY[y]));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("██");
                            break;
                        case 3:
                            Console.SetCursorPosition((piecePositionsX[x]), (piecePositionsY[y]));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("█K");
                            break;
                        case 4:
                            Console.SetCursorPosition((piecePositionsX[x]), (piecePositionsY[y]));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("█K");
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        /*
        public void PickUpPiece(int movementPositionX, int movementPositionY)
        {
            Console.SetCursorPosition((piecePositionsX[movementPositionX]), (piecePositionsY[movementPositionY]));
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
        }

        public void DropPiece(int movementPositionX, int movementPositionY, int piecetype1, int holding)
        {
            if (piecetype1 == pieceValues[movementPositionY, movementPositionX])
            {
                return;
            }
            else
            {
                Console.SetCursorPosition((piecePositionsX[movementPositionX]), (piecePositionsY[movementPositionY]));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("██");
            }

        }
        */
    }
}
