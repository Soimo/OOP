using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("{0} eats {1} lives in {2} it weight is {3} and it age is {4}", dog.Name, dog.Food, dog.Habitat, dog.Weight, dog.Age);
            Console.Write("\n{0} says ", dog.Name);
            dog.Voice();
            Console.ReadLine();
        }

        
    }

}
