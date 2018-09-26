using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting_Odds_Tester
{
    class GameRunner
    {
        public BettingMachine BettingMachine { get; private set; }

        private decimal costs;
        private decimal revenue;

        public GameRunner(BettingMachine bettingMachine)
        {
            BettingMachine = bettingMachine;
        }

        public GameRunnerResult RunGamesAndReturnResult(int numberOfGames, decimal stake)
        {
            if (numberOfGames <= 0 || stake <= 0)
            {
                throw new Exception("Invalid number of games or stake specified.");
            }

            revenue = stake * numberOfGames;

            for (int i = 0; i < numberOfGames; i++)
            {
                costs += BettingMachine.RunGame(stake, BettingMachine.GenerateValues());
            }

            bool madeProfit = costs < revenue ? true : false;
            decimal profit = revenue - costs;
            decimal profitPercentage;

            if (madeProfit)
            {
                profitPercentage = profit / revenue * 100;
                Math.Round(profitPercentage, 1);
            }

            else
            {
                profitPercentage = 0;
                profit *= -1;
            }
            
            GameRunnerResult result = new GameRunnerResult(numberOfGames, profit, profitPercentage, madeProfit? "Profit": "Loss");
            return result;
        }
    }
}
