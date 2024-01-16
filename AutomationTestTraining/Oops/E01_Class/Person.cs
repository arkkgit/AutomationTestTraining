using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E01_Class
{
    public class Person
    {
        public string Name = "John"; // Members 
        public int Age;

        public void Eat() // Methods
        {
            Console.WriteLine($"{Name} eats 2 apples a day.");
        }

    }
}
