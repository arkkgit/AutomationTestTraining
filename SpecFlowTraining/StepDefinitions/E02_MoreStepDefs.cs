using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions
{
    [Binding]
    public class E02_MoreStepDefs
    {

        [Given(@"the user adds the following items to the cart")]
        public void GivenTheUserAddsTheFollowingItemsToTheCart(Table table)
        {
            Console.WriteLine("No of Rows : " + table.RowCount);
            var header = table.Header;
            foreach (var item in header)
            {
                Console.WriteLine("Header Item " + item);
            }

            //To get a particlar item from table dynamically getting the items
            Console.WriteLine("Item at 0, 0 : " + table.Rows[0][0]);

            for (var i = 0; i < table.RowCount; i++)
            {
                Console.WriteLine("The Item name " + table.Rows[i][0]);
                Console.WriteLine("The Quantity is " + table.Rows[i][1]);
                Console.WriteLine("The Color is " + table.Rows[i][2]);

                //Add items to cart  addItemstocart(name, qty, color)

            }

            //to get both rows and cols dynamic
            for (var i = 0; i < table.RowCount; i++)
            {
                for (var j = 0; j < table.Header.Count; j++)
                {
                    Console.WriteLine("both Row and Col as dynamic " + table.Rows[i][j]);
                }

            }
        }


            [Given(@"the user get the following messgae")]
            public void GivenTheUserGetTheFollowingMessgae(string multilineText)
            {
                Console.WriteLine("The multi line msg : "+multilineText);
            }




        }

    }

