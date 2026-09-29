using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_.Interface
{
    interface IPrinter<in T>
    {
        void Print(T item);
    }
}
