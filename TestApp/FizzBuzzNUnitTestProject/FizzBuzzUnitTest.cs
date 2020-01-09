using NUnit.Framework;
using FizzBuzzLib;
using System.Collections.Generic;

namespace FizzBuzzTest
{
    public class FizzBuzzTests
    {
        FizzBuzz fizzBuzz;
        [SetUp]
        public void Setup()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void Check_If_15_Is_FizzBuzz()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(3, "Fizz");
            dict.Add(5, "Buzz");
            dict.Add(7, "Fuzz");
            dict.Add(15, "FizzBuzz");
            List<string> fizzList = fizzBuzz.GetFizzBuzz(100,dict);

      
            Assert.AreEqual("FizzBuzz", fizzList[14]);
        }
    }
}