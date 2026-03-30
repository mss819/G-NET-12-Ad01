using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_Ad01
{
    internal class Question_7 <T> where T : struct
    {
        public T Value { get; set; }
        public Question_7(T value )
        {
            Value = value;
        }
    }
}
