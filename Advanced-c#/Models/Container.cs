using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_.Models
{
    internal class Container<T>
    {
        private T? _value;

        
        public void Add(T value) => _value = value;
        public T? Get() => _value;
    }
}
