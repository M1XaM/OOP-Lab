using System;
using CoffeeNamespace;

class Program
{
    static void Main(string[] args)
    {
        Cappuccino myDrink = new Cappuccino().MakeCappuccino(Intensity.NORMAL, 100);
        // Americano myDrink = new Americano().MakeAmericano(Intensity.STRONG, 200);
        // PumpkinSpiceLatte myDrink = new PumpkinSpiceLatte().MakePumpkinSpiceLatte(Intensity.LIGHT, 100, 200);
        // SyrupCappuccino myDrink = new SyrupCappuccino().MakeSyrupCappuccino(Intensity.LIGHT, 100, SyrupType.CARAMEL);

        Console.WriteLine();
        myDrink.printDetails();
    }
}