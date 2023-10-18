using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_task
{
    public static class ExtensionMethods
    {
        //public static bool CustomContains(this string str, char c) { }

        public static bool IsPrime(this int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //public static bool IsPowOfTwo(this int num) { }

    }

    
}

