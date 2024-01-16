using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E05_Inheritance
{
    public class A
    {
        public string FirstName = "John";
        public string LastName = "Smith";
        private int BankBalance = 1000;


        public void Work ()
        {
            Console.WriteLine("Works as a Carpenter");
        }

        public void Hobbies()
        {
            Console.WriteLine("Likes Football");
        }

    }
}
