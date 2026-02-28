using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPlayground.OOP.Inheritance
{
    /*
        Inheritance is the ability to create a new class based on an existing class, inheriting its properties and methods. 
        This allows for code reuse and the creation of class hierarchies. 
    */

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("The dog is barking.");
        }
    }

    class Program
    {
        static void Main()
        {
            Dog myDog = new Dog();

            myDog.Eat();    // Inherited from Animal
            myDog.Sleep();  // Inherited from Animal

            myDog.Bark();   // Defined in Dog

        }
    }
}
