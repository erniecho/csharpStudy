using System;

namespace listing230
{
    class Program
    {
        static void Main(string[] args)
        {
            //double number;
            string input;

            System.Console.Write("Enter a number: ");
            input = System.Console.ReadLine();
            if (double.TryParse(input, out double number))
            {
                System.Console.WriteLine(
                $"input was parsed successfully to {number}.");}
            else
            {
                //Note: number scope is here too (although not assigned)
                System.Console.WriteLine(
                "The text entred was not a valid number.");
            }

        }
    }
}
