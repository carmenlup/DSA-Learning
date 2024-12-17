using Algorithms.Contests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests.Contests
{
    public class Module1Contest25NovTests
    {
        private Module1Contest25Nov _sut;

        public Module1Contest25NovTests()
        {
            _sut = new Module1Contest25Nov();
        }

        [Theory]
        [InlineData(new int[] { 8, 7, 11, 9, 14, 28}, 1)]
        [InlineData(new int[] { 8, 7, 11, 9, 14, 28, 0 }, 1)]
        [InlineData(new int[] { 1, 7, 5, 3, 14 }, 0)]
        public void Find7Division_ShouldReturnCountOfNumbersDivisibleBy7_AndWithAtLeastTwoNumbersGreated(int[] input, int expected)
        {
            // Arrange & Act
            var actual = _sut.Find7Division(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5)]
        public void MaximumPrimeDifference_ShouldReturnLengthOfIntervalBetweenFirstAndLastPrimes(int[] input, int expected)
        {
            // Arrange & Act
            var actual = _sut.MaximumPrimeDifference(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5)]
        public void MaximumPrimeDifferenceOptimal_ShouldReturnLengthOfIntervalBetweenFirstAndLastPrimes(int[] input, int expected)
        {
            // Arrange & Act
            var actual = _sut.MaximumPrimeDifferenceOptimal(input);

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
