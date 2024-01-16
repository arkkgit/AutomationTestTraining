using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E02_Methods
{
    public class Car
    {

 
        public string color = "White";

        // No input and No output
        public void Accelerate ()
        {
            Console.WriteLine( "The car is accelerating");
        }

        // Yes Input no output
        public void Brake (string pedal)
        {
            Console.WriteLine("Braking by " + pedal);
        }

        // yes Output no input

        public string WearningNoSeatBelt ()
        {
            Console.WriteLine("Inside the no seat belt method");
            return "Warning!! Please put on seat bealt";
        }


        //yes output and yes input
        public  string GetCarDetails(string carno)
        {
            PrintStar();
            string CarDetails = "The details of " + carno + " Nissan Model 2020";
            return CarDetails;

        } 

        public void PrintStar()
        {
            Console.WriteLine("****************");
        }
    }
}
