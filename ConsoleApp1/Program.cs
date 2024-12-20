using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 10;
            Console.WriteLine("Инкремент:{0}, Значение:{1}, Декремент:{2}", ++cont, --cont, --cont);
            Console.WriteLine("Value : {0} Increment: {1}", cont, cont++);
            Console.ReadKey();
            /*double result = 5.0 / 2.0;
            Console.WriteLine("5 / 2 = {0}", result);
            Console.ReadKey();*/
            /*string str = Console.ReadLine();
            Console.Write(str);
            Console.ReadKey();*/

            /*var name = "Jane";
            var age = 27;
            var favcolor = "black";
            Console.WriteLine("{0} \n{1} \n{2}", name, age, favcolor);
            Console.ReadKey();*/

            /*string MyName;
            MyName = "Nika";
            const string MyAge = "12";
            Console.WriteLine($"Мой возраст {MyAge}")
            Console.WriteLine(MyName);
            Console.WriteLine("\tПривет, мир");
            Console.WriteLine("\tМне"+ " " + MyAge + " " + "лет");
            Console.WriteLine("\tMy name is" + " \n" + MyName);
            Console.WriteLine("\u0023");
            Console.ReadKey();*/


            /*string MyName = "Nika";
            Console.WriteLine("My name is " + MyName);
            byte MyAge = 18;
            Console.WriteLine("My age is " + MyAge);
            bool pet = true;
            Console.WriteLine("Do I have a pet? " + pet);
            double ssize = 37.5;
            Console.WriteLine("My shoe size is " + ssize);
            Console.ReadLine();
            Console.WriteLine("\t Привет, \n мир!");*/


        }
    }
    /*enum Semaphore
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }*/
}
