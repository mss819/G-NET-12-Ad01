using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_Ad01
{
    internal class Question_4
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temb = a;
            a = b;
            b = temb;

        }

}   }
