using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs8
{
    class Program
    {
        static void Main()
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog() { Breed = Breeds.Dachshund, Name = "Franz" },
                new Dog() { Breed = Breeds.Collie, Name = "Petunia"},
                new Dog() { Breed = Breeds.Pug, Name = "Porkchop"},
                new Dog() { Breed = Breeds.Dachshund, Name = "Brunhilda"},
                new Dog() { Breed = Breeds.Collie, Name = "Zippy" },
                new Dog() { Breed = Breeds.Corgi, Name = "Carrie"},
            };
            dogs.Sort();
            foreach(Dog dog in dogs)
            {
                Console.WriteLine(dog);
            }
        }
    }
}
