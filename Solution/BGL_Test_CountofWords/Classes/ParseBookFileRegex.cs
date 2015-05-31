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
        
        
        public IDictionary<string, int> countWordsInFile(string file)
        {
            var wordCount = new Dictionary<string, int>();
            var content = System.IO.File.ReadAllText(file);

            var wordPattern = new Regex(@"\w+");

            foreach (Match match in wordPattern.Matches(content))
            {
                if (!wordCount.ContainsKey(match.Value))
                    wordCount.Add(match.Value, 1);
                else
                    wordCount[match.Value]++;
            }
            return wordCount;
        }
    }
}
