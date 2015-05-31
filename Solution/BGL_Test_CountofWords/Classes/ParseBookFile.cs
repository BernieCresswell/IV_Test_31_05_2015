using BGL_Test_CountofWords.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BGL_Test_CountofWords.Classes
{
    class ParseBookFile:IParseBookFile, IOutput
    {
         IParseBookFile parseBook = null;
         IOutput outputtype = null;

         private Dictionary<string, ParseBookFileResult> outputDictionary;

         public ParseBookFile(IParseBookFile _ParseBookFile, IOutput _output)  // inject the concrete class
        {
            this.parseBook = _ParseBookFile;
            this.outputtype = _output;
        }

         public ParseBookFile()
         {
             // TODO: Complete member initialization
         }

         public Dictionary<string, ParseBookFileResult> countWordsInFile(string file)
         {
             outputDictionary = parseBook.countWordsInFile(file);
             return outputDictionary;
         }


         public void output(Dictionary<string, ParseBookFileResult> outputfile)
         {
             outputtype.output(outputfile);
         }
    }

    
}
