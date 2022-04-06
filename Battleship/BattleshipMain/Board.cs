using System;
using System.Collections.Generic;

namespace BattleshipMain
{
    public class Board
    {
        private const int Size = 10;

        public string[,] Value { get; set; }

        public Board()
        {
            Value = CreateBoard();
        }

        public string[,] CreateBoard()
        {
            string[,] board = new string[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    board[i, j] = "[ ]";
                }
            }
            return board;
        }

        public void DisplayBoard()
        {
            string[] letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

            for (int i = 0; i < Size + 1; i++)
            {
                for (int j = 0; j < Size + 1; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.Write("  ");
                    }
                    else if (i == 0)
                    {
                        Console.Write($" {letters[j - 1]} ");
                    }
                    else if (j == 0)
                    {
                        Console.Write(i < Size ? " " + i.ToString() : i.ToString());
                    }
                    else
                    {
                        Console.Write(Value[i - 1, j - 1]);
                    }
                }
                Console.WriteLine();
            }
        }

        public void PlaceShips()
        {
            var carrier = new Ship(5, "Carrier");
            var battleship = new Ship(4, "Battleship");
            var submarine = new Ship(3, "Submarine");
            var cruiser = new Ship(3, "Cruiser");
            var destroyer = new Ship(2, "Destoryer");

            var ships = new List<Ship>() { carrier, battleship, submarine, cruiser, destroyer };

            foreach (var item in ships)
            {
                bool checkShip = false;

                while (checkShip == false)
                {
                    Random rand = new Random();
                    int startColumn = rand.Next(0, Size);
                    int startRow = rand.Next(0, Size);
                    int orientation = rand.Next(0, 2); //0 - horizontal; 1- vertical                             

                    if (IsPositionValid(startColumn, startRow, orientation, item.Width) == true)
                    {
                        checkShip = true;
                        Console.WriteLine($"{item.Name} {startColumn} {startRow} {orientation}");

                        if (orientation == 0)
                        {
                            for (int i = 0; i < item.Width; i++)
                            {
                                Value[startColumn + i, startRow] = "[s]";
                            }
                        }
                        else
                        {
                            for (int i = 0; i < item.Width; i++)
                            {
                                Value[startColumn, startRow + i] = "[s]";
                            }
                        }
                    }
                }
            }
        }

        public bool IsPositionValid(int startColumn, int startRow, int orientation, int shipWidth)
        {
            if (orientation == 0)
            {
                if (startColumn + shipWidth < Size)
                {
                    return checkSurrounding();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (startRow + shipWidth < Size)
                {
                    return checkSurrounding();
                }
                else
                {
                    return false;
                }
            }

            bool checkSurrounding()
            {
                if (orientation == 0)
                {
                    for (int i = startColumn - 1; i < startColumn - 1 + shipWidth + 2; i++)
                    {
                        for (int j = startRow - 1; j < startRow - 1 + 3; j++)
                        {
                            if ((i >= 0 && j >= 0) && (i < Size && j < Size))
                            {
                                if (Value[i, j] == "[s]")
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int i = startColumn - 1; i < startColumn - 1 + 3; i++)
                    {
                        for (int j = startRow - 1; j < startRow - 1 + shipWidth + 2; j++)
                        {
                            if ((i >= 0 && j >= 0) && (i < Size && j < Size))
                            {
                                if (Value[i, j] == "[s]")
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
                return true;
            }
        }

        public string[,] FireBoard()
        {
            Random rand = new Random();
            int x, y = rand.Next(0, Size);

            string[,] board = new string[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (Value[i, j] == "[$]" || Value[i, j] == "[x]")
                    {
                        
                    }
                    else if(Value[i, j] == "[s]")
                    {
                        Value[i, j] = "[$]";
                    }
                    else
                    {
                        Value[i, j] = "[x]";
                    }
                }
            }

            return Value;
        }
    }
}