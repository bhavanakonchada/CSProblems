using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSProblems.Greedy
{
    class NMeetingsInOneRoom
    {
        public static void Main()
        {
            Console.WriteLine($"There is one meeting room in a firm. There are N meetings in the form of (S[i], F[i]) " +
                $"where S[i] is start time of meeting i and F[i] is finish time of meeting i.");

            var startTimes = new List<int> { 43, 50, 75, 89, 112, 275, 508, 779 };
            var endTimes = new List<int> { 81, 114, 111, 93, 543, 355, 733, 1602 };

            var currentTime = 0;
            var meetingCount = 0;

            var count = CalculateMeetings(startTimes, endTimes, 0, currentTime, meetingCount, string.Empty);

            Console.WriteLine($"Max possible meetings in this room are: "+ count);

            Console.ReadLine();
        }

        private static int CalculateMeetings(List<int> startTimes, List<int> endTimes, int currentCount, int currentTime, int meetingCount, string result)
        {
            //breaking condition
            if (currentTime >= endTimes.Last() || currentCount >= endTimes.Count)
            {
                Console.WriteLine($"CurrentCount is {currentCount}, Meeting Count is {meetingCount} and result is {result}");
                return meetingCount;
            }

            //if this entry can be considered...
            else if (startTimes[currentCount] >= currentTime)
            {
                var selectedCurrentTime = endTimes[currentCount];
                var newCurrentCount = currentCount + 1;
                var unselectedCurrentTime = currentTime;

                //take a decision - to consider it, or to not consider it..
                return Math.Max(CalculateMeetings(startTimes, endTimes, newCurrentCount, selectedCurrentTime, meetingCount+1, result + $"{startTimes[currentCount]},{endTimes[currentCount]}.."),
                        CalculateMeetings(startTimes, endTimes, newCurrentCount, unselectedCurrentTime, meetingCount, result));
            }
            else
            {
                currentCount++;
                //cannot take a decision - so increment the current Count and continue the process - to consider it, or to not consider it..
                return CalculateMeetings(startTimes, endTimes, currentCount, currentTime, meetingCount, result);
            }
        }
    }
}
