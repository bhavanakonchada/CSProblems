using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CSProblems.Greedy
{
    class ActivitySelection
    {
        public static void Main()
        {
            Console.WriteLine($"Given N activities with their start and finish times." +
                $" Select the maximum number of activities that can be performed by a single person," +
                $" assuming that a person can only work on a single activity at a time.");

            var startTimes = new List<int> { 1, 2, 3, 5, 8, 6 };
            var endTimes = new List<int> { 2, 4, 6, 7, 9, 9 };

            var activityTimes = new Dictionary<int, int>();
            //var selectedActivities = new Dictionary<int, int>();
            //for (int i = 0; i < startTimes.Count; i++)
            //{
            //    activityTimes.Add(startTimes[i], endTimes[i]);
            //}

            int i = 0;
            //pick the first one
            Console.WriteLine($"{startTimes[i]},{endTimes[i]} ");

            for (int j = 1; j < startTimes.Count; j++)
            {
                if (startTimes[j] >= endTimes[i])
                {
                    Console.WriteLine($"{startTimes[j]},{endTimes[j]} ");
                    i = j;
                }
            }
            Console.ReadLine();
        }
    }
}
