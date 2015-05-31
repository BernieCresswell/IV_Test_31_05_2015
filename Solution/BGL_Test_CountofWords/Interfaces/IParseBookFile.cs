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
        List<ParseBookFileResult> countWordsInFile(string file);
    }
}
