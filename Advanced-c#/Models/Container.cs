using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_.Models
{
    internal class Container<T>
    {
        public T Value { get; set; } = default!;

        public void Display()
        {
            Console.WriteLine("Value: " + Value);
        }


        //public void Add(T value) => _value = value;
        //public T? Get() => _value;

    }
}
