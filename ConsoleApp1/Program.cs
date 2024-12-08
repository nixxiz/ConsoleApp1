using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string MyName;
            MyName = "Nika";
            const string MyAge = "12";
            Console.WriteLine(MyName);
            Console.WriteLine("\tПривет, мир");
            Console.WriteLine("\tМне"+ " " + MyAge + " " + "лет");
            Console.WriteLine("\tMy name is" + " \n" + MyName);
            Console.WriteLine("\u0023");
            Console.ReadKey();*/
            const string MyName = "Nika";
            Console.WriteLine("My name is" + " " + MyName);

            int MyAge;
            MyAge = 18;
            Console.WriteLine("My age is" + " " + MyAge);

            bool pet = true;
            Console.WriteLine("Do you have a pet?" + " " + pet);

            int ssize;
            ssize = 37;
            Console.WriteLine("My shoe size is" + " " + ssize);
            Console.ReadLine();
        }
    }
}
