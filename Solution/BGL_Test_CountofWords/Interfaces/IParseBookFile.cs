using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGL_Test_CountofWords.Interfaces
{
    interface IParseBookFile
    {
        IDictionary<string, int> countWordsInFile(string file);
    }
}
