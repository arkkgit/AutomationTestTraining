using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions
{
    [Binding]
    public class E03_BackgroundStepDef
    {

        [Given(@"the user is logged into the Ecom app")]
        public void GivenTheUserIsLoggedIntoTheEcomApp()
        {
            Console.WriteLine("1.BS step login");
        }

        [Given(@"the user adds items to the cart")]
        public void GivenTheUserAddsItemsToTheCart()
        {
            Console.WriteLine("2.BS step add cart");
        }

        [Given(@"the user checksout the basket")]
        public void GivenTheUserChecksoutTheBasket()
        {
            Console.WriteLine("3.BS step checkout");
        }

        [When(@"the user pays the amount by Credit card")]
        public void WhenTheUserPaysTheAmountByCreditCard()
        {
            Console.WriteLine("PAy CCard");
        }

        [Then(@"the order is successful")]
        public void ThenTheOrderIsSuccessful()
        {
            Console.WriteLine("Order successful");
        }

        [When(@"the user pays the amount by Debit card")]
        public void WhenTheUserPaysTheAmountByDebitCard()
        {
            Console.WriteLine("Pay Debit card");
        }

        [When(@"the user pays the amount by Paypal")]
        public void WhenTheUserPaysTheAmountByPaypal()
        {
            Console.WriteLine("Pay Paypal");
        }

    }
}
