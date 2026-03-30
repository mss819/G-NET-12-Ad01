using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_Ad01.GenericInheritance
{
    internal interface IRepository<T> where T : class
    {
        void Add(T entity);
        List<T> GetAll();
    }
}
