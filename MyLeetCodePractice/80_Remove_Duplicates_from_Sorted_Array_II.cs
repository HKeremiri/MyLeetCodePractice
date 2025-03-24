using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class _80_Remove_Duplicates_from_Sorted_Array_II
    {
        public int RemoveDuplicates(int[] nums)
        {

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (int item in nums)
            {
                if (keyValuePairs.ContainsKey(item))
                {

                    if (keyValuePairs[item] < 2)
                    {
                        keyValuePairs[item]++;
                    }
                }
                else
                {
                    keyValuePairs.Add(item, 1);
                }
            }
            int lastindex = 0;
            foreach (var item in keyValuePairs)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    nums[lastindex] = item.Key;
                    lastindex++;
                }
            }
            Console.WriteLine(lastindex);
            return lastindex;
        }
    }
}
