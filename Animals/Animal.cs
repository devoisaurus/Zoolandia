using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        //attributes common to all animals
        public string Name { get; set; }
        public int Age { get; set;}
        public string TypeOfFood { get; set;}
        public int Weight { get; set; }
        public bool isCute {get; set; }

        //virtual method to override in each class
        public virtual void AnimalSaysWhat()
        {
            Console.WriteLine("What what?");
        }

        public static void AnimalEat()
        {
            Console.WriteLine("Nom nom nom");
        }

        public static void AnimalParty()
        {
            Console.WriteLine("WOOOOOOOO!");
        }       

    }

}