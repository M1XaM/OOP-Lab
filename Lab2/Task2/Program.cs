using System;
using CoffeeNamespace;

class Program
{
    static void Main(string[] args)
    {
        Cappuccino myDrink = new Cappuccino(Intensity.NORMAL, 100);
        // Americano myDrink = new Americano(Intensity.STRONG, 100);
        // PumpkinSpiceLatte myDrink = new PumpkinSpiceLatte(Intensity.LIGHT, 100, 200);
        // SyrupCappuccino myDrink = new SyrupCappuccino(Intensity.LIGHT, 100, SyrupType.CARAMEL);
        myDrink.printDetails();
    }
}