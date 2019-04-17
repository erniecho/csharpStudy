using System;

namespace listing31
{
    class Program
    {
        static void Main(string[] args)
        {
         /*   int? count = null;

            do
            {
                //procudure code here.
            } while (count == null);  */

            System.Console.Write("Enter text: ");
            var text = System.Console.ReadLine();

            // Return a new string in uppercase
            var uppercase = text.ToUpper();

            System.Console.WriteLine(uppercase);
        }
    }
}
