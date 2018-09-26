using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting_Odds_Tester
{
    class BlackOrRedParty_NumberToColour
    {
        // Calculate the roulette colour that the ball lands on 
        public int ConvertRandomNumberToGameColour(int randomNumber)
        {
            if (randomNumber < 1 || randomNumber > 62)
            {
                throw new Exception("invalid int assigned to numberGen in BlackOrRedParty.");
            }

            if (randomNumber >= 1 && randomNumber <= 30)
            {
                randomNumber = (int)RouletteColour.black;
            }
            else if (randomNumber >= 31 && randomNumber <= 60)
            {
                randomNumber = (int)RouletteColour.red;
            }
            else if (randomNumber >= 61 && randomNumber <= 62)
            {
                randomNumber = (int)RouletteColour.white;
            }

            return randomNumber;
        }
    }
}
