using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestTraining.Oops.E11_Interface
{
    public class Parrot : IBird, IJungle
    {
        public void AttackingAnimals()
        {
            Console.WriteLine( "Animal atatcking the Parrot");
        }

        public void Eat()
        {
            Console.WriteLine("Parrots eat nuts");
        }

        public void Fly()
        {
            Console.WriteLine("Parrots fly around 20m high");
        }
    }
}
