using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class _169_Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            int count = 0;
            Array.Sort(nums);
            int highestnumber = nums[nums.Length / 2];
            return highestnumber;
        }
    }
}
