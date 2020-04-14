using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird robin = new Bird();
            Console.WriteLine("Your bird has: ");
            robin.Legs = 2;
            Console.WriteLine($"{robin.Legs} legs!");

            robin.Age = 2;
            Console.WriteLine($"It is {robin.Age} years old!");

            robin.Omnivores = true;
            if (robin.Omnivores == true)
            {
                Console.WriteLine("It is also an Omnivore, meaning it eats plants and meat.");
            }

            robin.Arms = 0;
            if (robin.Arms == 0)
            {
                Console.WriteLine("Your bird doesn't technically have arms, it has wings!");
            }

            robin.Fly = true;
            if (robin.Fly == true)
            {
                Console.WriteLine("Of course it can fly!");
            }

            robin.Feathers = true;
            if (robin.Feathers == true)
            {
                Console.WriteLine("It has Feathers!");
            }

            robin.Beak = true;
            if (robin.Beak == true)
            {
                Console.WriteLine("It has a beak!");
            }

            robin.Eggs = true;
            if (robin.Eggs == true)
            {
                Console.WriteLine("And it can lay eggs!");
            }

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Console.WriteLine("*********************************************");

            Reptile lizard = new Reptile();

            Console.WriteLine("Your lizard has: ");
            lizard.Legs = 4;
            Console.WriteLine($"{lizard.Legs} legs!");

            lizard.Age = 18;
            Console.WriteLine($"It is {lizard.Age} years old.");

            lizard.Arms = 0;
            if (lizard.Arms == 0)
            {
                Console.WriteLine("It doesn't technically have arms it has legs!");
            }

            lizard.Omnivores = true;
            if (lizard.Omnivores == true)
            {
                Console.WriteLine("It is also an Omnivore!");
            }

            lizard.ColdBlood = true;
            if (lizard.ColdBlood == true)
            {
                Console.WriteLine("It is cold blooded, so it enjoys laying out in the sun.");
            }

            lizard.Scales = true;
            if (lizard.Scales == true)
            {
                Console.WriteLine("It also has scales!");
            }

            lizard.Eggs = true;
            if (lizard.Eggs == true)
            {
                Console.WriteLine("It can also lay eggs!");
            }

            lizard.Regenerative = true;
            if(lizard.Regenerative == true)
            {
                Console.WriteLine("And your lizard can regenerate its limbs!");
            }
        }
    }
}
