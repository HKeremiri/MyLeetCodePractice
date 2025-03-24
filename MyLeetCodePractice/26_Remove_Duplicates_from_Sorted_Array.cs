using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class _26_Remove_Duplicates_from_Sorted_Array
    {
        public int RemoveDuplicates(int[] nums)
        {
            int k = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            nums[k] = nums[nums.Length - 1];
            k++;
            Console.WriteLine(k);
            return k;
        }
    }
}
