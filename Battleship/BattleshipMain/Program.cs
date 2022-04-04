using System;

namespace BattleshipMain
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardPlayerOne = new Board();
            var boardPlayerTwo = new Board();
                        
            Console.WriteLine("Let the battle begin");

            boardPlayerOne.DisplayBoard();
            Console.WriteLine();
            boardPlayerOne.DisplayBoard();

            boardPlayerOne.PlaceShips();
            boardPlayerOne.DisplayBoard();
            Console.ReadKey();
        } 
    }
}
