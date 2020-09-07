using OOPExample;
using System;

class Program
{
    static void Main(string[] args)
    {
        var comp = new Computer("Generic Computer");

        Console.WriteLine($"Computer Type - {comp.GetType()}");
        
        //comp.name = "Generic computer";

        var isComputer = comp is Computer;
        Console.WriteLine($"Is Comuter - {isComputer}");
        Console.WriteLine($"Computer Name - {comp.name}");

        comp.TogglePower();
        Console.WriteLine($"Computer is ON - {comp.isOn}");

        comp.TogglePower();
        Console.WriteLine($"Computer is ON - {comp.isOn}");

        Console.Read();
    }
}
