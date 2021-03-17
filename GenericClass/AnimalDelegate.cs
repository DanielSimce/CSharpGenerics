using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class AnimalDelegate
    {
        public static int Compare(Animal x,Animal y)
        {
            return Comparer.Default.Compare(x.Name, y.Name);
        }
    }
}
