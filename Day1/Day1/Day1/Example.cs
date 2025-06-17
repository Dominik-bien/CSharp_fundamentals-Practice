using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
   static class Example
    {

        static Example()
        {
            Console.WriteLine("Static Construct");
        }

        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

    }
}
