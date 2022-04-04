using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMain
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardPlayerOne = new Board();
            var boardPlayerTwo = new Board();
                        
            Console.WriteLine("Let the battle begin");

            //boardPlayerOne.CreateBoard();
            //boardPlayerTwo.CreateBoard();      

            boardPlayerOne.DisplayBoard(boardPlayerOne.CreateBoard());
            Console.WriteLine();
            boardPlayerOne.DisplayBoard(boardPlayerTwo.CreateBoard());

            Console.ReadKey();
        }

        public class Board
        {
            public string[,] CreateBoard()
            {
                string[,] board = new string[11,11];
                
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {        
                        board[i, j] = "[ ]";
                    }
                }
                return board;
            }

            public void DisplayBoard(string [,] board)
            {
                string[] letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            board[0, 0] = "  ";
                        }
                        else if (i == 0)
                        {
                            board[0, j] = $" {letters[j - 1]} ";
                        }
                        else if (j == 0)
                        {
                            board[i, 0] = i < 10 ? " " + i.ToString() : i.ToString();
                        }
                        Console.Write(board[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }

        public void ShpisPosition()
        {
            
        }


    }
}
