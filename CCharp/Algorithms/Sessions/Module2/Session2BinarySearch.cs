namespace Algorithms.Sessions.Module2
{
    public class Session2BinarySearch
    {
        /// <summary>
        /// </summary>
        /// <param name="boards"></param>
        /// <param name="unitTime"></param>
        /// <param name="totalTime"></param>
        /// <returns></returns>
        public int CountPaintersToFillBoards(int[] boards, int unitTime, int totalTime)
        {
            var count = 1;
            var remainingTime = totalTime;

            for (var i = 0; i < boards.Length; i++)
            {
                var paintBordTime = boards[i] * unitTime;
                if (paintBordTime > totalTime)
                    return -1;

                if (paintBordTime > totalTime)
                    return -1;

                if (paintBordTime <= remainingTime)
                {
                    remainingTime -= paintBordTime;
                }
                else
                {
                    count++;
                    remainingTime = totalTime - paintBordTime;
                }
            }

            return count;
        }

        /// <summary>
        /// Source: https://www.geeksforgeeks.org/painters-partition-problem/
        /// Source: https://www.geeksforgeeks.org/the-painters-partition-problem-using-binary-search/
        /// </summary>
        /// <param name="boards"></param>
        /// <param name="painters"></param>
        /// <param name="unitTime"></param>
        /// <returns></returns>
        public int FindTimeToPaintBoard(int[] boards, int painters, int unitTime)
        {
            var left = 0;
            var right = 0;

            for (var i = 0; i < boards.Length; i++)
            {
                right += boards[i] * unitTime;
                left = Math.Max(left, boards[i] * unitTime);
            }

            var result = 0;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var countMid = CountPaintersToFillBoards(boards, mid, unitTime);
                var countMidLeft = CountPaintersToFillBoards(boards, mid, unitTime);
                if(countMid <= painters && countMidLeft > painters)
                {
                    return mid;
                }

                if (countMid <= painters)
                {
                    result = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return result;
        }


        /// <summary>
        /// Aggressive Cows
        /// Source: https://www.geeksforgeeks.org/aggressive-cows/
        /// T.C = O(n * log(n))
        /// </summary>
        /// <param name="stalls"></param>
        /// <param name="cows"></param>
        /// <returns></returns>
        public int AggressiveCows(int[] stalls, int cows)
        {
            Array.Sort(stalls);
            var left = 1;
            var right = stalls[stalls.Length - 1] - stalls[0];
            var result = 0;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (IsFeasible(stalls, cows, mid))
                {
                    result = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }

        private bool IsFeasible(int[] stalls, int cows, int minDist)
        {
            var count = 1;
            var lastStall = stalls[0];

            for (var i = 1; i < stalls.Length; i++)
            {
                if (stalls[i] - lastStall >= minDist)
                {
                    count++;
                    lastStall = stalls[i];
                }
            }

            return count >= cows;
        }
    }
}