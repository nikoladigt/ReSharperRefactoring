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
            public void Speak()
            {
                Console.WriteLine("Speak");
            }
        }

        public class Cat : Animal
        {
        }

        public class Dog : Animal
        {
            
        }
    }

    
}

