using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Farm<T> : IEnumerable<T> where T : Animal
    {
        private List<T> animals = new List<T>();

        public List<T> Animals { get { return animals; }  }

        public IEnumerator<T> GetEnumerator()
        {
            return animals.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return animals.GetEnumerator();
        }

        public void MakeNoises()
        {
            foreach (T item in animals)
            {
                item.MakeNoise();
            }
        }

        public void FeedTheAnimals()
        {
            foreach (T item in animals)
            {
                item.Feed();
            }
        }

        public Farm<Cow> GetCows()
        {
            Farm<Cow> cows = new Farm<Cow>();

            foreach (T item in animals)
            {
                if (item is Cow)
                {
                    cows.animals.Add(item as Cow);
                }
            }

            return cows;
        }

        public Farm<U> Specifies<U>() where U : T
        {
            Farm<U> us = new Farm<U>();

            foreach (T item in animals)
            {
                if (item is U)
                {
                    us.animals.Add(item as U);
                }
            }

            return us;
        }
    }
}
