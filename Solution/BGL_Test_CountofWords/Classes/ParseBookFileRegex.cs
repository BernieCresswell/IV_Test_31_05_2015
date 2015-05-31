using BGL_Test_CountofWords.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BGL_Test_CountofWords.Classes
{
    public class ParseBookFileRegex:IParseBookFile
    {

        public List<ParseBookFileResult> countWordsInFile(string file)
        {
            //create the parser concrete for prime number checker
            var ConcretePrimeChecker = new PrimeFromFunction();
            var wordCount = new ParseBookFileResult(ConcretePrimeChecker);
            var wordCounts = new List<ParseBookFileResult>();
            var content = System.IO.File.ReadAllText(file);

            var wordPattern = new Regex(@"\w+");

            foreach (Match match in wordPattern.Matches(content))
            {

                var resultobj = wordCounts.FirstOrDefault(x => x.word == match.Value.ToString().ToLower());

                if (resultobj == null)
                {
                    wordCount = new ParseBookFileResult(ConcretePrimeChecker);
                    wordCount.word = match.Value.ToString().ToLower();
                    wordCount.count = 1;
                    wordCounts.Add(wordCount);

                }
                else
                {
                    resultobj.count = resultobj.count + 1;
                }
              
            }
            return wordCounts;
        }

    }
}
