using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting_Odds_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var blackOrRedParty = new BlackOrRedParty();
            var diceRoll2000 = new DiceRoll2000();

            // Inject desired betting machine into GameRunner
            var gameRunnerA = new GameRunner(blackOrRedParty);
            var gameRunnerB = new GameRunner(diceRoll2000);

            Console.WriteLine("Calculating result...\r\n");

            // Capture the results in an object 
            GameRunnerResult result = gameRunnerA.RunGamesAndReturnResult(100000, 1);

            var stringHandler = new StringHandler();
            
            // Convert the result to string and output to console
            Console.WriteLine(stringHandler.FormatGameResultToString(result) + "\r\n");
        }
    }
}
