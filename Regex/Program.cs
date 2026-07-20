using System.Text.RegularExpressions;

namespace RegexProject
{

    internal class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"\d{5}";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 123445";

            MatchCollection matchCollection = regex.Matches(text);

            System.Console.WriteLine("Hits found " + matchCollection.Count + " " + text);

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                System.Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }

            ExtractPatterns("Contact us at support@example.com or sales@example.org.");
        }

        public static void ExtractPatterns(string input)
        {
            string pattern = @"\w+(@)\w+\.\w+";
            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(input);
            
            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                System.Console.WriteLine(group[0].Value);
            }
        }
    }
}