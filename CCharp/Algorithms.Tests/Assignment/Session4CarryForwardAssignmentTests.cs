using Algorithms.Sessions;

namespace Algorithms.Tests.Assignment
{
    public class Session4CarryForwardAssignmentTests
    {
        [Theory]
        [InlineData("baagdcag", 5)]
        [InlineData("bagagg", 5)]
        [InlineData("acgdgag", 4)]
        public void CountPairsOfCharOneAndChar2BruteForce_Should_CountAllPairsForToGivenChars_InAString(string s,
            int expected)
        {
            var sut = new Session4CarryForward();
            var actual = sut.CountPairsOfCharOneAndChar2BruteForce(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("baagdcag", 5)]
        [InlineData("bagagg", 5)]
        [InlineData("acgdgag", 4)]
        public void CountPairsOfCharOneAndChar2Back_Should_CountAllPairsForToGivenChars_InAString(string s,
            int expected)
        {
            var sut = new Session4CarryForward();
            var actual = sut.CountPairsOfCharOneAndChar2Back(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("baagdcag", 5)]
        [InlineData("bagagg", 5)]
        [InlineData("acgdgag", 4)]
        public void CountPairsOfCharOneAndChar2_Should_CountAllPairsForToGivenChars_InAString(string s, int expected)
        {
            var sut = new Session4CarryForward();
            var actual = sut.CountPairsOfCharOneAndChar2(s);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(new int[] { 3, 2, 4, 5, 2, 7, -1, 15 }, 5)]
        [InlineData(new int[] { 4, 2, 3, 9, 7, 10 }, 3)]
        public void LeadersBruteForce_SoundCount_LeadersInAnIntegerArray(int[] input, int expected)
        {
            var sut = new Session4CarryForward();
            var actual = sut.LeadersBruteForce(input);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(new int[] { 3, 2, 4, 5, 2, 7, -1, 15 }, 5)]
        [InlineData(new int[] { 4, 2, 3, 9, 7, 10 }, 3)]
        public void Leaders_SoundCount_LeadersInAnIntegerArray(int[] input, int expected)
        {
            var sut = new Session4CarryForward();
            var actual = sut.Leaders(input);
            Assert.Equal(expected, actual);

        }
    }
}
