using AutomationTestTraining.Basics;
using AutomationTestTraining.Oops.E01_Class;
using AutomationTestTraining.Oops.E02_Methods;
using AutomationTestTraining.Oops.E03_Constructors;
using AutomationTestTraining.Oops.E04_OverLoading;
using AutomationTestTraining.Oops.E05_Inheritance;
using AutomationTestTraining.Oops.E06_NameSpace.Sharp;
using AutomationTestTraining.Oops.E08_Static;
using AutomationTestTraining.Oops.E09_Exceptions;
using AutomationTestTraining.Oops.E10_Abstract;
using AutomationTestTraining.Oops.E11_Interface;
using AutomationTestTraining.Oops.E12_DataEncapsulation;
using AutomationTestTraining.Oops.Utils;
using System;
using System.Collections.Generic;
using System.IO;
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
                        Console.WriteLine("The surname is " + a.LastName);
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

                        // demo of this and base
                        b.DemoOFThisandBase();
            */


            //namespace and using
            /*            Calc c1 = new Calc();
                        c1.add();

                        // In case if you want to use both.
                        AutomationTestTraining.Oops.E06_NameSpace.Casio.Calc c2 = new AutomationTestTraining.Oops.E06_NameSpace.Casio.Calc();
                        c2.add();*/

            // Static Modifier

            /* StaticDemo.StatMethod(); // static methods and members can be accessed with out object
             Console.WriteLine("accessing stat var "+StaticDemo.i);
             StaticDemo myStat = new StaticDemo();
             Console.WriteLine("var j is : "+myStat.j);
             myStat.NonStatMethod();*/

            //Exceptions

            //ExceptionsDemo.exceptionDemo();


            //Abstraction
            /*           //Shape shape = new Shape(); // you cannot create an instance of abstract.
                       Triangle myTriangle = new Triangle();
                       myTriangle.GetArea();
                       new Rectangle().GetArea(); // short for an instance.

                       myTriangle.NormalMethod();
                       Console.WriteLine("The var from abstract classs is "+myTriangle.i);*/


            //Interfaces
            /*            //IBird bird = new IBird();  // cannot instantiate an interface.

                        Pegion myPegion = new Pegion();
                        myPegion.Fly();
                        myPegion.Eat();
                        myPegion.PegionSpecific();

                        Parrot myBird1 = new Parrot();
                        IBird  myBird2 = new Parrot();
                        IJungle myBird3 = new Parrot();

                        //myBird3. // try to see which methods from which interface are available for
                        // myBird 1,2,3.

                       // A abcd = new B(); // upcasting - implicit casting
            */

            //Data Encapsulation

            /*        DataEncapsulation d = new DataEncapsulation();
                    d.setUsername("admin");
                    var u = d.getUsername();
                    Console.WriteLine("The username is :"+u);

                    d.town = "Bristol";
                    Console.WriteLine("Town is : "+d.town);

                    d.setPassword("secret");
                    //Console.WriteLine("The password is "+d.getPassword());

                    Property p = new Property();
                    p.Age = 24;
                    Console.WriteLine("The age is "+p.Age);
                    p.Username = "abdul";
                    Console.WriteLine("getting the user name "+p.Username);*/

            // Utils

            string s1 = "I am pro in C# now";
            var replacedString = s1.Replace("pro", "Ninja");
            Console.WriteLine("Repalced example : "+ replacedString);
            bool containYN = s1.Contains("pro");
            Console.WriteLine(containYN);
            var upperString=  s1.ToUpper();
            Console.WriteLine(upperString);
            string[] splittedExample = s1.Split(' ');
            
            foreach(string example in splittedExample)
            {
                Console.WriteLine(example);
            }

            //Please reverse the string s1 by Google or Chatgpt or any other means and print it.
            Console.WriteLine(Utils.Reverse(s1));

            //Read file from desktop which is abc.txt and print the contents.
            var c= File.ReadAllLines("C:\\Users\\rahee\\OneDrive\\Desktop\\abcd.txt");
           // Console.WriteLine(c);
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
        }

    }
}
