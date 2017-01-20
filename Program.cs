using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var Animal = new Animal();
            Animal.AnimalSaysWhat();

            var TheSloth = new CholoepusHoffmanni();
            TheSloth.Name = "Seymour";
            TheSloth.Age = 4;
            TheSloth.TypeOfFood = "fruit and flowers";
            TheSloth.Weight = 10;
            TheSloth.isCute = true;
            TheSloth.hoursActive = 8;

            Console.WriteLine($"Meet {TheSloth.Name} the sloth, who lives in a tree and eats {TheSloth.TypeOfFood}. He weighs about {TheSloth.Weight} lbs, and is active around {TheSloth.hoursActive} hours a day.");

            Console.WriteLine("Is the sloth cute?");
            Console.WriteLine(TheSloth.isCute);

            TheSloth.AnimalSaysWhat();

            var ItsABat = new TadaridaBrasiliensis();
            ItsABat.Name = "Barty";
            ItsABat.Age = 2;
            ItsABat.TypeOfFood = "insects and fruit";
            ItsABat.Weight = 2;
            ItsABat.isCute = true;
           
           Console.WriteLine($"And behind Door #2 is {ItsABat.Name} the bat!  He lives in a cave and eats {ItsABat.TypeOfFood}.  He weighs about {ItsABat.Weight} lbs.");
           Console.WriteLine("Is the bat cute?");
           Console.WriteLine(ItsABat.isCute);
           Console.WriteLine("Can bats fly?");
           Console.WriteLine(ItsABat.CanFly);


           ItsABat.AnimalSaysWhat();

           var lookALemur = new LemurCatta();
           lookALemur.Name = "Louis";
           lookALemur.Age = 7;
           lookALemur.TypeOfFood = "tamarind";
           lookALemur.Weight = 3;
           lookALemur.isCute = true;
           
           Console.WriteLine($"Over here we have {lookALemur.Name} the ring-taiiled lemur! He loves trees and snacks on {lookALemur.TypeOfFood}. He's {lookALemur.Age} and weighs around {lookALemur.Weight} lbs.  He gets around by {lookALemur.primaryLocomotion}.");
           Console.WriteLine("Well, is he cute?");
           Console.WriteLine(lookALemur.isCute);

           lookALemur.AnimalSaysWhat();

           var honeyBadger = new MellivoraCapensis();
           honeyBadger.Name = "Henrietta";
           honeyBadger.Age = 4;
           honeyBadger.TypeOfFood = "honey";
           honeyBadger.Weight = 9;
           honeyBadger.isCute = false;

           Console.WriteLine($"And now we come to {honeyBadger.Name}, the honey badger.  She's kind of {honeyBadger.generalTemperament} and likes {honeyBadger.TypeOfFood}.  She's {honeyBadger.Age} years old and weighs in at around {honeyBadger.Weight} lbs.");

           Console.WriteLine("Is Henrietta cute?");
           Console.WriteLine(honeyBadger.isCute);

           honeyBadger.AnimalSaysWhat();
           



        }
    }
}


