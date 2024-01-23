using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;


namespace SpecFlowTraining.StepDefinitions.Hooks
{
    [Binding]
    public class E06_Hooks
    {

        [BeforeScenario]
        public void SetupBrowser()
        {
            Console.WriteLine("Open a browser");
            Console.WriteLine("Maximise browser");
        }

        [AfterScenario] // by default the order is 10,000
        public void CloseBrowser()
        {
            Console.WriteLine("Closing the browser...");
        }

        [AfterScenario(Order=100)]
        public void takeSSAfterScenario()
        {
            Console.WriteLine("Take SS after scenario...");
        }

        //If there is a req to take screenshot after every step

        [AfterStep]
        public void takeSS ()
        {
            Console.WriteLine("Taking Picture ....[]..");
        }

        [BeforeTestRun]
        public static void InitialiseReports()
        {
            Console.WriteLine("Initialising Reports ...");
        }

    }
}
