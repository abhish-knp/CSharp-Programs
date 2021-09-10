﻿using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "csharp";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                    {
                        Console.Write("Enter guess: ");
                        guess = Console.ReadLine();
                        guessCount++;
                    }
                else
                {
                    outOfGuesses = true;
                }
            }

            if (outOfGuesses)
            {
                Console.Write("You Lose! (Out of Guesses.)");
            }
            else
            {
                Console.Write("You Win!");
            }
            

            Console.ReadLine();
        }
    }
}
