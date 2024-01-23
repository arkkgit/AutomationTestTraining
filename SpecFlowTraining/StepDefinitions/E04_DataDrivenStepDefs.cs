using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions
{
    [Binding]
    public class E04_DataDrivenStepDefs
    {
        int initialItems, addedItems, totalItemsActual;

        [Given(@"the user has (.*) in the basket")]
        public void GivenTheUserHasInTheBasket(int initial)
        {
            initialItems = initial;
        }

        [When(@"the user adds (.*) in the basket")]
        public void WhenTheUserAddsInTheBasket(int additon)
        {
            addedItems = additon;
        }

        [Then(@"the total items in the basket are (.*)")]
        public void ThenTheTotalItemsInTheBasketAre(int totalExpected)
        {

            totalItemsActual = initialItems+ addedItems;
            Assert.AreEqual(totalExpected, totalItemsActual);
        }


    }
}
