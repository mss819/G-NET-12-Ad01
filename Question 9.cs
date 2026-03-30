using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_Ad01
{
    internal class Question_9<T> where T : new()
    {
        public T Create() {

            return new T();
         }
    }
}
