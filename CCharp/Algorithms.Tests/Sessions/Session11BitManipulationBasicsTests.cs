using Algorithms.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTests.Course.Class
{
    public class Session11BitManipulationBasicsTests
    {
        private Session11BitManipulationBasics _sut;
        public Session11BitManipulationBasicsTests()
        {
            _sut = new Session11BitManipulationBasics();
        }

        [Theory]
        [InlineData(14, 2, 1110)]
        [InlineData(14, 3, 211)]
        [InlineData(100, 7, 202)]
        public void ConvertPositiveInBaseX_WillReturn_TheNumberInBaseX(int n, int x, int expected)
        {
            var result = _sut.ConvertPositiveInBaseX(n, x);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-7, 7, -10)]
        [InlineData(14, 2, 1110)]
        [InlineData(14, 3, 211)]
        [InlineData(100, 7, 202)]
        public void ConvertInBaseX_WillReturn_TheNumberInBaseX(int n, int x, int expected)
        {
            var result = _sut.ConvertInBaseX(n, x);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("10101", "1101", "100010")]
        public void AddBinary_ShouldReturn_TheSumOfTwoBinaryNumbers(string a, string b, string expected)
        {
            // 10101
            //  1101
            //     0
            var sut = new Session11BitManipulationBasics();
            var result = sut.AddBinary(a, b);
            Assert.Equal(expected, result);
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

    }
}
