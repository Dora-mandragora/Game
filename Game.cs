using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Game
    {
        string[] Elements;
        GameRules Rules;
        Result Result = new Result();
        Random rnd = new Random();
        public Game(string[] args)
        {
            Elements = args;
            Rules = new GameRules(args);
        }

        public void Start()
        {
            bool ContinueFlag = true;
            while (ContinueFlag)
            {
                var MMove = rnd.Next(0, Elements.Length);
                var hash = new Hash(MMove.ToString());
                Message.WriteMessage("HMAC: ", hash.GetHMAC(MMove.ToString()));
                ShowMenu();
                var input = Console.ReadLine().ToString();
                if (Check.IsStringCorrect(input))
                {                    
                    var UMove = char.Parse(input);
                    if (Check.IsMoveCorrect(UMove, Elements))
                        if (!ExecuteCommand(MMove, UMove)) ContinueFlag = false; else;
                    else continue;
                }
            }
        }                 

        void ShowMenu()
        {
            int number = 1;
            Console.WriteLine("Available moves:");
            foreach (var el in Elements)
                Console.WriteLine("{0} - {1}", number++, el);
            Console.WriteLine("0 - exit");
            Console.WriteLine("? - help");
            Console.Write("Enter your move: ");
        }

        public bool ExecuteCommand(int MMove, int UMove)
        {
            if (UMove == '0') return false;
            if (UMove == Check.QUESTION_MARK) Result.ShowResults();
            else
            {
                Console.WriteLine("Computer move: " + Elements[MMove]);
                Rules.FindWinner(MMove, UMove, Result);
            }
            return true;
        }
    }
}
