using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals();
            animals.Add(new Cow("Simce"));
            animals.Add(new SuperCow("Daniel"));
            animals.Add(new Chicken("BMIKI"));
            animals.Add(new Chicken("TOMI"));
            animals.Add(new Cow("ATEO"));


            foreach (var item in animals)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();

            animals.Sort(AnimalDelegate.Compare);
            foreach (var item in animals)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
            Farm<Animal> animals1 = new Farm<Animal>();
            animals1.Animals.Add(new Chicken("Simo"));
            animals1.Animals.Add(new Cow("Martin"));
            animals1.Animals.Add(new Chicken("Tomi"));
            animals1.Animals.Add(new Cow("Teo"));
            animals1.Animals.Add(new SuperCow("Daniel"));


            Farm<Chicken> chickens = animals1.Specifies<Chicken>();

            foreach (var item in chickens)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
            Farm<Cow> cows = animals1.Specifies<Cow>();

            foreach (var item in cows)
            {
                if (item is SuperCow)
                {
                    (item as SuperCow).Fly();
                }
            }


            Console.ReadLine();


        }
    }
}
