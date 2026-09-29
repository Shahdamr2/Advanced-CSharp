using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_.Models
{
    public class AnimalContainer<T> where T : Animal
    {
        public T Value { get; set; } = default!;
    }
}
