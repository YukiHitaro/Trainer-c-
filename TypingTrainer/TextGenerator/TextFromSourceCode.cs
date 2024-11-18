using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingTrainer.TextGenerator
{
    /// <summary>
    /// Return parts of the source code of this project itself!
    /// </summary>
    static class TextFromSourceCode
    {
        public static string GetStaticString() => "very random";

        public static string GetRandomNumbers()
        {
            Random rnd = new Random();

            string result = "";
            for (int i = 0; i < rnd.Next(5,15); i++)
            {
                result += rnd.Next(0, 9);
            }

            return result;
        }

        public static string GetPartOfSourceCode(Random rnd)
        {
            string source = System.IO.File.ReadAllText(@"..\..\MainWindowViewModel.cs");
            source = source.Replace("\r", string.Empty);

            var minLines = 1;
            var maxLines = 1; // max is one as long as we cannot support multiple lines in user input field
            var allLines = source.Split('\n').Select(x => x.Trim()).Where(x => x != "");


            // take a few lines from a random location
            var selectedLines = allLines.Skip(rnd.Next(0, allLines.Count() - 10)).Take(rnd.Next(minLines, maxLines));

            var result = string.Join("\n", selectedLines);
            Console.WriteLine(result);
            return result;
        }


    }
}
