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
            Console.WriteLine("Bark!"); //Реализуем метод интерфейса ITalk
        }

        public Dog()
        {

        }

        //public Dog (string name, string food, string habitat, int weight) : base(name, food, habitat, weight)
        //{


        //    //Console.WriteLine("Enter name");
        //    //name = Console.ReadLine();
        //    //Console.WriteLine("Enter food");
        //    //food = Console.ReadLine();
        //    //Console.WriteLine("Enter habitat");
        //    //habitat = Console.ReadLine();
        //    //Console.WriteLine("Enter weight");
        //    //weight = int.Parse(Console.ReadLine());
        //}
    }
}
