using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class GameRules
    {
        static string[] GameElements = { "rock", "paper", "scissors", "lizard", "Spock" };
        //rock paper scissors lizard Spock
        public static void WriteExamples()
        {
            Message.WriteError("Wrong arguments");
            Console.WriteLine("Try this:");
            Console.WriteLine("rock paper scissors");
            Console.WriteLine("rock paper scissors lizard Spock");
            Console.WriteLine("1 2 3 4 5 7");
        }

        public static bool IsCorrect(string[] args)
        {
            foreach(var str in args) if (GameElements.Contains())
            return true;
        }
    }
}
