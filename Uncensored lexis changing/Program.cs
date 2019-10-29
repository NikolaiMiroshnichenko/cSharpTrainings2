using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Uncensored_lexis_changing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string for uncensored lexis cheking");
            string s1 = Console.ReadLine();
            /*string pattern = @"(\w*fuck\w*)(\^*ass)(\^*cunt)(\w*faggot\w*)(\w*shit\w*)(\w*bullshit\w*)";*/
            string pattern = @"\w*fuck\w*|\w*ass\w*|\\w*cunt\w*|\w*faggot\w*|\w*shit\w*|\w*bullshit";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            string s2 = Regex.Replace(s1, pattern, "\"censored\"");
            Console.WriteLine(s2);

            Console.ReadKey();
        }
    }
}
