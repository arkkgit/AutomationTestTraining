using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Basics
{
    public class E03_Loops
    {

        public static void WhileDemo()
        {
            int i = 1;
            while (i<10)
            {
                Console.WriteLine("The value of i is :"+i);
                i = i + 1;  // This is i++

            }
        }

        public static void ForLoopDemo() {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("From For Loop i is :"+i);
            }

            for (int i = 0;i < 10; i+=2) // i+=2 is the short cut to i = i+2
            {
                Console.WriteLine("Loop with increment 2 i is: " + i);
            }

            // shortcut for multiplication  x= x*2 is x*=2
        }

    }
}
