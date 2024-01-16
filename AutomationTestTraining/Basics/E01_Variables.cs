using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Basics
{
    public  class E01_Variables
    {
        int MyId = 1213; //class level
        string myname = "Abdul";
        public static void VariableDemo()
        {
            int number; // declaration
            number = 10; // initialisation

           const double pi = 3.17;
           int radius = 5;
           
            double areaOfCircle = pi * radius * radius;
            Console.WriteLine("Area of Circle : "+areaOfCircle);

            string MyCompany = "NHSBT";

            string myLocation = "UK";

            Console.WriteLine("My company is in the "+MyCompany);

            bool invisible = true;
            int mm = 67;
            bool k = false;
            string pi1 = "31.7";
            string _to_do = "lot of things";

            var i = false;
           // var k; // cannot do only the declartaion for var;




        }


        public void anotherMethod()
        {
            Console.WriteLine("Accessimg my name : "+myname);
        }

    }
}
