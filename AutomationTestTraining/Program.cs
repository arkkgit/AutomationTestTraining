using AutomationTestTraining.Basics;
using AutomationTestTraining.Oops.E01_Class;
using AutomationTestTraining.Oops.E02_Methods;
using AutomationTestTraining.Oops.E03_Constructors;
using AutomationTestTraining.Oops.E04_OverLoading;
using AutomationTestTraining.Oops.E05_Inheritance;
using AutomationTestTraining.Oops.E06_NameSpace.Sharp;
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
            /*          Bike bike1 = new Bike();
                      bike1.color = "Blue";
                      Bike bike2 = new Bike("Red");
                      bike2.GetColor();

                      Bike bike3 = new Bike("Green");
                      */

            //Method OverLoading
            /*
                        MyCalculator myCalculator = new MyCalculator();
                        var sum= myCalculator.add(5, 7);
                        Console.WriteLine("sum = "+sum);
                        var sum2 = myCalculator.add(3, 4, 5);*/

            //Inheritance

/*            A a = new A();
            Console.WriteLine("The First name is " + a.FirstName);
            Console.WriteLine("The surname is "+a.LastName);
            a.Work();
            a.Hobbies();

            Console.WriteLine("********Attributes and actions of B*****");
            B b = new B();
            Console.WriteLine("The First name is " + b.FirstName);
            Console.WriteLine("The surname is " + b.LastName);
            b.Work();
            b.Hobbies();
            b.Walk();

            Console.WriteLine("******Attributes of C *******");
            C c = new C();
            c.Work();
            c.Hobbies();
            // object is a superclass by default for all classes.
*/


            //namespace and using
/*            Calc c1 = new Calc();
            c1.add();
            
            // In case if you want to use both.
            AutomationTestTraining.Oops.E06_NameSpace.Casio.Calc c2 = new AutomationTestTraining.Oops.E06_NameSpace.Casio.Calc();
            c2.add();*/




        }

    }
}
