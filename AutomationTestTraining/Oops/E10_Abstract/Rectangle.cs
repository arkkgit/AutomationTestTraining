using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E10_Abstract
{
    public class Rectangle : Shape
    {
        public override void GetArea()
        {
            Console.WriteLine("This is the area of Rectangle Base * Height");
        }
    }
}
