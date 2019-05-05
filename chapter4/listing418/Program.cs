using System;

namespace listing418
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 123;
            //Display 123, 124, 125
            System.Console.WriteLine($"{x++}, {x++}, {x}");
            // X now contains the value 125
            // Displays 126, 127, 127
            System.Console.WriteLine($"{++x}, {++x}, {x}");
            // x now contains the value 127
        }
    }
}
