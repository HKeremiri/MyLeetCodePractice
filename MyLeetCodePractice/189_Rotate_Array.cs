using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class _189_Rotate_Array
    {
        public void Rotate(int[] nums, int k)
        {
            for (int i = 1; i <= k; i++)
            {
                int[] newarray = new int[nums.Length];
                newarray[0] = nums[^1];
                Array.Copy(nums, 0, newarray, 1, nums.Length - 1);
                for (int j = 0; j < nums.Length; j++)
                {
                    nums[j] = newarray[j];
                }
            }
            foreach(var i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}