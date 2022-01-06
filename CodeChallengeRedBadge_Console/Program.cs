using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeChallengeRedBadge_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Challenge 1
            
            String[] strings = new string[4] {"abc", "abc", "df", "kjl" };

            strings.Distinct().ToList().ForEach(s => Console.WriteLine(s));
            Console.ReadKey();
            



            //Challenge 2

            Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>\b");

            string text = "there once was a tree in a valley";

            MatchCollection matches = rx.Matches(text);

            Console.WriteLine("{0} matches found in:\n   {1}",
                matches.Count,
                text);

            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;
                Console.WriteLine("'{0}' repeated at positions {1} and {2}",
                    groups["word"].Value,
                    groups[0].Index,
                    groups[1].Index);
            }

        }
    }
}
