﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class GameRules
    {
        static string[] GameElements = { "rock", "paper", "scissors", "lizard", "Spock" };
        static string[] Numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        //rock paper scissors lizard Spock
        public static void WriteExamples()
        {
            Message.WriteError("Arguments must match the pattern and not be repeated");
            Console.WriteLine("Try this:");
            Console.WriteLine("rock paper scissors");
            Console.WriteLine("rock paper scissors lizard Spock");
            Console.WriteLine("1 2 3 4 5 7");
        }

        public static bool IsCorrect(string[] args)
        {
            foreach (var str in args) 
                if (GameElements.Contains(str)) continue;
                else return false;
            return true;
        }
    }
}
