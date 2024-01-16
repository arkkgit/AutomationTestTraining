using AutomationTestTraining.Basics;
using AutomationTestTraining.Oops.E01_Class;
using AutomationTestTraining.Oops.E02_Methods;
using AutomationTestTraining.Oops.E03_Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("I am learning C# now");

            //E01_Variables.VariableDemo();
            //E02_Contional_Statements.IfDemo();
            //E02_Contional_Statements.NestedIfElseDemo();
            //E02_Contional_Statements.SwitchDemo();
            //E03_Loops.WhileDemo();
            // E03_Loops.ForLoopDemo();
            //E04_Collections.ArraysDemo();
            //E04_Collections.ListDemo();
            //E04_Collections.DictionaryDemo();

            /*************** OOPS**********************/
            //Class
           /* Person person = new Person();
            person.Eat();
            Console.WriteLine("Accessing a member of class - Name "+person.Name);
*/

            //Methods
/*
            Car myCar = new Car();
            myCar.Accelerate();  // Method Calling
            myCar.Brake("Press Pedal");
            string s;
            s= myCar.WearningNoSeatBelt();
            Console.WriteLine( "The value of s is : "+s);
            string d = myCar.GetCarDetails("1234");
            Console.WriteLine( "Details - "+d);
*/

            //Constructors
            Bike bike = new Bike();
            Bike bike2 = new Bike("Red");
            bike2.GetColor();
            



        }

    }
}
