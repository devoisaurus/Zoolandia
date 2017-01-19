using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public string Age { get; set;}
        public string TypeOfFood { get; set;}
        public int Weight { get; set; }
        public bool isCute {get; set; }

        public string animalIsActive { get; set;}

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