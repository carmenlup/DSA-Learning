using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Assignment
{
    public class Session16RecursionBasicAssignment
    {
        // assigment
        // print all numbers from 1 to n
        // implement using recursion

        // done in class
        public string PrintNumbers(int current)
        {
            // Base case: if current is 1, return "1"
            if (current == 1)
            {
                return "1";
            }
            // Recursive case: call the method with current - 1 and append the current number
            return PrintNumbers(current - 1) + " " + current;
        }

        // done in class - whashing machine timer
        public string PrintNumbersDesc(int current)
        {
            // Base case: if current is 1, return "1"
            if (current == 1)
            {
                return "1";
            }
            // Recursive case: call the method with current - 1 and append the current number
            return current + " " + PrintNumbersDesc(current - 1);
        }
    }
}
