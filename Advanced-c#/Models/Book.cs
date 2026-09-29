using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_.Models
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; } = "";

        public int CompareTo(Book? other)
        {
            if (other == null)
                return 1;

            return Title.CompareTo(other.Title);
        }
    }
}
