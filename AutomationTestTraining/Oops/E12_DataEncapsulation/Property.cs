using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E12_DataEncapsulation
{
    public class Property
    {

        public int Age { get; set; }
        private string username;

        public string Username
        {
            get
            {
                return "***** masked username" + username;
            }
            set
            {
                username = value;
            }
        }

   




    }
}
