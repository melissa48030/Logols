using System;

namespace Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            A status report is needed of all government employees.  Statuses are:
            1: Alive, 2: Zombie, 3: Dead, 4: Unknown
            Given an int variable, write if else statements and console out the persons status.
            Using the same int variable, modify your code to perform the same operation with a switch statement.
             */

            int value = 4;
            
            if(value == 1)
            {
                Console.WriteLine("IF Status: Alive");
            }
            else if (value == 2)
            {
                Console.WriteLine("IF Status: Zombie");
            }
            else if (value == 3)
            {
                Console.WriteLine ("IF Status: Dead");
            }
            else if (value == 4)
            {
                Console.WriteLine("IF Status: Unknown");
            } 

            //switch statement
            switch (value)
            {
                case 1:
                    Console.WriteLine("SWITCH Status: Alive");
                    break;
                case 2:
                    Console.WriteLine("SWITCH Status: Zombie");
                    break;
                case 3:
                    Console.WriteLine ("SWITCH Status: Dead");
                    break;
                case 4:
                    Console.WriteLine("SWITCH Status: Unknown");
                    break;
            } 
        }
    }
}
