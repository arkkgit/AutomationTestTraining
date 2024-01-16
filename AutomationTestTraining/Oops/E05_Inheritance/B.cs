using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E05_Inheritance
{
    public class B : A
    {
        public int Age;

        public string FirstName = "Paul";

        public void Work ()
        {

            Console.WriteLine("Works as Automation Tester");
        }

        public void Walk()
        {
            Console.WriteLine("This is how B walks ....");
        }
    }
}
