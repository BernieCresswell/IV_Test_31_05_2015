using System;
using NUnit.Framework;
using BGL_Test_CountofWords.Classes;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;

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

        [Test]
        public void IsPrimeByFunction()
        {
            int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 };

            var Tester = new PrimeFromFunction();
            for (int i = 2; i <= 32; i++)
            {
                var testresult = Tester.IsPrime(i);
                if (testresult)
                {
                    if (!primes.Contains(i))
                    {
                        Assert.True(false);
                    }
                }

            }

        }

        [Test]
        public void IsPrimeByStaticArray()
        {
           
            var Tester = new PrimeFromFunction();
            for (int i = 2; i <= 32; i++)
            {
                var testresult = PrimeArray.primes.Contains(i);
               //TODO:not sure yet to write a sensible test for this

            }

        }
        [Test]
        public void WriteToFile()
        {

            StreamWriter writetext = new StreamWriter("write.txt", false);
            StringBuilder builder;
            
            var Parser = new ParseBookFileSplitForeach();

            var testresult = Parser.countWordsInFile(filepath);

            foreach (var pair in testresult)
            {
                builder = new StringBuilder();
                builder.Append(pair.Key);
                builder.Append(",");
                builder.Append(pair.Value.count);
                builder.Append(",");
                builder.Append(pair.Value.isprime);
                writetext.WriteLine(builder);

            }


            writetext.Close();

        }
       
    }
}
  
   // test for OutputsendToConsole

   // test for OutputsendToCSV

  

   //Add testing of speed to each

