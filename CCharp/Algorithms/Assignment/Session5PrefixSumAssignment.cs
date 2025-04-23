using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Assignment
{
    public class Session5PrefixSumAssignment
    {
        public int[] PrefixSumInPlace(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                input[i] += input[i - 1];
            }
            return input;
        }
    }
}
