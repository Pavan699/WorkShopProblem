using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingProblem
{
    public class Casino
    {

        public void Bet()
        {
            int One_Day_Stack = 100;

            int bet_Count = 0;
            int def_Count = 1;
            while (def_Count == 1)
            {
                Console.Write("Enter the 1.Bet On one Game \t 2.To Exit : ");
                Console.WriteLine("Enter The Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("User Bet on one Game.");
                        One_Day_Stack = One_Day_Stack - 1;
                        Console.WriteLine("Current One Day Stake is : " + One_Day_Stack);
                        bet_Count++;
                        break;
                    default:
                        Console.WriteLine("Wronge Input :)");
                        def_Count++;
                        break;
                }
            }
        }
    }
}
