using System;

namespace Zoolandia.Animals
{
    public class MellivoraCapensis : Animal
    {
        public MellivoraCapensis()
        {
            generalTemperament = "mean";
        }

        public string generalTemperament { get; set; }

        public MellivoraCapensis(string name)
        {
            base.Name = name;
        }

        //overriden method
        public override void AnimalSaysWhat()
        {
            Console.WriteLine("Honey badger don't care.");
        }
    }

}