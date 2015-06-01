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

            //these are commented out as proved to be the slower code
            //
            //var ConcreteParserRegex = new ParseBookFileRegex();
            //var ConcreteOutputRegex = new OutputCSV();
            //var ParserRegex = new ParseBookFile(ConcreteParserRegex, ConcreteOutputRegex);
            //var ResultsParserRegex = ParserRegex.countWordsInFile(filepath);
            
            //create the parser concrete for split
            var ConcreteParserSplit = new ParseBookFileSplitForeach();
            var ConcreteOutputSplit = new OutputCSV();
            var ParserSplit = new ParseBookFile(ConcreteParserSplit, ConcreteOutputSplit);
            var ResultsParserSplit = ParserSplit.countWordsInFile(filepath);
            Console.WriteLine("File read");
            ParserSplit.output(ResultsParserSplit);
            Console.WriteLine("CSV file created");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
            
        }


    }

}

    
