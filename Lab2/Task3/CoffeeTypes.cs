using System;

namespace CoffeeNamespace;
public enum Intensity
{
    LIGHT,
    NORMAL,
    STRONG
}

public enum SyrupType
{
    MACADAMIA,
    VANILIA,
    COCONUT,
    CARAMEL,
    CHOHOLATE,
    POPCORN
}

public class Coffee
{
    protected Intensity? coffeeIntensity;
    private const string name = "Coffee";

    public Coffee MakeCoffee(Intensity coffeeIntensity, string coffeeName = "Coffee")
    {
        Coffee newCoffee = new Coffee();
        newCoffee.coffeeIntensity = coffeeIntensity;
        Console.WriteLine("Making " + coffeeName);
        Console.WriteLine("Itensity set to " + coffeeIntensity);
        return newCoffee;
    }

    public Intensity? GetIntensity() => coffeeIntensity;

    public virtual string GetName() => name;

    public virtual void printDetails()
    {
        Console.WriteLine("Coffee name: " + GetName());
        Console.WriteLine("Coffee intensity: " + GetIntensity());
    }
}

public class Cappuccino : Coffee
{
    private int? mlOfMilk;
    private const string name = "Cappuccino";

    public override string GetName() => name;
    public void SetMlOfMilk(int value)
    {
        mlOfMilk = value;
    }

    public override void printDetails()
    {
        base.printDetails();
        Console.WriteLine("Amount of milk (mls): " + mlOfMilk);
    }

    public Cappuccino MakeCappuccino(Intensity coffeeIntensity, int mlOfMilk, string name = Cappuccino.name)
    {
        Cappuccino newCappuccino = new Cappuccino();
        newCappuccino.coffeeIntensity = coffeeIntensity;
        newCappuccino.mlOfMilk = mlOfMilk;
        base.MakeCoffee(coffeeIntensity, newCappuccino.GetName());
        Console.WriteLine("Adding " + mlOfMilk + " mls of milk");
        return newCappuccino;
    }
}

public class Americano : Coffee
{
    private int mlOfWater;
    private const string name = "Americano";

    public Americano MakeAmericano(Intensity coffeeIntensity, int mlOfWater)
    {
        Americano newAmericano = new Americano();
        newAmericano.coffeeIntensity = coffeeIntensity;
        newAmericano.mlOfWater = mlOfWater;
        base.MakeCoffee(coffeeIntensity, newAmericano.GetName());
        Console.WriteLine("Adding " + mlOfWater + " mls of water");
        return newAmericano;
    }

    public override string GetName() => name;

    public override void printDetails()
    {
        base.printDetails();
        Console.WriteLine("Amount of water (mls): " + mlOfWater);
    }
}

public class PumpkinSpiceLatte : Cappuccino
{
    private int mgOfPumpkinSpice;
    private const string name = "PumpkinSpiceLatte";

    public PumpkinSpiceLatte MakePumpkinSpiceLatte(Intensity coffeeIntensity, int mlOfMilk, int mgOfPumpkinSpice)
    {
        PumpkinSpiceLatte newPumpkinSpiceLatte = new PumpkinSpiceLatte();
        newPumpkinSpiceLatte.SetMlOfMilk(mlOfMilk);
        newPumpkinSpiceLatte.coffeeIntensity = coffeeIntensity;
        newPumpkinSpiceLatte.mgOfPumpkinSpice = mgOfPumpkinSpice;
        base.MakeCappuccino(coffeeIntensity, mlOfMilk, newPumpkinSpiceLatte.GetName());
        Console.WriteLine("Adding " + mgOfPumpkinSpice + " mls of pumpkin spice");
        return newPumpkinSpiceLatte;
    }

    public override string GetName() => name;

    public override void printDetails()
    {
        base.printDetails();
        Console.WriteLine("Amount of pumpkin spice (mls): " + mgOfPumpkinSpice);
    }
}

public class SyrupCappuccino : Cappuccino
{
    private SyrupType syrup;
    private const string name = "SyropCappuccino";

    public SyrupCappuccino MakeSyrupCappuccino(Intensity coffeeIntensity, int mlOfMilk, SyrupType syrup)
    {
        SyrupCappuccino newSyrupCappuccino = new SyrupCappuccino();
        newSyrupCappuccino.SetMlOfMilk(mlOfMilk);
        newSyrupCappuccino.coffeeIntensity = coffeeIntensity;
        newSyrupCappuccino.syrup = syrup;
        base.MakeCappuccino(coffeeIntensity, mlOfMilk, newSyrupCappuccino.GetName());
        Console.WriteLine("Adding " + syrup + " syrup");
        return newSyrupCappuccino;
    }

    public override string GetName() => name;

    public override void printDetails()
    {
        base.printDetails();
        Console.WriteLine("Type of syrup: " + syrup);
    }
}