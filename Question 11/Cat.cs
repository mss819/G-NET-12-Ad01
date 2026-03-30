using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_Ad01.Question_11
{
    internal class Cat : Animal
    {

        public Cat()
        {
            Name = "Cat";
        }
        public Cat(string name)
        {
            Name = name;
        }
        public override string speak()
            => "Meow";
    }
}
