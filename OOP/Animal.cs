using System;
using System.Collections.Generic;
//using System.Collections.IEnumerable;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
using NLog;
using System.Reflection;

namespace OOP
{
    [ConsoleColor(ConsoleColor.Green)]
    class Animal



    {
        public Logger logAnimal = LogManager.GetCurrentClassLogger();
        

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

        public int friendsNum;


        public Animal(string name, string food, string habitat, int weight)
        {
            Name = name;
            Habitat = habitat;
            Food = food;
            Weight = weight;
        }

        public Animal()
        {
        }

        public void Call()
        {

            Console.WriteLine("Enter name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Habitat");
            Habitat = Console.ReadLine();
            Console.WriteLine("Enter food");
            Food = Console.ReadLine();
            Console.WriteLine("Enter age");
            try
            {
                Age = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
                logAnimal.Info("Введено не число типа int");

            }
            Console.WriteLine("Enter weight");
            try
            {
                Weight = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
                logAnimal.Info("Введено не число типа int");

            }
        }

        public void CallCollection()
        {
            Console.ForegroundColor = (typeof(Animal).GetCustomAttribute(typeof(ConsoleColorAttribute)) as ConsoleColorAttribute).CColor;

            List<string> strings = new List<string>();
            List<int> ints = new List<int>();
            Console.WriteLine("Enter name");
            strings.Add(Console.ReadLine());
            Console.WriteLine("Enter habitat");
            strings.Add(Console.ReadLine());
            Console.WriteLine("Enter food");
            strings.Add(Console.ReadLine());
            Console.WriteLine("Enter age");
            try
            {
                ints.Add(int.Parse(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
                logAnimal.Info("Введено не число типа int");

            }
            Console.WriteLine("Enter weight");
            try
            {
                ints.Add(int.Parse(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
                logAnimal.Info("Введено не число типа int");
            }


            _name = strings[0];
            _habitat = strings[1];
            _food = strings[2];
            _age = ints[0];
            _weight = ints[1];
        }

        public void CallFriends()
        {
            List<string> friends = new List<string>();
            Console.WriteLine("Enter number of {0}`s friends", _name);
            try
            {
                friendsNum = int.Parse(Console.ReadLine());
            }
            catch
            {
                
                Console.WriteLine("Возникло исключение!");
                logAnimal.Info("Введено не число типа int");
            }
                for (int i = 0; i < friendsNum; i++)
            {
                Console.WriteLine("Enter friend name");
                friends.Add(Console.ReadLine());
            }
            Console.WriteLine("{0}`s frieands are:", _name);

            friends.Sort();

            foreach (string fr in friends)
            {
                Console.Write(fr + " ");
            }

        }

    }

}
