using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class _55_Jump_Game
    {        public bool CanJump(int[] nums)
        {
            int i = 0;
            do
            {
                if (nums[i] == 0)
                {
                    return false;
                }
                i += nums[i];
            }
            while (i < nums.Length);            
            return true;
        }
    }
}
