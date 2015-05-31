using BGL_Test_CountofWords.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGL_Test_CountofWords.Classes
{


    public class ParseBookFileResult: IPrime
        
    {
        IPrime prime = null;

        public ParseBookFileResult(IPrime _prime)  // inject the concrete class
        {
            this.prime = _prime;

        }


        public bool IsPrime(int number)
        {
            return prime.IsPrime(count);
        }

        public int count { get; set; }
        public bool isprime { get { return IsPrime(count); } }
    }
}