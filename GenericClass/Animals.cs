using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Animals : List<Animal>
    {
        public Animals()
        {

        }

        public Animals(IEnumerable<Animal> animals)
        {
            foreach (Animal item in animals)
            {
                Add(item);
            }
        }
    }
}
