using System;

class Number
{
    int x, y;

    // Constructor
    public Number(int a, int b)
    {
        x = a;
        y = b;
    }

    // Operator Overloading
    public static Number operator +(Number n1, Number n2)
    {
        return new Number(n1.x + n2.x, n1.y + n2.y);
    }

    // Display Method
    public void Display()
    {
        Console.WriteLine("First Value : " + x);
        Console.WriteLine("Second Value : " + y);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first value of Object 1 : ");
        int a1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second value of Object 1 : ");
        int b1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter first value of Object 2 : ");
        int a2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second value of Object 2 : ");
        int b2 = Convert.ToInt32(Console.ReadLine());

        Number n1 = new Number(a1, b1);
        Number n2 = new Number(a2, b2);
        Number n3 = n1 + n2;

        Console.WriteLine("\nResult After Operator Overloading");
        n3.Display();

        Console.ReadLine();
    }
}