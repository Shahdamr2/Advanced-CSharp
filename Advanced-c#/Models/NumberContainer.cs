using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_.Models
{
    class NumberContainer<T> where T : struct
    {
        public T Value { get; set; }
    }
}
