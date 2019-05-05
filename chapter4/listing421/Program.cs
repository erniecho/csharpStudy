using System;

namespace listing421
{
    class Program
    {
        static void Main(string[] args)
        {
            int input; //declare a variable to store the input

            System.Console.Write(
            "What is the maximum number" +
            "of turns in tic-tac-toe?" +
            "(Enter 0 to exit.): "
            );

            // int.Parse() converts the ReadLine()
            // return to an int data type
            input = int.Parse(System.Console.ReadLine());

            if (input <= 0) // line 16
            // Input is less than or equal to 0
            System.Console.WriteLine("Exiting...");
            else
            if (input < 9) //Line 20
            //Input is less than 9
            System.Console.WriteLine(
            $"Tic-tac-toe has more than {input}" +
            " maximum turns.");
            else
            //Input equals 9
            System.Console.WriteLine( // line 33
            "Correct, tic-tac-toe " +
            "has a maximum of 9 turns.");
        }
    }
}
