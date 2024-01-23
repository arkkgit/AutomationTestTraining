using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions
{
    [Binding]
    public class E07_DataHooks
    {
        [Given(@"sample statement")]
        public void GivenSampleStatement()
        {
            Console.WriteLine("Sample Given");
        }

        [When(@"sample statement")]
        public void WhenSampleStatement()
        {
            Console.WriteLine("Sample When");
        }

        [Then(@"sample statement")]
        public void ThenSampleStatement()
        {

            Console.WriteLine(  "Sample Then");
        }


    }
}
