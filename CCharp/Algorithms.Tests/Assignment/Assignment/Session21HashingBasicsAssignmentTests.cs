using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Assignment.Module1;

namespace Algorithms.Tests.Assignment.Assignment
{
    public class Session21HashingBasicsAssignmentTests
    {
        private Session21HashingBasicsAssignment _sut;

        public Session21HashingBasicsAssignmentTests()
        {
            _sut = new Session21HashingBasicsAssignment();
        }

        // add test for the StudentAttendance
        [Theory]
        [InlineData(new[] { 1, 2, 3, 1, 1, 2, 7 }, new int[] {1, 2, 3}, new int[] {3, 2, 1, 0})]
        public void StudentAttendance_ShouldReturn_TheStudentAttendance(int[] attendance, int[] students, int[] expected)
        {
            var result = _sut.StudentAttendance(students, attendance);
            Assert.Equal(expected, result);
        }
    }
}
