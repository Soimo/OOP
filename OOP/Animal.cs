using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Animal
    {
        private string _name;
        public string Name
        { 
            get { return _name; }
            set { _name = value; }
        }

        private string _habitat;
        public string Habitat
        {
            get { return _habitat; }
            set { _habitat = value; }
        }


        private string _food;
        public string Food
        {
            get { return _food; }
            set { _food = value; }
        }

        private int _weight;
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }



        public Animal(string name, string food, string habitat, int weight)
        {
            Name = name;
            Habitat = habitat;
            Food = food;
            Weight = weight;
        }

        public Animal()
        {
            Console.WriteLine("Enter name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Habitat");
            Habitat = Console.ReadLine();
            Console.WriteLine("Enter food");
            Food = Console.ReadLine();
            Console.WriteLine("Enter age");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter weight");
            Weight = int.Parse(Console.ReadLine());
        }

    }

}
