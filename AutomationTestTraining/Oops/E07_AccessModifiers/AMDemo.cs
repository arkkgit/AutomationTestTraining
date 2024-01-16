using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E07_AccessModifiers
{
    public class AMDemo
    {

        public int i1;
        internal int i2;
        protected int i3;
        private int i4;
        int i5; // default.


        public void m1()
        {    
            //i
            //m
        
        }

        internal void m2()
        {        }

        protected void m3()
        {        }

        private void m4() { }
        void m5() { } //default

    }
}
