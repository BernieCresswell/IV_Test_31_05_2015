using BGL_Test_CountofWords.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGL_Test_CountofWords.Interfaces
{
    interface IParseBookFile
    {
        //List<ParseBookFileResult> countWordsInFile(string file);
        //IDictionary<string, int> countWordsInFile(string file);
        Dictionary<string, ParseBookFileResult> countWordsInFile(string file);
        

    }
}
