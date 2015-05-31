using BGL_Test_CountofWords.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGL_Test_CountofWords.Classes
{
 

    public class ParseBookFileSplitForeach : IParseBookFile
    {
        private static char[] separators = { ' ' };


        public Dictionary<string, ParseBookFileResult> countWordsInFile(string pathfile)
        {
            var wordCount = new Dictionary<string, ParseBookFileResult>();
            var ConcretePrimeChecker = new PrimeFromFunction();
            var ParserResult = new ParseBookFileResult(ConcretePrimeChecker);

            using (var fileStream = File.Open(pathfile, FileMode.Open, FileAccess.Read))
            using (var streamReader = new StreamReader(fileStream))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in words)
                    {

                        if (!wordCount.ContainsKey(word.StripPunctuation().ToString().ToLower()))
                        {   
                           ParserResult = new ParseBookFileResult(ConcretePrimeChecker);
                            ParserResult.count = 1;
                            wordCount.Add(word.StripPunctuation().ToString().ToLower(), ParserResult);

                        }
                        else
                            wordCount[word.StripPunctuation().ToString().ToLower()].count++;
                        }
                    }
                }
           

            return wordCount;
        }

       
    }
}
