using System;

namespace RefactoringExample
{
    class Program
    {
        static void Run(string[] args)
        {
            Cat cat = new Cat();
            cat.Speak();

            Dog dog = new Dog();
            dog.Speak();
        }

        public abstract class Animal
        {
            // Common members.
        }

        public class Cat : Animal
        {
            public void Speak()
            {
                Console.WriteLine("Meow");
            }
        }

        public class Dog : Animal
        {
            public void Speak()
            {
                Console.WriteLine("Bark");
            }
        }
    }

    
}

