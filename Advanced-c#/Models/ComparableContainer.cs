using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_.Models
{
    public class ComparableContainer<T>
       where T : class, IComparable<T>, new()
    {
        public T Create()
        {
            return new T();
        }
    }
}
