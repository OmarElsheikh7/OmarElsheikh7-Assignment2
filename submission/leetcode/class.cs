using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            var r = s.Length - 1;
            var l = 0;

            while (r > l)
            {
                char temp;

                temp = s[l];
                s[l] = s[r];
                s[r] = temp;

                r--;
                l++;
            }

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

        }
    }
}
