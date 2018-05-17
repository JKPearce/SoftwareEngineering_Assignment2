using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mazegame.Entity;

namespace ConsoleTestOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> distribution = new Dictionary<int, int>();
            Dice theDie = new Dice(6);

            // intialise the dictionary so starting values are zero
            for (int i=0; i < 6; i++)
            {
                distribution[i + 1] = 0;
            }

            //roll the dice 1000 times and store the result
            for (int i=0; i < 1000; i++)
            {
                int result = theDie.Roll();
                distribution[result] = distribution[result] + 1;
            }
            
            //print the distribution
            Console.Out.WriteLine("Printing the result of 1000 dice rolls");
            for (int i = 1; i < 7; i++)
            {
                Console.Out.WriteLine("The number " + i + " has been observed " +
                    distribution[i] + " times");
            }

            Console.In.ReadLine();
        }
    }
}
