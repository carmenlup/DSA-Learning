using Algorithms.Sessions;

namespace Algorithms.Tests.Sessions
{
    public class Session23SortingTests
    {
        private Session23Sorting _sut;
        public Session23SortingTests()
        {
            _sut = new Session23Sorting();
        }

        #region sorting1
        [Theory]
        [InlineData(new int[] { 2,1,4}, 11)]
        [InlineData(new int[] {4, 6, 1},17)]
        [InlineData(new int[] { 3, 5, 1, -3 }, 2)]
        public void MinCost_Should_Return_MinCostByRemovingEachItemFromAnIntegerArray(int[] input, int expected)
        {
            // Act
            var actual = _sut.MinCost(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, -5, 3, 5, -10, 4}, 3)]
        [InlineData(new int[] { -3, 0, 2, 5 }, 1)]
        public void NobleNumberBruteForce_ShouldReturn_CountOfNobleNumber(int[] input, int expected)
        {
            // Act
            var actual = _sut.NobleNumberBruteForce(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, -5, 3, 5, -10, 4 }, 3)]
        [InlineData(new int[] { -3, 0, 2, 5 }, 1)]
        public void NobleNumber_ShouldReturn_CountOfNobleNumber(int[] input, int expected)
        {
            // Act
            var actual = _sut.NobleNumber(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { -3, 0, 2, 2, 5, 5, 5,5, 8, 8, 10,10,10,14 }, 3)]
        public void NobelNumberDuplicateValues_ShouldReturn_CountOfNobleNumber(int[] input, int expected)
        {
            // Act
            var actual = _sut.NobelNumberDuplicateValues(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 7, 0, 9, 3, 6, 0, 6 }, -1)]
        public void NobleNumber_Should_Validate_NobleNumber(int[] input, int expected )
        {
            var currentInput = input.ToList();
            var actual = _sut.NobleNumber(currentInput);
            Assert.Equal(expected, actual);
        }
        #endregion

        [Theory]
        [InlineData(310, 103)]
        [InlineData(-7605, -7650)]
        [InlineData(0, 0)]
        [InlineData(63, 36)]
        [InlineData(4099, 4099)]
        [InlineData(1000000000000000, 1000000000000000)]
        [InlineData(10000000000000001, 10000000000000001)]
        public void SmalestNumber_GivenArray_ReturnsSmalestNumber(long n, long expected)
        {
            var max = long.MaxValue;
            // Act
            var actual = _sut.SmallestNumber(n);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new int[] { 1, 2, 4, 3, 1, 4, 5, 1, 2 }, 
            new int[] { 1, 1, 1, 2, 2, 3, 4, 4, 5 })]
        public void SmalestNumberPositiveDigits_GivenArray_ReturnsSmalestNumber(int[] input, int[] result)
        {
            // Act
            var actual = _sut.SmallestNumberPositiveDigits(input);

            // Assert
            Assert.Equal(result, actual);
        }

        [Theory]
        [InlineData(new int[] { -2, 3, 8, 3, -1, 3 },
            new int[] { -2, -1, 3, 3, 3, 8 })]
        public void SmalestNumberWithNegative_GivenArray_ReturnsSmalestNumber(int[] input, int[] result)
        {
            // Act
            var actual = _sut.SmallestNumberWithNegative(input);

            // Assert
            Assert.Equal(result, actual);
        }

        [Theory]
        [InlineData(
            new[] { 1, 2, 3},
            new[] { 2, 5, 6 },
            new[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(
            new[] { 0, 2 },
            new[] { 0, 1 },
            new[] { 0, 0, 1, 2 })]
        [InlineData(
            new[] { 0, 0, 3 },
            new[] { -1, 1, 1, 1, 2, 3 },
            new[] { -1, 0, 0, 1, 1, 1, 2, 3, 3 })]
        [InlineData(
            new int[] {},
            new[] { 1, 2, 3, 4, 5 },
            new[] { 1, 2, 3, 4, 5 })]
        [InlineData(
            new int [] { },
            new[] { 1 },
            new[] { 1 })]
        public void MergeTwoArrays2_ShouldReturnMergedArray_AndKeepIndexItem(
            int[] list1, int[] list2, int[] expected)
        {
            var actual = _sut.MergeAllInboxEmails(list1, list2);

            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(
            new[] { 1, 2, 3, 2, 5, 6 }, 
            new[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(
            new[] { 0, 0, 2, 1 }, 
            new[] { 0, 0, 1, 2 })]
        [InlineData(
            new[] { -1, 0, 0, 1, 1, 1, 3, 2, 3 }, 
            new[] { -1, 0, 0, 1, 1, 1, 2, 3, 3 })]
        [InlineData(
            new[] { 1, 2, 3, 4, 5 },
            new[] { 1, 2, 3, 4, 5 })]
        [InlineData(
            new[] { 1 }, 
            new[] { 1 })]
        //[InlineData(
        //    new int[] { 4, 2, 5, 7 },
        //    new int[] { 4, 5, 2, 7})]
        public void SortArray_ShouldReturnMergedArray_AndKeepIndexItem(
            int[] list, int[] expected)
        {
            _sut.SortArray(list);
            Assert.Equal(expected, list);
        }

        [Theory]
        [InlineData(
            new[] { 1, 2, 3, 2, 5, 6 },
            new[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(
            new[] { 0, 0, 2, 1 },
            new[] { 0, 0, 1, 2 })]
        public void MergeSort_ShouldReturnMergedArray_AndKeepIndexItem(
            int[] list, int[] expected)
        {
            _sut.MergeSort(list, 0, list.Length - 1);
            Assert.Equal(expected, list);
        }
    }
}
