using System;
using System.Collections.Generic;

namespace heist_part_two
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker Willy = new Hacker();
            Muscle Garrett = new Muscle();
            LockSpecialist Holden = new LockSpecialist();

            var Rolodex = name List<IRobber>;

            // Bank.AlarmScore = BankAlarm

            int AlarmScore = 50;

            while (true)
            {
                try
                {
                    Console.Write("What is the bank difficulty? ");
                    var userInput = Console.ReadLine();
                    AlarmScore = int.Parse(userInput);
                    var taco = 100 / AlarmScore;
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Oops something went wrong");
                }
            }

            Console.WriteLine($"The difficulty is {AlarmScore}");
        }
    }
}