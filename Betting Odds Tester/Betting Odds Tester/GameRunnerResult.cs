using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting_Odds_Tester
{
    class GameRunnerResult
    {
        public int NumberOfTests { get; private set; }

        public decimal ProfitAmount { get; private set; }
        public decimal ProfitPercentage { get; private set; }
        
        public string MadeProfit  { get; private set; }

        public GameRunnerResult(int numberOfTests, decimal profitAmount, decimal profitPercentage, string madeProfit)
        {
            NumberOfTests = numberOfTests;
            ProfitAmount = profitAmount;
            ProfitPercentage = profitPercentage;
            MadeProfit = madeProfit;
        }
    }
}
