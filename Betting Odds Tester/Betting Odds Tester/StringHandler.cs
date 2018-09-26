using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting_Odds_Tester
{
    
    class StringHandler
    {
        public string FormatGameResultToString(GameRunnerResult gameResult)
        {
            if (gameResult == null)
            {
                throw new Exception("gameResult cannot be null.");
            }

            string output = string.Format("{0} tests were run; {1}: {2:C}; Profit Percentage: {3:0.0}%", 
                gameResult.NumberOfTests, gameResult.MadeProfit, gameResult.ProfitAmount, gameResult.ProfitPercentage);

            return output;
        }
    }
}
