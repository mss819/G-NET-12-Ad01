using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_Ad01.Question_11
{
    internal class AnimalShelter<T> where T : Animal 
    {
        private List<T> animals = new();
        public void Add(T animal)
            => animals.Add(animal);
        public void MakeAllSpeak()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name} says: {animal.speak()}");
            }
        }
    }
}
