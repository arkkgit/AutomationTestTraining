using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E08_Static
{
    public class StaticDemo
    {

        static public int i = 10;
        public int j = 19;

        public static void StatMethod ()
        {
            Console.WriteLine("This is a static method");
            Console.WriteLine("Accesing static var "+i);
            //Console.WriteLine("Accessing non static var "+j); cannot access a non static var.
            //NonStatMethod();
        }

        public void NonStatMethod()
        {
            Console.WriteLine("This is a nonn static method");
            Console.WriteLine("Accesing static var " + i);
            Console.WriteLine("Accessing non static var " + j);

        }

    }
}
