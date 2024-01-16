using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E04_OverLoading
{
    public  class MyCalculator
    {

        public int add(int a, int b)
        {
            int sum = a + b;
            return sum;

        }

       /* public int add(int c, int d)
        {
            int sum = c + d;
            return sum;

        } */ // This is not allowed as the signature order matches with the above.

        public int add(int a, int b, int c) // Method Overloading
        {
            return a + b + c;
        }

        public int add(int a, int b, int c, int d, int e) // Method Overloading
        {
            return a + b + c + d + e;
        }

        public string add (string s1, string s2)
        {
            return s1+s2;
        }

    }
}
