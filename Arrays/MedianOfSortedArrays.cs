using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSProblems.Arrays
{
    /*
     * Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

        Follow up: The overall run time complexity should be O(log (m+n)).

        Example 1:
        Input: nums1 = [1,3], nums2 = [2]
        Output: 2.00000
        Explanation: merged array = [1,2,3] and median is 2.

        Example 2:
        Input: nums1 = [1,2], nums2 = [3,4]
        Output: 2.50000
        Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
        Example 3:

        Input: nums1 = [0,0], nums2 = [0,0]
        Output: 0.00000
        Example 4:

        Input: nums1 = [], nums2 = [1]
        Output: 1.00000
     */
    class MedianOfSortedArrays
    {
        public static void Main()
        {
            int[] nums1 = new int[] { 1, 2, 3, 4, 5 };
            int[] nums2 = new int[] { 2, 4, 8, 9 };

            int[] mergedArray = new int[nums1.Length + nums2.Length];

            //the algorithm that can do this in Olog(m+n) is merge sort

            int p1 = 0, p2 = 0, p3 = 0;

            while(p1 < nums1.Length && p2 < nums2.Length)
            {
                if(nums1[p1]< nums2[p2])
                {
                    mergedArray[p3] = nums1[p1];
                    p1++;
                    p3++;
                }
                else
                {
                    mergedArray[p3] = nums2[p2];
                    p2++;
                    p3++;
                }
            }

            if (p1 < nums1.Length)
            {
                while (p1 < nums1.Length)
                {
                    mergedArray[p3] = nums1[p1];
                    p1++;
                    p3++;
                }
            }
            else
            {
                while (p2 < nums2.Length)
                {
                    mergedArray[p3] = nums2[p2];
                    p2++;
                    p3++;
                }
            }

            Console.WriteLine("Merged array is:");
            ArraySorting.PrintArray(mergedArray);

            if(mergedArray.Length % 2 == 0)
            {
                //array is even
                int mid = mergedArray.Length / 2;

                Console.WriteLine("Median is:" + (mergedArray[mid - 1] + mergedArray[mid]) / 2);
            }

            Console.WriteLine("Median is:" + (mergedArray[(mergedArray.Length - 1)/2]));

            Console.ReadLine();
        }
    }
}
