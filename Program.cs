using OOPExample;
using System;

class Program
{
    static void Main(string[] args)
    {
        var comp = new Desktop("Generic Computer", Desktop.CaseType.Tower);
        //var comp = new Laptop("Generic", 1024, 768);

        Console.WriteLine($"Computer Type - {comp.GetType()}");
        
        //comp.name = "Generic computer";

        var isComputer = comp is Computer;
        Console.WriteLine($"Is Comuter - {isComputer}");
        Console.WriteLine($"Computer Name - {comp.name}");
        Console.WriteLine($"Computer case - {comp.caseType}");


        comp.TogglePower();
        Console.WriteLine($"Computer is ON - {comp.isOn}");

        comp.ToggleSleep();
        Console.WriteLine($"Computer is sleeping - {comp.isOn}");

        comp.TogglePower();
        Console.WriteLine($"Computer is ON - {comp.isOn}");

        Console.Read();
    }
}
