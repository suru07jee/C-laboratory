using System;

// Base Class
class Animal
{
    protected string name;

    public Animal(string n)
    {
        name = n;
    }

    public void Display()
    {
        Console.WriteLine("Animal Name : " + name);
    }

    public void Sound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

// Derived Class
class Dog : Animal
{
    public Dog(string n) : base(n)
    {
    }

    public void Bark()
    {
        Console.WriteLine(name + " barks: Bow Bow!");
    }

    public void Show()
    {
        Console.WriteLine("Dog is a domestic animal.");
    }
}

// Main Class
class Program
{
    static void Main(string[] args)
    
    {
        Console.Write("Enter Dog Name: ");
        string dogName = Console.ReadLine();

        Dog d = new Dog(dogName);

        Console.WriteLine("\n----- Animal Details -----");
        d.Display();
        d.Sound();
        d.Bark();
        d.Show();

        Console.WriteLine("\nInheritance executed successfully.");
        Console.ReadLine();
    }
}