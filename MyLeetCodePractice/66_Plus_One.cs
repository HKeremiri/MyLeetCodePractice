using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class _66_Plus_One
    {
        public int[] PlusOne(int[] digits)
        {
            string number = "";
            foreach (var i in digits)
            {
                number += i.ToString();
            }
            int numberint = Convert.ToInt32(number);
            numberint++;
            number = numberint.ToString();
            int[] result = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                result[i] = int.Parse(number[i].ToString());
            }
            return result;
        }
    }
}
