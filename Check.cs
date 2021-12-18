using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal static class Check
    {
        public const int QUESTION_MARK = 63; 

        static string[] PossibleElements = { "rock", "paper", "scissors", "lizard", "Spock" };

        public static bool IsMoveCorrect(char move, string[] args) =>
         (move == QUESTION_MARK || (int.Parse(move.ToString()) >= 0 && int.Parse(move.ToString()) <= args.Length));        

        static bool IsCorrectArguments(string[] args) => IsWordCorrect(args) || IsNumber(args);        

        static bool IsWordCorrect(string[] args)
        {
            foreach (var str in args)
                if (PossibleElements.Contains(str)) continue;
                else return false;
            return true;
        }

        static bool IsNumber(string[] args)
        {
            int c = 0;
            foreach (var str in args)
                if (int.TryParse(str, out int n)) c++;
            return c == args.Length;
        }

        public static bool IsStringCorrect(string str)
        {
            if (str == string.Empty) return false;
            if (str[0] == '?') return true;
            else if (int.TryParse(str, out _)) return true;
            else return false;
        }

        public static bool IsFormatCorrect(string[] args)
        {
            if (args.Length != args.Distinct().ToArray().Length) Message.WriteError("There should be no duplicate elements");
            else if (args.Length < 3) Message.WriteError("There must be more than 3 arguments");
            else if (args.Length % 2 == 0) Message.WriteError("The number of arguments must be odd");
            else if (!IsCorrectArguments(args)) GameRules.WriteExamples();
            else return true;
            return false;
        }
    }
}
