using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class _172_Factorial_Trailing_Zeroes
    {
        public int TrailingZeroes(int n)
        {
            int fact = 1;
            int k = 1;
            for (int i = n; i > 1; i--)
            {
                if(fact == 1)
                {
                    fact *= i;
                }
                else
                {
                 fact *= (n - k);
                k++;
                }
                
            }
            int j = 0;
            while (fact % 10 == 0)
            {
                j++;
                fact /= 10;
            }
            if (j > 0)
            {
                return j;
            }
            return 0;
        }
    }
}
