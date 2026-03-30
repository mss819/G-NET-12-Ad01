using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace G_NET_12_Ad01.Question_11
{
    internal class Dog:Animal
    {
        public Dog()
        {
            Name = "Cat";
        }
        public Dog(string name)
        {
            Name = name;
        }
        public override string speak()
            => "woof";
    }
}
