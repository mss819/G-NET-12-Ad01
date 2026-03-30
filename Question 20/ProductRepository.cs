using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_Ad01.Productfile
{
    internal class ProductRepository : Ireposatory<Product>
    {
        private readonly List<Product> _products = new();
        public void Add(Product item)
            => _products.Add(item);


        public void Delete(int id)
        {
            var product = GetById(id);
            if (product == null) return;
            _products.Remove(product);
        }

        public void Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
            => _products;


        public Product GetById(int id)
            => _products.Find(p => p.Id == id);
    }
}
