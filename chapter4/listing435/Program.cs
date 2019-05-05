using System;

namespace listing435
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentPlayer = 1

            for (int turn = 1; turn <= 10; turn++)
            {
              currentPlayer = (currentPlayer == 2) ? 1 : 2;
            }
        }
    }
}
