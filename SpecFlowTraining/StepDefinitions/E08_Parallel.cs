using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions
{
    [Binding]
    public class E08_Parallel
    {


        [Given(@"Wait for (.*) seconds with (.*)")]
        public void GivenWaitForSeconds(int t, int id)
        {
            Thread.Sleep(t * 1000);
        }

    }
}
