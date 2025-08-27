using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode.Array_String
{
    public class MergeSortedArray88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m + n - 1; i >= n; i--)
            {
                nums1[i] = nums1[i - n];
            }

            int arr1Index = 0 + n, arr2Index = 0;
            for (int i = 0; i < m + n; i++)
            {
                if (arr1Index >= m + n)
                    nums1[i] = nums2[arr2Index++];
                else if (arr2Index >= n)
                    nums1[i] = nums1[arr1Index++];
                else if (nums1[arr1Index] <= nums2[arr2Index])
                    nums1[i] = nums1[arr1Index++];
                else
                    nums1[i] = nums2[arr2Index++];
            }
        }
    }
}