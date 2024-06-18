using System;

namespace RefactoringExample
{
    class PushDown
    {
        static void Run(string[] args)
        {
            Cat cat = new Cat();
            cat.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();
        }
    }

    public abstract class Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    public class Cat : Animal
    {
        // Specific members for Cat.
    }

    public class Dog : Animal
    {
        // Specific members for Dog.
    }
}