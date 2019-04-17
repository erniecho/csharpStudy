using System;

namespace listing316
{
    class Program
    {
        static void Main(string[] args)
        {

            //Writing Three Dimensional Array
            bool[,,] cells;
            cells = new bool[2, 3, 3]  /* first number is how many arrays 
            second number is the how many int it carry by 3 columns
            third number is how many rows by 3.          
            */
            {
           //Player 1 moves
            {   { true, false, false},
                { true, false, false},
                { true, false, true} },

            //Player 2 moves
              {  { false, false, true},
                { true, true, false},
                { true, true, false} }
           };
        }
    }
}
