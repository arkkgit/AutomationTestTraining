using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions.Hooks
{
    [Binding]
    public class E07_DataHooks
    {
        [BeforeScenario("john", Order =100)]
        public void loadDataForJohn()
        {
            Console.WriteLine("Mechanism to read the data from persona John");
        }

        //
        //Additional hook to demo parallel
       // [BeforeScenario]
        public void wait()
        {
            Thread.Sleep(3000);
        }



    }
}
