using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting_Odds_Tester
{
   class DiceRoll2000: BettingMachine
    {
        private readonly int appropriateNumberOfValues = 2;
        private RandomNumberGenerator numberGenerator = new RandomNumberGenerator();

        public override decimal RunGame(decimal stake, params int[] comparableValues)
        {
            if (comparableValues.Length != appropriateNumberOfValues)
            {
                throw new Exception("invalid action; this game can only take two values.");
            }

            decimal playerWinnings;

            // Both dice match
            if (comparableValues[0] == comparableValues[1])
            {
                playerWinnings = comparableValues[0] * 1.5m;
            }

            else
            {
                playerWinnings = 0m;
            }

            return playerWinnings;
        }

        public override int[] GenerateValues()
        {
            int[] values = { numberGenerator.GenerateRandomValue(6), numberGenerator.GenerateRandomValue(6) };
            return values;
        }
    }
}
