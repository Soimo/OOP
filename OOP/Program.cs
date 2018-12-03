using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using NLog;

//Animal - родительский класс
//ITalk - интерфейс
//Dog - класс, который наследуется от Animal и ITalk
//Метод CallCollection позволяет проверить работу try catch, введя не int значения для Age и Weight. Так же эти исключения будут записаны в лог
//ConsoleColorAttribute - это класс атрибутов, который меняет цвет шрифта в консоли

namespace OOP
{
    class Program
    {


        static void Main(string[] args)
        {

            //Этот кусок нам нужен, чтобы просто написать "Start Logging" в начале запуска программы
            Logger logger;
            logger =  LogManager.GetCurrentClassLogger(); 
            logger.Info("Start logging");

            //Вводим данные в коллекцию
            Dog dog = new Dog();
            dog.CallCollection();
            Console.WriteLine("{0} eats {1}, lives in {2}, weights {3} and it is {4} years old", dog.Name, dog.Food, dog.Habitat, dog.Weight, dog.Age);
            Console.Write("\n{0} says ", dog.Name);
            dog.Voice();

            Console.ReadLine();

            //В этом методе мы просто сортируем данные в коллекции. Используя Linq
            dog.CallDogs();

            Console.ReadLine();

        }


    }

}
