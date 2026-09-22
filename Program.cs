using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int number = generator.Next(); //Picks a random number from 0-MAXINT
            int number2 = generator.Next(10); //Picks a random number from 0-9
            int number3 = generator.Next(5, 10); //Picks a random number from 5-9

            //Next() Returns a non-negative random integer.
            //Next(Int32) Returns a non-negative random integer that is less than the specified maximum.
            //Next(Int32, Int32) Returns a random integer that is within a specified range.
            //NextDouble() Returns a random floating-point number that is greater than or equal to 0.0, and less than 1.0.



            //How can you make a random number in the range of 0-10 inclusive?

            
            



        }
    }
}
