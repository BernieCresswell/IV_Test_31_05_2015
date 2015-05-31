using BGL_Test_CountofWords.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGL_Test_CountofWords.Classes
{
    class ParseBookFileResults : IParseBookFile, IOutput, IError
    {

        IParseBookFile parseBook = null;
        IOutput output = null;
        IError error = null;
        

        public ParseBookFileResults(IParseBookFile _ParseBookFile, IOutput _output, IError _error)  // inject the concrete classes
        {
            this.parseBook = _ParseBookFile;
            this.output = _output;
            this.error = _error;
            
        }

        public IDictionary<string, int> countWordsInFile(string file)
        {

            return parseBook.countWordsInFile(file); ;
        }

        public void LogError(string message)
        {// write some code 
        }

        public void Output(Dictionary<string, int> output)
        {// write some code 
        }

        string word { get; set; }
        int count { get; set; }
        bool IsPrime { get; set; }
    }
}