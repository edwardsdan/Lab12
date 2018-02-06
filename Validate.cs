using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab12
{
    class Validate
    {
        public static bool Continue()
        {
            while (true)
            {
                Console.WriteLine("Play again? (y/n)");
                string Continue = Console.ReadLine().ToLower();
                if (Regex.IsMatch(Continue, "^(n|no)$"))
                    return false;
                else if (Regex.IsMatch(Continue, "^(y|yes)$"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("I didn't understand that. Try again!");
                    Continue = Console.ReadLine().ToLower();
                }
            }
        }

        public static bool NewOpponent()
        {
            while (true)
            {
                Console.WriteLine("Would you like a new opponent? (y/n)");
                string YorN = Console.ReadLine().ToLower();
                if (Regex.IsMatch(YorN, "^(n|no)$"))
                    return false;
                else if (Regex.IsMatch(YorN, "^(y|yes)$"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("I didn't understand that. Try again!");
                    YorN = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
