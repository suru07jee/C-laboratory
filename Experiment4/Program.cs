using System;

// Delegate Declaration
public delegate void Notify();

// Publisher Class
class Publisher
{
    // Event Declaration
    public event Notify OnMessage;

    // Method to Raise the Event
    public void RaiseEvent()
    {
        Console.WriteLine("Publisher is raising the event...");

        if (OnMessage != null)
        {
            OnMessage();
        }
    }
}

// Subscriber Class
class Subscriber
{
    // Event Handling Method
    public void DisplayMessage()
    {
        Console.WriteLine("Event received successfully.");
        Console.WriteLine("Hello! This is a Delegate and Event example.");
    }
}

// Main Class
class Program
{
    static void Main(string[] args)
    {
        Publisher p = new Publisher();
        Subscriber s = new Subscriber();

        // Subscribe the event
        p.OnMessage += s.DisplayMessage;

        Console.WriteLine("Press Enter to raise the event...");
        Console.ReadLine();

        // Raise the event
        p.RaiseEvent();

        Console.WriteLine("Program executed successfully.");
        Console.ReadLine();
    }
}