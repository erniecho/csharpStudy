using System;

namespace ConvertDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            long longNumber = 50918309109;
            int intNumber = (int)longNumber; //Explicit cast operator.

            unchecked
            {
                // int.MaxValue equals 2147483647
                int n = int.MaxValue;
                n = n + 1;
                System.Console.WriteLine(n);
            }
            intNumber = 31416;
            longNumber = (long)intNumber;

            string text = "9.11E-31";
            float kgElectronMass = float.Parse(text); //String to Float

            string middleCText = "261.626";
            double middleC = System.Convert.ToDouble(middleCText);

        }
    }
}
