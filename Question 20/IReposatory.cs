using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_Ad01.Productfile
{
    internal interface IReposatory<T>
    {
        void Add(T item);

        T GetById(int id);

        IEnumerable<T> GetAll();

        void Delete(int id);

    }
}
