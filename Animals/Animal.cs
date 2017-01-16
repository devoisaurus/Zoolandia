using System;

namespace Zoolandia.Animals
{
    class Animal
    {
        public string name { get; set; }
        public string food { get; set;}
        public int weight { get; set; }

        public static void sleep()
        {
            Console.WriteLine("Animal is now sleeping");
        }
    }

}