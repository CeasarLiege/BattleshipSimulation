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

            Console.WriteLine("Player One");

            boardPlayerOne.PlaceShips();
            boardPlayerOne.DisplayBoard();

            Console.WriteLine();

            Console.WriteLine("Player Two");

            boardPlayerTwo.PlaceShips();
            boardPlayerTwo.DisplayBoard();
            
            boardPlayerOne.FireBoard();
            boardPlayerTwo.FireBoard();

            boardPlayerOne.DisplayBoard();
            boardPlayerTwo.DisplayBoard();
            Console.ReadKey();
        } 
    }
}
