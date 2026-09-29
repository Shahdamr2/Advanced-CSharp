using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_.Models
{
    class Pair<T>
    {
        public T First { get; set; }
        public T Second { get; set; }

        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }

        public void Display()
        {
            Console.WriteLine($"First: {First}");
            Console.WriteLine($"Second: {Second}");
        }
    }
}

