using BGL_Test_CountofWords.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGL_Test_CountofWords.Classes
{
    class OutputCSV:IOutput
    {
        
        
        public void output(Dictionary<string, ParseBookFileResult>  result)
        {
            StreamWriter writetext = new StreamWriter("write.txt", false);
            StringBuilder builder;

            var Parser = new ParseBookFileSplitForeach();

            foreach (var pair in result)
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
