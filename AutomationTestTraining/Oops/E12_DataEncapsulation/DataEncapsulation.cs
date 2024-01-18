using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E12_DataEncapsulation
{
    public  class DataEncapsulation
    {
       private string username;
       private string password;
       public string town; // this is just to build the case.



        public void setUsername(string xusername)
        {
            username = xusername;
        }
        public string getUsername()
        {
            return "a****@gmail.com";
        }

        public void setPassword(string xpass)
        {
            password = xpass;
        }

       /* public string getPassword()
        {
            return password;
        }*/

    }
}
