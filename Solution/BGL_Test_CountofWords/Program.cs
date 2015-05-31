using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using BGL_Test_CountofWords.Classes;
namespace BGL_Test_CountofWords
{
    class BGL_Test_Program
    {
        static void Main(string[] args)
        {
            var filepath = @"C:\BGL_test\The Railway Children [E Nesbit].txt";

            //call some classes
            // do somestuff

            //create the parser concrete for regex
            var ConcreteParserRegex = new ParseBookFileRegex();
            var ParserRegex = new ParseBookFile(ConcreteParserRegex);
            var ResultsParserRegex = ParserRegex.countWordsInFile(filepath);
            
            //create the parser concrete for split
            var ConcreteParserSplit = new ParseBookFileSplitForeach();
            var ParserSplit = new ParseBookFile(ConcreteParserSplit);
            var ResultsParserSplit = ParserSplit.countWordsInFile(filepath);
        }


    }

}

    
