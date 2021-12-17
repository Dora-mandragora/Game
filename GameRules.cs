using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class GameRules
    {
        //rock paper scissors lizard Spock
        string[] Elements;
        public GameRules(string[] args)
        {
            Elements = args;
        }
        public static void WriteExamples()
        {
            Message.WriteError("Arguments must match the pattern and not be repeated");
            Console.WriteLine("Try this:");
            Console.WriteLine("rock paper scissors");
            Console.WriteLine("rock paper scissors lizard Spock");
            Console.WriteLine("1 2 3 4 5 6 7");
        }
        
        public void FindWinner(int MMove, int UMove, Result result)
        {
            //TODO рассписать логику работы алгоритма
        }

    }
}
