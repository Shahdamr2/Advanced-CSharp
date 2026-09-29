using Advanced_c_.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_c_.Repository
{
    internal class Printer<T> where T : IPrintable
    {
        public void Print(T item)
        {
            item.Print();
        }
    }
}
