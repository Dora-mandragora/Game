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
            int d = (int)'?';
            //потом переместить функцию в основной класс
            if (Check.IsFormatCorrect(args))
            {
                var newGame = new Game(args);
                newGame.Start();
            }        
            else return;           

        }        
        
    }
}
