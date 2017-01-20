using System;

namespace Zoolandia.Animals
{
    public class LemurCatta : Animal
    {
        public LemurCatta()
        {
            primaryLocomotion = "jumping";
        }

        public string primaryLocomotion { get; set;}

        public LemurCatta (string name)
        {
            base.Name = name;
        }

        public override void AnimalSaysWhat()
        {
            Console.WriteLine("*chitter*");
        }
    }
}