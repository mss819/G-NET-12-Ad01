using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_Ad01
{
    internal class Question_5
    {
        public static void Printarr<T>(T[] items) 
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static T findMax<T>(T[] items) where T : IComparable<T>
        {
            T max = items[0];

            foreach (var item in items)
            {
                if(item.CompareTo(max) > 0)
                    max = item;
            }
            return max;
        }
    }
}
