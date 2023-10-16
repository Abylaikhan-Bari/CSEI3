using System;
using MyClassLib.WordOfTanks;

class Program
{
    static void Main()
    {
        Tank t34 = new Tank("T-34");
        Tank pantera = new Tank("Pantera");

        Console.WriteLine("Tank Battle Simulation:");
        Console.WriteLine(t34.GetTankParameters());
        Console.WriteLine(pantera.GetTankParameters());

        if (t34 > pantera)
        {
            Console.WriteLine($"{t34.GetTankParameters()} wins the battle against {pantera.GetTankParameters()}");
        }
        else
        {
            Console.WriteLine($"{pantera.GetTankParameters()} wins the battle against {t34.GetTankParameters()}");
        }

        Console.ReadKey();
    }
}
