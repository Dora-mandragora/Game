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
            if (Check.IsFormatCorrect(args))
            {
                var newGame = new Game(args);
                newGame.Start();
            }        
            else return;        

        }        
        
    }
}
