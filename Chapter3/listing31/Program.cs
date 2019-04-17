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

            var patent1 =
                new { Title = "Bifocals", YearOfPublication = "1784" };
            var patent2 =
                new {Title = "Phonograph", YearOfPublication = "1877" };

            System.Console.WriteLine( 
            $"{ patent1.Title} ({ patent1.YearOfPublication })");

            System.Console.WriteLine(
            $"{ patent2.Title} ({ patent2.YearOfPublication })");
        }
    }
}
