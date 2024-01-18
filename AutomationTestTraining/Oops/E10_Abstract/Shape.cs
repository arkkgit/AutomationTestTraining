using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E10_Abstract
{
    public  abstract class Shape
    {
        public int i = 10;
        public abstract void GetArea();

        public void NormalMethod()
        {
            Console.WriteLine("Normal method");
        }

    }
}
