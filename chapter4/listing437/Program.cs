using System;

namespace listing437
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args?.Length == 0)
            {
              System.Console.WriteLine(
              "ERROR: File missing. "
              + "Use:\n\tfind.exe file:<filename>");
            }
            else
            {
              if (args[0]?.ToLower().StartsWith("file:")??false)
              {
                string fileName = args[0]?.Remove(0, 5);
                // ...
              }
            }
        }
    }
}
