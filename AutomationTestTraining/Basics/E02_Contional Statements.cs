using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Basics
{
    // No code to be written here
    /* This is a block comment
     * and this is not executed
     * as well
     * 
     */
    public class E02_Contional_Statements
    {
        public static void IfDemo()
        {
            string organ = "Lung";  //= is for assignment 
            
            if (organ == "Kidney")    // == is for comparision returns true or false
            {
                Console.WriteLine($"{organ} is Eligible for Living Donation");
                Console.WriteLine("Another line of code");
            } 
            else
            {
                Console.WriteLine($"{organ} is NOT Eligible for Living Donation");
            }
        }


        public static void NestedIfElseDemo()
        {
            string status = "draft";

            if (status == "active" || status == "suspened")
            {
                Console.WriteLine("Display the records");
            }
            else if(status == "removed" || status =="died")
            {
                Console.WriteLine("Donot display records");
            }
            else
            {
                Console.WriteLine("Receipient is not Registered.");
            }


        }


        public static void SwitchDemo()
        {
            string BrowserName = "EDGE";

            switch (BrowserName.ToLower())
            {
                case ("chrome"):
                        Console.WriteLine("Chrome browser is selected");
                        break;

                case ("edge"):
                    Console.WriteLine("Edge browser is selected");
                    break;
                
                case ("firefox"):
                    Console.WriteLine("Firefox browser is selected");
                    break;

                default:
                    Console.WriteLine("Unknown browser selected");
                    break;
            }

        }


    }
}
