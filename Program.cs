namespace Uppgift_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
// Arv koncept
class Vehicle
{
    public string Color { get; set; }

    public void Start()
    {
        Console.WriteLine("Vehicle is starting");
    }
}


class Car : Vehicle
{
    public void Honk()
    {
        Console.WriteLine("Car is honking");
    }
}
// Polymorfism Koncept
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Underklasser
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat meows");
    }
}

// Inkapsling Koncept
class Person
{
    private int age;

    public void SetAge(int newAge)
    {
        if (newAge > 0)
        {
            age = newAge;
        }
    }

    public int GetAge()
    {
        return age;
    }
}

abstract class Shape
{
    public abstract double GetArea();
    
    // Abstrakt metod
}

class Square : Shape
{
    public double SideLength { get; set; }

    public override double GetArea()
    {
        return SideLength * SideLength;
    }
}