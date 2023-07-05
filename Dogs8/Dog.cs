using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs8
{
    class Dog : IComparable<Dog>
    {
        public Breeds Breed { get; set; }
        public string Name { get; set; }

        public int CompareTo(Dog other)
        {
            if (Breed < other.Breed) return -1;
            if (Breed > other.Breed) return 1;
            return -Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"A {Breed} name {Name}.";
        }
    }
}
