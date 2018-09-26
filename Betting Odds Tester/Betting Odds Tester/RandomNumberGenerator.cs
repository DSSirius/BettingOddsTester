using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Betting_Odds_Tester
{
    class RandomNumberGenerator
    {
        readonly private Random random;

        public RandomNumberGenerator()
        {
            random = new Random(Guid.NewGuid().GetHashCode());
        }

        public RandomNumberGenerator(int seed)
        {
            random = new Random(seed);
        }

        public int GenerateRandomValue(int range)
        {
            if (range <= 1)
            {
                throw new Exception("Invalid range specified in random number generator. Range needs to be at least higher than 1.");
            }
            
            return random.Next(1, range + 1);
        }
    }
}
