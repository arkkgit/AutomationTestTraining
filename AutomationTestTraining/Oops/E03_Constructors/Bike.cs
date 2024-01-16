using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E03_Constructors
{
    public class Bike
    {
        public string color;

        public Bike ()
        {
            Console.WriteLine( "Default contsructor is exposed");
        }
       
        public Bike(string xcolor)
        {
            color = xcolor;
            //Deafult behaviour
        }

        public void GetColor()
        {
            Console.WriteLine( "The color of bike is :"+color);
        }

    }
}
