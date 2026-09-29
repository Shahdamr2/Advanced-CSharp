using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_.Models
{
    class Counter<T>
    {
        public static int Count = 0;

        public Counter()
        {
            Count++;
        }
    }
}
