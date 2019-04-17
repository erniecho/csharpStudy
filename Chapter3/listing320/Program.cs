using System;

namespace listing320
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] cells =
            {
                {1,0,2},
                {0,2,0},
                {1,2,1}
            };

            cells[1, 0] = 1;
        }
    }
}
