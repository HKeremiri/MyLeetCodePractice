using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class _9_Palindrome_Number
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            string number = x.ToString();
            char[] reversed = number.Reverse().ToArray();
            string reversedstring = new string(reversed);
            if (number == reversedstring)
            {
                return true;
            }
            return false;
        }
    }
}
