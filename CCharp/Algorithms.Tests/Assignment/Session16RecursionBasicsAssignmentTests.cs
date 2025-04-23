using Algorithms.Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests.Sessions
{
    public class Session16RecursionBasicsAssignmentTests
    {
        private Session16RecursionBasicAssignment _sut;

        public Session16RecursionBasicsAssignmentTests()
        {
            _sut = new Session16RecursionBasicAssignment();
        }

        [Theory]
        [InlineData(5, "1 2 3 4 5")]
        public void PrintNumbers_Should_PrintAllNumbersFrom1ToN(int n, string expected)
        {
            var result = _sut.PrintNumbers(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, "1 2 3 4 5")]
        public void PrintNS2_Should_PrintAllNumbersFrom1ToN(int n, string expected)
        {
            _sut.PrintNumbers(n);
        }

        [Theory]
        [InlineData(5, "5 4 3 2 1")]
        public void PrintNumbersDesc_Should_PrintAllNumbersFromNTo1(int n, string expected)
        {
            var result = _sut.PrintNumbersDesc(n);
            Assert.Equal(expected, result);
        }
    }
}
