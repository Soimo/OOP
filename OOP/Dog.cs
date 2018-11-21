using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Dog : Animal, ITalk
    {

        public void Voice()
        {
            Console.WriteLine("Bark");
        }
        public Dog(string name, string food, string habitat, int weight) : base(name, food, habitat, weight)
        {


        }
    }
}
