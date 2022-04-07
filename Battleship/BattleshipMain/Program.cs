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

            Console.WriteLine();

            int targetCounterOne = 0;
            int targetCounterTwo = 0;

            while (targetCounterOne != 17 || targetCounterTwo != 17)
            {                
                boardPlayerOne.Fire(ref targetCounterOne);

                boardPlayerTwo.Fire(ref targetCounterTwo);
            }

            if (targetCounterOne == 17)
            {
                Console.WriteLine("Player One wins!");
            }
            else
            {
                Console.WriteLine("Player Two wins!");
            }

            Console.WriteLine();

            Console.WriteLine("Player One Board");
            boardPlayerOne.DisplayBoard();
            Console.WriteLine("Player Two Board");
            boardPlayerTwo.DisplayBoard();

            Console.ReadKey();
        } 
    }
}
