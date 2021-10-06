using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingProblem
{
    public class Casino
    {
        public void Stake50()
        {
            int One_Day_Stack = 100;
            int Bet = 1;
            int loseStake = 50;
            int wonStake = 150;

            while(One_Day_Stack != loseStake && One_Day_Stack != wonStake)
            {
                Console.WriteLine("User Bet on one Game.");
                Random random = new Random();
                int Bet_Game = random.Next(0, 2);
                if (Bet_Game == 0)
                {
                    One_Day_Stack = One_Day_Stack - Bet;
                    Console.WriteLine("Player Lose the Game and Stake is : " + One_Day_Stack);
                }
                else
                {
                    One_Day_Stack = One_Day_Stack + Bet;
                    Console.WriteLine("Player Win the Game and Stake is : " + One_Day_Stack);
                }
            }
            if(One_Day_Stack == 50)
            {
                Console.WriteLine("User Lose the 50 % stake");
            }
            else { Console.WriteLine("User Won the Extra 50% stake"); }
        }
        public void Bet()
        {
            int One_Day_Stack = 100;
            int Bet = 1;
            int bet_Count = 0;
            int def_Count = 1;
            while (def_Count == 1 && One_Day_Stack > 0)
            {
                Console.Write("Enter the 1.Bet On one Game \t 2.To Exit : ");
                Console.WriteLine("Enter The Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("User Bet on one Game.");
                        Random random = new Random();
                        int Bet_Game = random.Next(0, 2);
                        if (Bet_Game == 0)
                        {
                            One_Day_Stack = One_Day_Stack - Bet;
                            Console.WriteLine("Player Lose the Game and Stake is : " + One_Day_Stack);
                        }
                        else
                        {
                            One_Day_Stack = One_Day_Stack + Bet;
                            Console.WriteLine("Player Win the Game and Stake is : " + One_Day_Stack);
                        }
                        bet_Count++;
                        break;
                    default:
                        Console.WriteLine("Thank You for Playing :)");
                        def_Count++;
                        break;
                }
            }
            Console.WriteLine("Count of Bet is : "+bet_Count);
        }
    }
}
