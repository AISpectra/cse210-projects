using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>
        {
            new Dog("Buddy"),
            new Cat("Whiskers"),
            new Bird("Chirpy")
        };

        foreach (Animal animal in animals)
        {
            Console.WriteLine($"{animal.GetName()} says: {animal.MakeSound()}");
        }
    }
}
