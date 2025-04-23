using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sessions
{
    public class Session16RecursionBasic
    {
        /// <summary>
        /// Ex 1: Sum of first n natural numbers
        /// https://www.geeksforgeeks.org/sum-of-natural-numbers-using-recursion/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int SumN(int n)
        {
            if (n == 1)
                return 1;

            return n + SumN(n - 1);
        }
        public int Sum(int n)
        {
            var sum = 0;

            for (var i = 1; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }

        #region function call tracking
        /*
         * Function call stack:
         *  -> Involve tracking the  sequence of function calls
         *     that are made during the execution of a program
         *  -> It involves keeping track of the function calls,
         *     their arguments and the return value in order to
         *     understand the flow ot the program
         * Data structure involved in funtion call: Stack
         *  -> LIFO
         *  -> It is called "Call Stack"
         *  -> It stores function calls, their arguments and return values
         */
        private int Add(int a, int b)
        {
            return a + b;
        }
        private int Multiply(int a, int b)
        {
            return a * b;
        }
        private int Substract(int a, int b)
        {
            return a - b;
        }

        public string PrintNatural()
        {
            // Console.Write(n.ToString()); 
            // Start the recursion with the given number n
            int x = 10, y = 20;
            var result = string.Empty;
            Console.Write(Substract(Multiply(Add(x, y), 30), 75));
            return string.Empty;
        }
        #endregion

        /// <summary>
        /// Q1: Factorial of a number
        /// Source: https://www.geeksforgeeks.org/program-for-factorial-of-a-number/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Factorial(int n)
        {
            if (n == 1)
                return 1;

            return n * Factorial(n - 1);
        }

        /// <summary>
        /// Q2: Print all numbers from 1 to n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string PrintNumbers(int n)
        {
            var sb = new StringBuilder();

            for(var i = 1; i <= n; i++)
            {
                sb.Append(i);
                sb.Append(" ");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Q2: Print all numbers from 1 to n using recursion
        /// https://www.geeksforgeeks.org/print-1-to-n-without-using-loops/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string PrintNumbersRecursion(int n)
        {
            if (n == 1)
                return "1";

            return PrintNumbersRecursion(n - 1) + " " + n;
        }

        /// <summary>
        /// Q3: Whashing machine times
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Q4: Fibonacci series
        /// Source: https://leetcode.com/problems/fibonacci-number/
        /// T.C = O(2^n)
        /// S.C = O(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fibbonacci(int n)
        {
            
            if (n <= 1)
                return 1;

            return Fibbonacci(n - 1) + Fibbonacci(n - 2);
        }
    }
}
