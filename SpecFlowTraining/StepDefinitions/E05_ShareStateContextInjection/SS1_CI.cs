using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions.E05_ShareStateContextInjection
{
    [Binding]
    public class SS1_CI
    {
        ShareStateObjects sso;
        public SS1_CI(ShareStateObjects xsso) {

            this.sso = xsso;
        }



        [Given(@"the user has (.*) in the cart")]
        public void GivenTheUserHasInTheBasket(int initial)
        {
            sso.initialItems = initial;
        }
    }
}
