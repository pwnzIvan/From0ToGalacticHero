using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLesson
{
    static class StringExtension
    {
        public static bool IsPalindrome(this string text)
        {
            return check(0, text.Length - 1);
            bool check(int lo, int hi)
            {
                if (lo >= hi) return true;
                if (text[lo] != text[hi]) return false;
                return check(lo + 1, hi - 1);
            }
        }
    }
}
