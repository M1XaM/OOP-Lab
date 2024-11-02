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

public abstract class Coffee
{
    private Intensity coffeeIntensity;
    private const string name = "Coffee";

    protected Coffee(Intensity coffeeIntensity)
    {
        this.coffeeIntensity = coffeeIntensity;
    }

    public virtual string GetName() => name;
}

public class Cappuccino : Coffee
{
    private int mlOfMilk;
    private const string name = "Cappuccino";

    public Cappuccino(Intensity coffeeIntensity, int mlOfMilk) : base(coffeeIntensity)
    {
        this.mlOfMilk = mlOfMilk;
    }

    public override string GetName() => name;
}

public class Americano : Coffee
{
    private int mlOfWater;
    private const string name = "Americano";

    public Americano(Intensity coffeeIntensity, int mlOfWater) : base(coffeeIntensity)
    {
        this.mlOfWater = mlOfWater;
    }

    public override string GetName() => name;
}

public class PumpkinSpiceLatte : Cappuccino
{
    private int mgOfPumpkinSpice;
    private const string name = "PumpkinSpiceLatte";

    public PumpkinSpiceLatte(Intensity coffeeIntensity, int mlOfMilk, int mgOfPumpkinSpice) : base(coffeeIntensity, mlOfMilk)
    {
        this.mgOfPumpkinSpice = mgOfPumpkinSpice;
    }

    public override string GetName() => name;
}

public class SyrupCappuccino : Cappuccino
{
    private SyrupType syrop;
    private const string name = "SyropCappuccino";

    public SyrupCappuccino(Intensity coffeeIntensity, int mlOfMilk, SyrupType syrop) : base(coffeeIntensity, mlOfMilk)
    {
        this.syrop = syrop;
    }

    public override string GetName() => name;
}