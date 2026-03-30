using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_Ad01
{
    internal class Question_8<T> where T : class
    {

        public T Value { get; set; }
        public Question_8(T value)
        {
            Value = value;
        }
    }
}
