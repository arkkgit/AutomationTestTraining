using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E10_Abstract
{
    public class Triangle :Shape
    {
        public override void GetArea()
        {
            Console.WriteLine("The area of a triangle is 0.5 * b * h");
        }
    }
}
