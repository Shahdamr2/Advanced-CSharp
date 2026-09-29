using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_.Models
{
    class Product
    {
        public string Name { get; set; } = "";
    }

    class NumberContainer<T> where T : new()
    {
        public T Value { get; set; } = new T();
    }
}
