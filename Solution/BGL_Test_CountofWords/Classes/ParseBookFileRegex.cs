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


        public Dictionary<string, ParseBookFileResult> countWordsInFile(string file)
        {
            var wordCount = new Dictionary<string, ParseBookFileResult>();

            var ConcretePrimeChecker = new PrimeFromFunction();
            var ParserResult = new ParseBookFileResult(ConcretePrimeChecker);

            var content = System.IO.File.ReadAllText(file);

            var wordPattern = new Regex(@"\w+");

            foreach (Match match in wordPattern.Matches(content))
            {
                if (!wordCount.ContainsKey(match.Value))
                {   ParserResult = new ParseBookFileResult(ConcretePrimeChecker);
                    ParserResult.count = 1;
                    wordCount.Add(match.Value, ParserResult);

                }
                else
                    wordCount[match.Value].count++;
                }
            return wordCount;
        }
    }
}
