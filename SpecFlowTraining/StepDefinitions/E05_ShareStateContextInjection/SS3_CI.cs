using NUnit.Framework;
using SpecFlowTraining.StepDefinitions.E05_StaticSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions.E05_ShareStateContextInjection
{
    [Binding]
    public class SS3_CI
    {

        ShareStateObjects sso;
        public SS3_CI(ShareStateObjects xsso)
        {
            this.sso = xsso;
        }

        [Then(@"the total items in the cart are (.*)")]
        public void ThenTheTotalItemsInTheBasketAre(int totalExpected)
        {
            sso.totalItemsActual = sso.initialItems + sso.addedItems;
            Assert.AreEqual(totalExpected, sso.totalItemsActual);
        }
    }
}
