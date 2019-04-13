using static System.Console;

namespace listing216
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindrome;

            Write("Enter a palindrome: ");
            palindrome = ReadLine();

            WriteLine(
            $"The palindrome \"{palindrome}\" is"
            + $" { palindrome.Length } characters."
                );
        }
    }
}
