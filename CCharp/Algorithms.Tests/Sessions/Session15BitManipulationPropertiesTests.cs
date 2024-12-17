using Algorithms.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTests.Course.Class
{
    public class Session15BitManipulationPropertiesTests
    {
        //[Theory]
        //[InlineData(14, 2, 1110)]
        //[InlineData(14, 3, 211)]
        //public void ConvertInBaseX_WillReturn_TheNumberInBaseX(int n, int x, int expected)
        //{
        //    var sut = new Session11BitManipulation();
        //    var result = sut.ConvertPositiveInBaseX(n, x);
        //    Assert.Equal(expected, result);
        //}
        private Session15BitManipulationProperties _sut;
        public Session15BitManipulationPropertiesTests()
        {
            _sut = new Session15BitManipulationProperties();
        }

        //[Theory]
        //[InlineData(11, 1)]
        //[InlineData(12, 0)]
        //public void LastSignificantBit_WillReturn_TheNumberInBaseX(int x, int expected)
        //{
        //    var sut = new Session11BitManipulation();
        //    var result = sut.LastSignificantBit(x);
        //    Assert.Equal(expected, result);
        //}

        //[Theory]
        //[InlineData(11, "Odd")]
        //[InlineData(12, "Even")]
        //public void CheckEvenNunberBit_WillReturn_TheNumberInBaseX(int x, string expected)
        //{
        //    var sut = new Session11BitManipulation();
        //    var result = sut.CheckEvenNunberBit(x);
        //    Assert.Equal(expected, result);
        //}

        [Theory]
        [InlineData(new[] { 1, 2, 3, 2, 5, 5, 1 }, 3)]
        [InlineData(new[] { 1, 2, 11, 2, 5, 5, 1 }, 11)]
        public void FindSingleNumbertBruteForce_ShouldReturn_TheSingleNumber(int[] input, int expected)
        {
            var result = _sut.FindSingleNumberClasicApproach(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 0, 1, 0, 1, 0, 1, 99 }, 99)]
        [InlineData(new[] { 1, 1, 2, 2, 3, 2, 5, 5, 1, 5 }, 3)]
        public void SingleNumber2_ShouldReturn_TheSingleNumber(int[] input, int expected)
        {
            var result = _sut.SingleNumber2(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 11, 2, 5, 5, 1 }, 2, 11)]
        [InlineData(new[] { 0, 1, 0, 1, 0, 1, 99 }, 3, 99)]
        [InlineData(new[] { 1, 1, 2, 2, 3, 2, 5, 5, 1, 5, 1, 2, 5}, 4, 3)]
        public void SingleNumberGeneralisation_ShouldReturn_TheSingleNumber(int[] input, int k, int expected)
        {
            var result = _sut.SingleNumberGeneralisation(input, k);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 5, 2, 2, 1, 5 }, 1)]
        [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
        public void FindSingleNumber_ShouldReturn_TheSingleNumberInTheArray(int[] nums, int expected)
        {
            var result = _sut.FindSingle2(nums);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 1, 2, 2, 3, 2, 5, 5, 1, 5 }, 3)]
        public void FindSingle3_ShouldReturn_TheSingleNumberInTheArray(int[] nums, int expected)
        {
            var result = _sut.FindSingle3(nums);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 2, 5, 1, 5, 11 }, new [] { 3, 11 })]
        public void FindSingleTwoNo_ShouldReturn_TheTwoSingleNumbersInTHeArray(int[] nums, int[] expected)
        {
            var result = _sut.FindSingleTwoNo(nums);
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(5, 1, 0)]
        [InlineData(5, 0, 1)]
        public void FindIthBit_ShouldReturn_TheNumberWithIthBitSet(int n, int i, int expected)
        {
            var result = _sut.FindIthBit(n, i);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 1, 7)]
        [InlineData(45, 4, 61)]
        [InlineData(45, 2, 45)]
        public void SetIthBit_ShouldReturn_TheNumberWithIthBitSet(int n, int i, int expected)
        {
            var result = _sut.SetIthBit(n, i);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(45, 4, 61)]
        [InlineData(45, 2, 41)]
        public void ToggleIthBit_ShouldReturn_TheNumberWithIthBitToggled(int n, int i, int expected)
        {
            var result = _sut.ToggleIthBit(n, i);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 0, 4)]
        [InlineData(61, 4, 45)]
        [InlineData(45, 2, 41)]
        public void ClearIthBit_ShouldReturn_TheNumberWithIthBitSet(int n, int i, int expected)
        {
            var result = _sut.ClearIthBit(n, i);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 0, 1)]
        [InlineData(5, 1, 0)]
        public void CheckIthBit_ShouldReturn_TheIthBit(int n, int i, int expected)
        {
            var result = _sut.CheckIthBit(n, i);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 0, true)]
        [InlineData(5, 1, false)]
        public void IsIthBitSet_ShouldReturn_TheIthBit(int n, int i, bool expected)
        {
            var result = _sut.IsIthBitUnset(n, i);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 2)]
        [InlineData(45, 4)]
        public void CountOneBitsFor32Bit_ShouldReturn_TheNumberOfSetBitForAPositiveNumber(int n,  int expected)
        {
            var result = _sut.CountOneBitsFor32Bit(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(13, 3)]
       
        public void CountDigitOne_ShouldReturn_TheNumberOfSetBitForAPositiveNumber(int n, int expected)
        {
            var result = _sut.CountDigitOne(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 2, 1, 3)]

        public void GenerateIntWithTheGivvenNumberOfBitsAZerosBOnesCZeros_Should_ConstructNumber(
            int a, 
            int b,
            int c,
            int expected)
        {
            var result = _sut.GenerateIntWithTheGivenNumberOfBitsAZerosBOnesCZeros(a, b, c);
            Assert.Equal(expected, result);
        }



        #region recursion

        [Theory]
        [InlineData(5, "1 2 3 4 5")]
        public void PrintNS_Should_printAllNumbersFrom1ToN(int n, string expected)
        {
            var sut = new Session16RecursionBasic();
            var result = sut.PrintNatural(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, "1 2 3 4 5")]
        public void PrintNS2_Should_printAllNumbersFrom1ToN(int n, string expected)
        {
            var sut = new Session16RecursionBasic();
            sut.PrintNatural2(n);
        }

        [Theory]
        [InlineData(5, "5 4 3 2 1")]
        public void PrintNS3_Should_printAllNumbersFrom1ToN(int n, string expected)
        {
            var sut = new Session16RecursionBasic();
            var result = sut.PrintNaturalDecrease(n);
            Assert.Equal(expected, result);
        }
        #endregion
    }
}
