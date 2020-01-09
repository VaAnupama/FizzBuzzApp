using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FizzBuzz 
    {
        //Return Fizz Buzz for int.MaxValue
        //Wrote this as a seperate function since we cannot return a List of strings for int.maxValue
        //since the List also has the same restriction as int in memory so 
        //we return each value as a iterator
        public IEnumerable<string> GetFizzBuzzForIntMax(int size, Dictionary<int, string> keyValuePairs)
        {
            List<string> fizzList = new List<string>();
            string fizzValue = "";
            foreach (int i in Numbers(size))
            {
                bool isFactor = false;
                foreach (KeyValuePair<int, string> kvp in keyValuePairs.OrderBy(kvp => kvp.Key))
                {
                    if (i % kvp.Key == 0)
                    {
                        fizzValue = kvp.Value;
                        isFactor = true;
                    }
                }
                if (isFactor)
                    yield return fizzValue;
                else
                    yield return i.ToString();
            }            
        }
        
        public List<string> GetFizzBuzz(int size, Dictionary<int, string> keyValuePairs)
        {
            List<string> fizzList = new List<string>();
            string fizzValue = "";
            try
            {
                foreach (int i in Numbers(size))
                {
                    bool isFactor = false;
                    foreach (KeyValuePair<int, string> kvp in keyValuePairs.OrderBy(kvp => kvp.Key))
                    {
                        if (i % kvp.Key == 0)
                        {
                            fizzValue = kvp.Value;
                            isFactor = true;
                        }
                    }
                    if (isFactor)
                        fizzList.Add(fizzValue);
                    else
                        fizzList.Add(i.ToString());
                }              
            }
            catch(Exception ex)
            {
                fizzList.Clear();
                fizzList.Add("Exception : " + ex);
            }
            return fizzList;
        }

        public static IEnumerable<int> Numbers(int size)
        {
            for(int i = 1; i <= size; i++)
            {
                yield return i;
            }
        }
    }
}
