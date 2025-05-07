namespace Algorithms.Assignment.Module1
{
    public class Session22HashingBasicsAssignment
    {
        // Student attendance record
        // Solution:
        // Use frequency map to count the number of times each student appears in the attendance list.
        // Find Frequency count described here: https://www.geeksforgeeks.org/frequency-count/
        // T.C = O(n)
        // S.C = O(n)
        // Similar problem: http://leetcode.com/problems/student-attendance-record-i/
        public int[] StudentAttendance(int[] students, int[] attendance)
        {
            // Create a dictionary to store the attendance of each student
            Dictionary<int, int> attendanceDict = new Dictionary<int, int>();

            // Iterate through the students array and initialize their attendance to 0
            foreach (int student in students)
            {
                attendanceDict[student] = 0;
            }

            // Iterate through the attendance array and update the attendance for each student
            foreach (int student in attendance)
            {
                if (attendanceDict.ContainsKey(student))
                {
                    attendanceDict[student]++;
                }
            }

            // Convert the dictionary values to an array and return it
            return attendanceDict.Values.ToArray();
        }
    }
}
