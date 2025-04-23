using Algorithms.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests.Sessions
{
    public class Session16RecursionBasicTests
    {
        private Session16RecursionBasic _sut;

        public Session16RecursionBasicTests()
        {
            _sut = new Session16RecursionBasic();
        }

        [Theory]
        [InlineData(5, 15)]
        [InlineData(10, 55)]
        public void SumN_Should_Return_TheSumFirstNNaturalNumbers(int n, int expected)
        {
            var sut = new Session16RecursionBasic();
            var result = sut.SumN(n);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PrintNatural_ExecuteToSeeFunctionTracking_Stack()
        {
            var sut = new Session16RecursionBasic();
            var result = sut.PrintNatural();
            Assert.Equal(string.Empty, result);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(3, 6)]
        public void Factorial_ShouldReturn_FactorialOfFirstNNaturalNumbers(int n, int expected)
        {
            var result = _sut.SumN(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, "1 2 3 4 5")]
        public void PrintNumbersRecursion_Should_printAllNumbersFrom1ToN(int n, string expected)
        {
            var result = _sut.PrintNumbersRecursion(n);
            Assert.Equal(expected, result);
        }
    }
}
