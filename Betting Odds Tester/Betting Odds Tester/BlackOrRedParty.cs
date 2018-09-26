using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting_Odds_Tester
{
    public enum RouletteColour { black = 1, red = 2, white = 3 }

    class BlackOrRedParty: BettingMachine
    {
        private readonly int appropriateNumberOfValues = 2;
        private RandomNumberGenerator numberGenerator = new RandomNumberGenerator();
        private readonly BlackOrRedParty_NumberToColour numberToColour = new BlackOrRedParty_NumberToColour();

        public override decimal RunGame(decimal stake, params int[] comparableValues)
        {
            if (comparableValues.Length != appropriateNumberOfValues)
            {
                throw new Exception("invalid action; this game can only take two values.");
            }

            // ball lands on selected colour
            decimal playerWinnings;
            if (comparableValues[0] == comparableValues[1])
            {
                playerWinnings = stake * 2;
            }

            // ball lands on white
            else if (comparableValues[1] == (int)RouletteColour.white)
            {
                playerWinnings = stake / 10;
            }

            // ball lands on other colour
            else
            {
                playerWinnings = 0m;
            }

            return playerWinnings;
        }

        public override int[] GenerateValues()
        {
            int[] values = { numberGenerator.GenerateRandomValue(2),
                numberToColour.ConvertRandomNumberToGameColour(numberGenerator.GenerateRandomValue(62)) };

            return values;
        } 
    }  
}
