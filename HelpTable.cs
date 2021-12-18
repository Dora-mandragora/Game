using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class HelpTable
    {
        string[,] Table;
        string[] Elements;
        public HelpTable(string[] args)
        {
            Table = new string[args.Length, args.Length];
            Elements = args;
            FillTable();
        }

        void FillTable()
        {
            for (int i = 0; i < Elements.Length; i++)
                for (int j = 0; j < Elements.Length; j++)
                    Table[i,j] = GameRules.FindWinner(i, j, Elements).ToString();
        }

        public void ShowTable()
        {
            var size = 8 * (Elements.Length+2);
            Console.WriteLine(new string('-', size));
            Console.Write("|{0,8}",' ');
            foreach (var el in Elements)
                Console.Write("|{0,8}", el);
            Console.WriteLine("|");
            Console.WriteLine(new string('-', size));
            for (int i = 0; i < Elements.Length; i++)
            {
                Console.Write("|{0,8}", Elements[i]);
                for (int j = 0; j < Elements.Length; j++)
                    Console.Write("|{0,8}", Table[i, j]);
                Console.WriteLine("|");
            }
            Console.WriteLine(new string('-', size));
        }
    }
}
