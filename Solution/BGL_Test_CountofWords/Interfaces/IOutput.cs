using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGL_Test_CountofWords.Interfaces
{
    interface IOutput
    {
        void Output(Dictionary<string, int> outputDictionary);
    }
}
