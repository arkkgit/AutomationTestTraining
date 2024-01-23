using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions.E05_ShareStateContextInjection
{
    [Binding]
    public  class SS2_CI
    {

        ShareStateObjects sso;
        public SS2_CI(ShareStateObjects xsso)
        {

            this.sso = xsso;
        }

        [When(@"the user adds (.*) in the cart")]
        public void WhenTheUserAddsInTheBasket(int additon)
        {
            sso.addedItems = additon;
        }
    }
}
