using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting_Odds_Tester
{
    abstract class BettingMachine
    {
        /*  
        This method is based on the concept that all gambling fundementally boils down to comparing two or more values together to see if they match.
        I chose to allow an array to be used in the arguments in order to better integrate future machines that may use more than just two values i.e.
        slot machines etc. 
        */
        public abstract decimal RunGame(decimal stake, params int[] comparableValues);

        public abstract int[] GenerateValues();
    }
}
