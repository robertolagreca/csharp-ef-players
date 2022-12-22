using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityFrameworkPlayers
{
    public static class StaticRandom 
    {
        
        public static int RandNumberGenerator_1_10()
        {
            
            Random random = new Random();
            int numRand = random.Next(1, 11);
            return numRand;
        }

        public static int RandNumberGenerator_1_100()
        {
            Random random = new Random();
            int numRand = random.Next(1, 101);
            return numRand;
        }

        public static int CheckPlayedWon(int n) 
        {
            int y = RandNumberGenerator_1_100();
            if (n < y)
            {
                return n;
            }

            return y;

        }
    }
}
