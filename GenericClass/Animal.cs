using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public abstract class Animal
    {
        protected string name;
        public string Name { get { return name; } set { name = value; } }

        public Animal()
        {
            name = "Animal with no name";
        }
        public Animal(string newName)
        {
            name = newName;
        }

        public void Feed() => Console.WriteLine($"{name} has been feed!");

        public abstract void MakeNoise();
    }
}
