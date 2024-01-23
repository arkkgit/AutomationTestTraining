using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions
{
    [Binding]
    public class E01_StepDefinitions
    {
        [Given(@"the user is on homepage")]
        [Given(@"the user is on home page")]
        [Given(@"the user navigated to home page")]
        public void GivenTheUserIsOnHomepage()
        {
            Console.WriteLine("The user is on home page ....");
        }

        [When(@"the user login in with valid credentials")]
        public void WhenTheUserLoginInWithValidCredentials()
        {
            Console.WriteLine( "The user is logggin with valid creds" );
        }

        [Then(@"the login is sucessful")]
        public void ThenTheLoginIsSucessful()
        {
            Console.WriteLine("The login is sucessful");
        }


        [When(@"the user login in with invalid credentials")]
        public void WhenTheUserLoginInWithInvalidCredentials()
        {
            Console.WriteLine("loggin with invalid creds");
        }

        [Then(@"the login is unsucessful")]
        public void ThenTheLoginIsUnsucessful()
        {
            Console.WriteLine( "Login failed!!!!");
        }

        //https://regexone.com/ for regular expressions
        // (\d) is for single digit
        // (\d+) is for multiple digits.

        [Given(@"the user adds (\d+) tablets to the cart")]
        public void GivenTheUserAddsTabletsToTheCart_(int noOfItems)
        {
            Console.WriteLine( "Items added are "+ noOfItems);
        }


        [Given(@"the excpected price is (.*) pounds")]
        public void GivenTheExcpectedPriceIsPounds(Decimal p0)
        {
            Console.WriteLine("the expected price is "+ p0);
        }

        [Given(@"the user picks (laptops|tablets|speakers) from popular products")]
        public void GivenTheUserPicksLaptopsFromPopularProducts(string product)
        {
            Console.WriteLine("The prodcut picked is "+product);
        }


    

        [Given(@"the user adds laptops to the bag")]
        public void GivenTheUserAddsLaptopsToTheBag()
        {
            Console.WriteLine("adding laptops to bag");
        }

        [Given(@"abcd adds (.*) tablets? to the basket")]
        public void GivenAbcdAddsTabletsToTheBasket(int p0)
        {
            Console.WriteLine("abcd added tablets "+p0);
        }

        [Given(@"xyz adds (.*) tablets? to the basket")]
        public void GivenXyzAddsTabletsToTheBasket(int p0)
        {
            Console.WriteLine( "optional text statement : "+ p0);
        }




    }
}
