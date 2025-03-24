using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class _88_Merge_Sorted_Array
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            Array.Copy(nums2, 0, nums1, m, n);
            Array.Sort(nums1);
        }
    }
}
