using Advanced_c_.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Advanced_c_.Models;
using Advanced_c_.Interface;

namespace Advanced_c_.Models
{
    class AnimalPrinter : IPrinter<Animal>
    {
        public void Print(Animal item)
        {
            Console.WriteLine(item.Name);
        }
    }
}
