using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task5();
            task6();
        }
        public static void task6()
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b + c);
        }
        public static void task5()
        {
            string name = "", surname = "";
            Console.Write("Write your name: ");
            name = Console.ReadLine();
            Console.Write("Write your surname: ");
            surname = Console.ReadLine();

            Console.WriteLine("Приветствую тебя - " + name + surname);
        }
    }
}
