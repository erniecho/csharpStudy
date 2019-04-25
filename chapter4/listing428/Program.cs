using System;

namespace listing428
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            if (input < 9)
            {
                // Input is less than 9
                System.Console.WriteLine($"Tic-tac-toe has more than { input }"
                 +" maximum turns.");
            }

            bool result = 70 > 7;
            if (input == "" || input == "quit")
            {
                System.Console.WriteLine($"Player {currentPlayer} quit!!");
                break;
            }

            if ((hoursOfTheDay > 23) || (hoursOfTheDay < 0))
                System.Console.WriteLine("The time you entered is invalid.");

            if ((10 < hoursOfTheDay) && (hoursOfTheDay < 24))
                System.Console.WriteLine(
                "Hi-Ho-, Hi-Ho, it's off to work we go.");
        }
    }
}
