using Advanced_c_.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_c_.Repository
{
    class Product : IPrintable
    {
        public string Name { get; set; } = "";

        public void Print()
        {
            Console.WriteLine(Name);
        }
    }

}
