using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLib;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(3, "Fizz");
            dict.Add(5, "Buzz");
            dict.Add(7, "Fuzz");
            dict.Add(15,"FizzBuzz");


            List<string> fizzList =  fizzBuzz.GetFizzBuzz(150,dict);
            foreach (string s in fizzList)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

            foreach (string s in fizzBuzz.GetFizzBuzzForIntMax(int.MaxValue, dict))
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
