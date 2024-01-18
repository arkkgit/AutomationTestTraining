using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E11_Interface
{
    public class Pegion : IBird
    {
        public void Eat()
        {
            Console.WriteLine("Pegion Eats grains... ");
        }

        public void Fly()
        {
            Console.WriteLine("Pegion flies around 7 m high");
        }

        public void PegionSpecific()
        {
            Console.WriteLine("Specifiv Pegion method");
        }

    }
}
