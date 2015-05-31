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
        
       
        public IDictionary<string, int> countWordsInFile(string pathfile)
        {
            var wordCount = new Dictionary<string, int>();

            using (var fileStream = File.Open(pathfile, FileMode.Open, FileAccess.Read))
            using (var streamReader = new StreamReader(fileStream))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in words)
                    {
                        if (wordCount.ContainsKey(word.ToLower()))
                        {
                            wordCount[word.ToLower()] = wordCount[word.ToLower()] + 1;
                        }
                        else
                        {
                            wordCount.Add(word.ToLower(), 1);
                        }
                    }
                }
            }

            return wordCount;
        }
       
    }
}
