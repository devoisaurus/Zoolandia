using System;


namespace Zoolandia.Animals
{
    public class CholoepusHoffmanni : Animal
    {
        public CholoepusHoffmanni()
        {
            int hoursActive;
        }

        public int hoursActive { get; set;}
        public CholoepusHoffmanni(string name)
        {
            base.Name = name;
        }

        public override void AnimalSaysWhat()
        {
            Console.WriteLine("*squeak*");
        }
    }
}