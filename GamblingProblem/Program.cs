﻿using System;

namespace GamblingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("++++++++++++++++++++Welcome to the Gambling Simulation+++++++++++++++++");
            Casino casino = new Casino();
            casino.Bet();
        }
    }
}
