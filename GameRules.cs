using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class GameRules
    {
        string[] Elements;
        public enum Option
        {
            Win,
            Lose,
            Draw
        }
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
        
        public void FindWinner(int MMove, int UMove, Hash hash, Result result)
        {
            UMove--;
            var dif = MMove - UMove;
            if (dif == 0) AddAndShowResult(Option.Draw, result);
            else if ((dif <= Elements.Length / 2 && dif > 0) || (dif > -Elements.Length && dif < -Elements.Length / 2))
                AddAndShowResult(Option.Win, result);
            else AddAndShowResult(Option.Lose, result);
            Message.WriteMessage("HMAC key: ", hash.GetKey());          
        }

        public static Option FindWinner(int MMove, int UMove, string[] args)
        {
            var dif = MMove - UMove;
            if (dif == 0) return Option.Draw;
            else if ((dif <= args.Length / 2 && dif > 0) || (dif > -args.Length && dif < -args.Length / 2))
                return Option.Win;
            else return Option.Lose;
        }

        void AddAndShowResult(Option option, Result result)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            result.AddLine(option.ToString());
            if (option == Option.Draw) Console.WriteLine(option.ToString());
            else Console.WriteLine("You {0}!", option.ToString());
            Console.ResetColor();
        }

    }
}
