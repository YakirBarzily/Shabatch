using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter you child age");
            int counter1;
            int age;
            for (int i = 0; i < 50; i++)
            {
                age = int.Parse(Console.ReadLine());
                if (age > 12 && age < 15)
                    counter1++;
            }
        }
    }
}
