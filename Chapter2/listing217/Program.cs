using static System.Console;

namespace listing217
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            Write("Enter text: ");
            text = ReadLine();

            //UNEXPECTED: DOES NOT CONVERT TEXT TO UPPERCASE.
            text.ToUpper();

            WriteLine(text);
        }
    }
}
