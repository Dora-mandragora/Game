using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //пока для проверки
            foreach (var str in args)
                Console.Write(str + ' ');
            if (args.Length < 3) Message.WriteError("There must be more than 3 arguments");
            else if (args.Length % 2 == 0) Message.WriteError("The number of arguments must be odd");
            else if (IsCorrect(args)) ;
            else WriteExamples();

        }        
        
    }
}
