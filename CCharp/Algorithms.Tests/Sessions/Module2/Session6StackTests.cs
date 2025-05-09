using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Sessions.Module2;

namespace Algorithms.Tests.Sessions.Module2
{
    public class Session6StackTests
    {
        // add test cases for BalancedParenthesis

        [Theory]
        [InlineData("{[()]}", true)]
        [InlineData("({(}", false)]
        [InlineData("", false)]
        [InlineData("[", false)]
        [InlineData("{", false)]
        [InlineData("(", false)]
        public void BalancedParenthesis_Should_ValidateBalancedString(string s, bool expected)
        {
            // arrange
            var session6Stack = new Session6Stack();

            // act
            var actual = session6Stack.IsValid(s);

            // assert
            Assert.Equal(expected, actual);
        }

        // add unit test for CalculateExpression
        [Theory]
        [InlineData(new[] { "4", "13", "5", "/", "+" }, 6)]
        [InlineData(new[] { "2", "1", "+", "3", "*" }, 9)]
        [InlineData(new[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }, 22)]
        public void EvalRPN_Should_ReturnCorrectResult(string[] expression, int expected)
        {
            // arrange
            var session6Stack = new Session6Stack();

            // act
            var actual = session6Stack.EvalRPN(expression);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
