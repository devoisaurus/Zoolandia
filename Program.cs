using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var mySloth = new CholoepusHoffmanni();
            mySloth.isSlow = true;
            mySloth.food = "fruit";
            mySloth.numberOfToes = 2;
            mySloth.name = "Seymour";

            Console.WriteLine($"I have a sloth named {mySloth.name} who has {mySloth.numberOfToes} toes and eats {mySloth.food}.");

            
            var myBat = new TadaridaBrasiliensis();
            myBat.name = "Beauregard";
            myBat.wingspan = 12;
            myBat.canFly = true;
            myBat.food = "bugs";

            Console.WriteLine($"I have a bat named {myBat.name} who has a {myBat.wingspan} inch wingspan and eats {myBat.food}.");


            var myLemur = new LemurCatta();
            myLemur.name = "Lucius";
            myLemur.tailLength = 17;
            myLemur.vocalization = "chirps and purrs";
            myLemur.weight = 5;

            Console.WriteLine($"I have a lemur named {myLemur.name}.  He weighs {myLemur.weight} lbs and has a {myLemur.tailLength} inch tail. He {myLemur.vocalization} at his friends.");


        }
    }
}


