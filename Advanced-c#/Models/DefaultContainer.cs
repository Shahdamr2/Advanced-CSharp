using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_.Models
{
    internal class DefaultContainer<T>
    {
        public T GetDefault()
        {
            return default!;
        }
    }
}
