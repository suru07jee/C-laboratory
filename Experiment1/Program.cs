using System;

class Student
{
    string name;
    int age;

    public void GetData()
    {
        Console.Write("Enter Student Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Student Age: ");
        age = Convert.ToInt32(Console.ReadLine());
    }

    public void Display()
    {
        Console.WriteLine("\n----- Student Details -----");
        Console.WriteLine("Student Name : " + name);
        Console.WriteLine("Student Age : " + age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.GetData();
        s1.Display();
        Console.ReadLine();
    }
}