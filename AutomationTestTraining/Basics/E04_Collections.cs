using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Basics
{
    public class E04_Collections
    {

        public static void ArraysDemo()
        {
            string[] WeekDays; //declare
            WeekDays = new string[5] {"Mon", "Tue", "Wed", "Thu", "Fri"}; // initilisation 

            Console.WriteLine("Accessing the 1st value : " + WeekDays[1]);
            Console.WriteLine("number of elements in the array are : "+ WeekDays.Length);

            for (int i = 0; i < WeekDays.Length; i++)
            {
                Console.WriteLine("Weekdays are " + WeekDays[i]);
            }

            foreach (var day in WeekDays)
            {
                Console.WriteLine("Weekdays from foreach loop are: "+day);
            }


            int[,] twoDArray = new int[,] {
                                            { 1, 2, 3 },
                                            { 4, 5, 6 }
                                           };

            Console.WriteLine("Accessing the element at  1,1 " + twoDArray[1,1]);
        }


        public static void ListDemo()
        {
            List<string> ShoppingList = new List<string>();
            ShoppingList.Add("Milk");
            ShoppingList.Add("Bread");
            ShoppingList.Add("Eggs");
            ShoppingList.Add("Bread"); // Lists can hold duplicates


            Console.WriteLine("Item at index 0 is :"+ ShoppingList[3]);

            foreach (var item in ShoppingList)
            {
                Console.WriteLine( "The items in Shopping : "+item);
            }

            Console.WriteLine("Total Shopping Items are : "+ShoppingList.Count);
            ShoppingList.Remove("Eggs");
            Console.WriteLine("Total Shopping Items after removing eggs : " + ShoppingList.Count);

        }


        public static void DictionaryDemo()
        {
            Dictionary<string, string> UserData = new Dictionary<string, string>();
            UserData.Add("FirstName", "John");
            UserData.Add("LastName", "Smith");
            UserData.Add("NHSno", "1657152"); // Key value pairs. The Key should be unique

            Console.WriteLine("The first name is " + UserData["FirstName"]);
        }

    }
}
