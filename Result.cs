using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Result
    {
        List<string> TableResult = new List<string>();

        public void AddLine(string line)
        {
            TableResult.Add(line);
        }
        public void ShowResults()
        {
            int number = 1;
            Console.WriteLine(new string('-', 15));
            Console.WriteLine("|{0,6}|{1,6}|", "Move", "Res");
            Console.WriteLine(new string('-', 15));
            foreach (var res in TableResult)
                Console.WriteLine(string.Format("|{0,6}|{1,6}|", number++, res));
            Console.WriteLine(new string('-', 15));
        }
    }
}
