using BGL_Test_CountofWords.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGL_Test_CountofWords.Classes
{
    public class PrimeFromFunction:IPrime
    {
        public bool IsPrime(int numbertotest)
       {
            int i;
            for (i = 2; i <= numbertotest - 1; i++)
            {
                if (numbertotest % i == 0)
                {
                    return false;
                }
            }
            if (i == numbertotest)
            {
                return true;
            }
            return false;
        }
    
    }
}
