using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Message
    {
        public static void WriteError(string err)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERR: ");
            Console.ResetColor();
            Console.WriteLine(err);

        }

        public static void WriteMessage(string title, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(title);
            Console.ResetColor();
            Console.WriteLine(msg);

        }
    }
}
