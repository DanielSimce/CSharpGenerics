using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class SuperCow : Cow
    {
        public void Fly()
        {
            Console.WriteLine($"{name} is flying!");
        }

        public SuperCow(string newName):base(newName) { }

        public override void MakeNoise()
        {
            Console.WriteLine($"{name} here i come to save the day!");
        }
    }
}
