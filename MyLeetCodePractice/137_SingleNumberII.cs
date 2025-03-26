using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class _137_SingleNumberII
    {
        public int SingleNumber(int[] nums)
        {
            return nums.GroupBy(x => x).Where(g => g.Count() == 1).Select(x => x.Key).FirstOrDefault();
        }
    }
}
