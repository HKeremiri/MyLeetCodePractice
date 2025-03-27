using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class _69_Sqrt_x_
    {
        public int MySqrt(int x)
        {
            Dictionary<int, int> pozitifbolenler = new Dictionary<int, int>();
            int kokdencikan = 1;
            int j = 2;
            while (x > 1)
            {
                if (x % j == 0)
                {
                    if(pozitifbolenler.ContainsKey(j))
                    {
                        pozitifbolenler[j]++;
                    }
                    else
                    {
                        pozitifbolenler.Add(j, 1);
                    }                    
                    x /= j;
                    continue;
                }
                j++;
            }
            foreach (var i in pozitifbolenler)
            {
                int us = i.Value / 2;
                for (int k = 0; k < us; k++)
                {
                    kokdencikan *= i.Key;
                }
            }
            return kokdencikan;

        }
    }
}
