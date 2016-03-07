using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string Output = "";
                if (i % 3 == 0) Output = "Fizz"; //Divisible by 3, print Fizz
                if (1 % 5 == 0) Output += "Buzz"; //Divisible by 5, print Buzz
                if (Output == "") Output = i.ToString(); //if neither, then just the number
                Console.WriteLine(Output);
                Console.ReadLine();
            }
        }
    }
}
