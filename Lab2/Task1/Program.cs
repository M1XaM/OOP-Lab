using System;
using CoffeeNamespace;

class Program
{
    static void Main(string[] args)
    {
        Cappuccino myCappuccino = new Cappuccino(Intensity.LIGHT, 100);
        Americano myAmericano = new Americano(Intensity.LIGHT, 100);
        PumpkinSpiceLatte myPumpkin = new PumpkinSpiceLatte(Intensity.LIGHT, 100, 200);
        SyrupCappuccino mySyrupCappuccino = new SyrupCappuccino(Intensity.LIGHT, 100, SyrupType.CARAMEL);
        // Console.WriteLine(mySyrupCappuccino.GetName());
    }
}