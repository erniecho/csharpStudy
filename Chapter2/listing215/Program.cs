using static System.Console; //This is a way to using Static Directive so you don't have to type the whole line.

namespace listing215
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastName;

            WriteLine("Hey You");

            Write("Enter your first name: ");
            firstname = ReadLine();
            Write("Enter your last name: ");
            lastName = ReadLine();

            WriteLine(
            $"Your full name is {firstname} {lastName}");
        }
    }
}
