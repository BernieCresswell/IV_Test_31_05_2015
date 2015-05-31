using BGL_Test_CountofWords.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGL_Test_CountofWords.Classes
{
    class ParseBookFileSplitForeach:IParseBookFile
    {
        private static char[] separators = { ' ' };

        public IDictionary<string, int> countWordsInFile(string pathfile)
        {
            var wordCount = new Dictionary<string, int>();
            //do some code
            return wordCount;
        }
    }
}
