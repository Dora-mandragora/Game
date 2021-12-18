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
        HelpTable HelpTable;
        Result Result = new Result();
        Random rnd = new Random();
        public Game(string[] args)
        {
            Elements = args;
            Rules = new GameRules(args);
            HelpTable = new HelpTable(args);
        }

        public void Start()
        {
            bool ContinueFlag = true;
            while (ContinueFlag)
            {
                var MMove = rnd.Next(0, Elements.Length);
                var hash = new Hash(MMove.ToString());
                Message.WriteMessage("HMAC: ", hash.GetHMAC());
                ShowMenu();
                var input = Console.ReadLine().ToString();
                if (Check.IsStringCorrect(input))
                {
                    if (char.TryParse(input, out char UMove))
                        if (Check.IsMoveCorrect(UMove, Elements))
                            if (!ExecuteCommand(MMove, UMove, hash)) { ContinueFlag = false; Result.ShowResults(); }
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

        bool ExecuteCommand(int MMove, int UMove, Hash hash)
        {
            if (UMove == '0') return false;
            if (UMove == Check.QUESTION_MARK) HelpTable.ShowTable();
            else
            {
                UMove -= 48;
                Console.WriteLine("Computer move: " + Elements[MMove]);
                Rules.FindWinner(MMove, UMove, hash, Result);
            }
            return true;
        }
    }
}
