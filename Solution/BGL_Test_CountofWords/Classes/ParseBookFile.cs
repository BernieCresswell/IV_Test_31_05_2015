using BGL_Test_CountofWords.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BGL_Test_CountofWords.Classes
{
    class ParseBookFile:IParseBookFile
    {
        
         IParseBookFile parseBook = null;

         public ParseBookFile(IParseBookFile _ParseBookFile)  // inject the concrete class
        {
            this.parseBook = _ParseBookFile;
        }

         public ParseBookFile()
         {
             // TODO: Complete member initialization
         }

        public IDictionary<string, int> countWordsInFile(string file)
        {

            return parseBook.countWordsInFile(file); ;
        }
    }

    
}
