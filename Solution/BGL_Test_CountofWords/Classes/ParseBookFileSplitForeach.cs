using BGL_Test_CountofWords.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGL_Test_CountofWords.Classes
{
    public class ParseBookFileSplitForeach:IParseBookFile
    {
        private static char[] separators = { ' ' };


        public List<ParseBookFileResult> countWordsInFile(string pathfile)
        {
            //create the parser concrete for prime number checker
            var ConcretePrimeChecker = new PrimeFromArray();

            var wordCounts = new List<ParseBookFileResult>();
            var wordCount = new ParseBookFileResult(ConcretePrimeChecker);

            using (var fileStream = File.Open(pathfile, FileMode.Open, FileAccess.Read))
            using (var streamReader = new StreamReader(fileStream))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in words)
                    {
                       var resultsobj = wordCounts.FirstOrDefault(x => x.word == word.ToString().ToLower());

                        if (resultsobj == null)
                        {
                            wordCount.word = word.ToString().ToLower();
                            wordCount.count = 1;
                            wordCounts.Add(wordCount);
                        }
                        else
                        {
                            resultsobj.count++;
                        }
                    }
                }
            }

            return wordCounts;
        }
       
    }
}
