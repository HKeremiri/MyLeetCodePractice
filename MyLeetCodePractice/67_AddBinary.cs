using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class _67_AddBinary
    {
        public string AddBinary(string a, string b)
        {

            int sum = Convert.ToInt16(a, 2) + Convert.ToInt16(b, 2);
            return Convert.ToString(sum, 2);
         
        }
    }
}
