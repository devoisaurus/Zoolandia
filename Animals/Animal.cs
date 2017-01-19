using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name { get; set; }
        public string food { get; set;}
        public int weight { get; set; }

        public static void sleep()
        {
            Console.WriteLine("Animal is now sleeping");
        }

        public static void eat()
        {
            Console.WriteLine("Nom nom nom");
        }

        public virtual void AnimalParty()
        {
            Console.WriteLine("WOOOOOOOO!");
        }
        
    }

}