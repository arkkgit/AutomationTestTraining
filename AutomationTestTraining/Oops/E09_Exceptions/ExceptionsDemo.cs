using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E09_Exceptions
{
    public class ExceptionsDemo
    {
        static string[] weekenddays = new string[] { "Sat", "Sun" };

        public static  void exceptionDemo()
        {

            Console.WriteLine("DB connection is opened");

            try
            {
                Console.WriteLine("The value at index 1 is " + weekenddays[0]);
                Console.WriteLine("Another piece of code");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Exception is caught : "+ex.Message);

            }
            finally
            {
                Console.WriteLine("DB connection is Closed");
                // irrespective of the error this piece of code or block will get executed.
            }


            Console.WriteLine("This is the next statement after accessing the index");
        }

    }
}
