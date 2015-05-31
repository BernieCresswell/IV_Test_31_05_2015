using System;
using NUnit.Framework;
using BGL_Test_CountofWords.Classes; 

namespace BGL_UnitTestProject
{
   // test for ParseBookFileRegex
 

    [TestFixture]
    public class AccountTest
    {
        string filepath = @"C:\BGL_test\The Railway Children [E Nesbit].txt";
            
        [Test]
        public void ParseBookFileRegx()
        {
            var Parser = new ParseBookFileRegex();

            var testresult = Parser.countWordsInFile(filepath);

            Assert.IsNotEmpty(testresult);
            Assert.True(testresult.Count == 5687);
        }

        [Test]
        public void ParseBookFileSpiltForech()
        {
            var Parser = new ParseBookFileSplitForeach();

            var testresult = Parser.countWordsInFile(filepath);

            Assert.IsNotEmpty(testresult);
            Assert.True(testresult.Count == 9614);
        }

    }

   // test for ParseBookFileSplitForEach

   // test for OutputsendToConsole

   // test for OutputsendToCSV

   // test new class to replace dictionaries 

   // test isPrime by math function

   // test isPrime by static predetermined array

   //Add testing of speed to each
}
