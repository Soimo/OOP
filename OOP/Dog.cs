using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace OOP
{
    [ConsoleColor(ConsoleColor.Red)]
    class Dog : Animal, ITalk
    {
        public void Voice()
        {
            Console.WriteLine("Bark!"); //Реализуем метод интерфейса ITalk
        }

        public Dog()
        {
        }


        public Dog(string name, string food, string habitat, int weight) : base(name, food, habitat, weight)
        {
        }

        public void CallDogs()
        {
            List<Dog> dogs = new List<Dog>() //Значения "зашиты" в код, чтобы каждый раз не вводить их руками
            {
            new Dog { Name = "Scooby", Habitat = "House", Food = "Chappie", Age = 5, Weight = 20 },
            new Dog { Name = "Lessye", Habitat = "Doghouse", Food = "Pedigree", Age = 7, Weight = 22 },
            new Dog { Name = "Mukhtar", Habitat = "Vilage", Food = "Pedigree", Age = 3, Weight = 30 },
            new Dog { Name = "Black Beam", Habitat = "House", Food = "Pedigree", Age = 9, Weight = 18 },
            new Dog { Name = "Spike", Habitat = "Doghouse", Food = "Pedigree", Age = 6, Weight = 15 },
            };
            var sortedDogs = from d in dogs
                              orderby d.Name
                              select d;

            Console.ForegroundColor = (typeof(Dog).GetCustomAttribute(typeof(ConsoleColorAttribute)) as ConsoleColorAttribute).CColor; //Получаем значение для цвета шрифта из атрибута

            foreach (Dog d in sortedDogs)
                Console.WriteLine(string.Format("{0} lives in {1}", d.Name, d.Habitat));
        }
    }

}

