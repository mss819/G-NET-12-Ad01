using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_Ad01.GenericInheritance
{
    internal class GenericRepository<T> : IRepository<T> where T : class
    {
        List<T> _list = [];
        public void Add(T entity)
            => _list.Add(entity);


        public List<T> GetAll()
            => _list;

    }
}
