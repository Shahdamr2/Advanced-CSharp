using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_.Models
{
    class NumberContainer<T> where T : class
    {
        public T Value { get; set; }
    }
    
}
