using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_.Models
{
    internal class Utility<T>
    {
        public static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
