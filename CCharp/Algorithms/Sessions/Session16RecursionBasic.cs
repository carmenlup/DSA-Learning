using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sessions
{
    public class Session16RecursionBasic
    {
        // assigment
        // print all numbers from 1 to n
        // implement using recursion


        public string PrintNatural2(int n)
        {
            // print all numbers from 1 to n
            // implement using recursion
            var result =  string.Empty;
            if (n == 0)
            {
                return "";
            }

            for(var i = 1; i <= n; i++)
            {
                result = result + " " + i ;
            }

            return result;
        }



        public string PrintNatural(int n)
        {


            // Console.Write(n.ToString()); 
            // Start the recursion with the given number n
            return PrintNumbers(n);

        }

        // Helper method to handle recursion
        private string PrintNumbers(int current)
        {
           // if (order == 1)
            {
                // Base case: if current is 1, return "1"
                if (current == 1)
                {
                    return "1";
                }
                // Recursive case: call the method with current - 1 and append the current number
                return PrintNumbers(current - 1) + " " + current;
            }
            //else
            //{
            //    // Base case: if current is 1, return "1"
            //    if (current == n)
            //    {
            //        return "1";
            //    }
            //    // Recursive case: call the method with current - 1 and append the current number
            //    return PrintNumbers(current + 1) + " " + current;
            //}
        }

        public string PrintNaturalDecrease(int n)
        {
            // Console.Write(n.ToString()); 
            // Start the recursion with the given number n
            return PrintNumbersDesc(n);

        }

        private string PrintNumbersDesc(int current)
        {

            // Base case: if current is 1, return "1"
            if (current == 1)
            {
                return "1";
            }
            // Recursive case: call the method with current - 1 and append the current number
            return current + " " + PrintNumbers(current - 1);

        }
    }
}
