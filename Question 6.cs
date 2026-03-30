using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_Ad01
{
    internal interface Ireposatory<T>
    {
        void Add (T item);
        void Delete (T item);
        T GetById (int id);
        IEnumerable<T> GetAll ();
    }
}
