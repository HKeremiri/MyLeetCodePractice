using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class _191_NumberOfBits
    {
        public int HammingWeight(int n)
        {
            int count = 0;
            string bits = Convert.ToString(n, 2);
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '1')
                {
                    count++;
                }
            }
            return count;
        }
    }
}