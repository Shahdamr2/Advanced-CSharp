using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_.Interface
{
    internal interface IRepository<T>
    {
        void Add(T item);
        List<T> GetAll();
        T GetById(int id);
        void delete(int id);
    }
}
