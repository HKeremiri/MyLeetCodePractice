using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class _45_Jump_Game_II
    {
        public int Jump(int[] nums)
        {
            int highest = 0;
            int count = 0;
            for(int i = 0; i < nums.Length; i += highest)
            {
                for(int j = i + 1; j < nums[i];j++)
                {
                    if (nums[j] > highest)
                    {
                        highest = nums[j];
                    }
                }
                count++;
            }
            return count;
        }
    }
}
