using System;
using System.Collections.Generic;
using System.Text;
using Advanced_c_.Interface;

namespace Advanced_c_.Repository
{
    internal class ProductRepository : IRepository<ProductRepository>
    {
        public void Add(ProductRepository  item)
        {
            
        }
        public List<ProductRepository> GetAll()
        {
            throw new NotImplementedException();
        }
        public ProductRepository GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
