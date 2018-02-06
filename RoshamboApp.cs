using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab12
{
    public enum Roshambo { rock = 1, paper, scissors };

    class RoshamboApp
    {
        public static Player ChooseOpponent()
        {
            Console.WriteLine("Would you like to play against GrantChirpus or DoctorK? (g/k)");
            string Opponent = Console.ReadLine().ToLower();
            
            while (true)
            {
                if (Regex.IsMatch(Opponent, "^(doctork|k)$"))
                {
                    return new HardMode();
                    //return $"{HardMode.Name}: {HardMode.generateRoshambo()}";
                }
                else if (Regex.IsMatch(Opponent, "^(g|grant|grantchirpus)$"))
                {
                    return new RockDude();
                    //return $"{RockDude.Name}: {RockDude.generateRoshambo()}";
                }
                else
                {
                    Console.WriteLine("That didn't sound like a name! Try again!");
                    Opponent = Console.ReadLine().ToLower();
                }
            }
        }

    }
}
