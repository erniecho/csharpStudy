using System;

namespace Listing29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const double number = 1.618033988749895;
            double result;
            string text;

            text = $"{number}";
            result = double.Parse(text);
            System.Console.WriteLine($"{result == number}: result == number");

            text = string.Format("{0:R}", number);
            result = double.Parse(text);
            System.Console.WriteLine($"{result == number}: result == number");
        }
    }
}
