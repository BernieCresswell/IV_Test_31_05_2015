using BGL_Test_CountofWords.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGL_Test_CountofWords.Classes
{
    class Error:IError
    {
        public void LogError(string message)
        {
            //send an error message to someone
            //inject this later into objects that read file
            throw new NotImplementedException();
        }
    }
}
