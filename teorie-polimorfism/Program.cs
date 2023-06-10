using System;

// Base class
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

// Derived class 1
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks");
    }
}

// Derived class 2
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows");
    }
}

// Main class
public class Program
{
    public static void Main(string[] args)
    {
        Dog x = new Dog();
        Cat y = new Cat();

        Animal t = x;

        t = y;

        t.MakeSound();



    }
}