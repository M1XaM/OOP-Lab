using System;
using System.Collections;
using CoffeeNamespace;

namespace BaristaNamespace;
public class Barista
{
    public string name;

    public Barista(string name = "Barista")
    {
        this.name = name;
    }

    public Coffee MakeMeHmmmm()
    {
        Coffee drink = null;

        Console.WriteLine("Do you want something spicy? [y/n]");
        string spicy = Console.ReadLine();
        if (spicy == "n")
        {
            Console.WriteLine("Do you want something sweet? [y/n]");
            string allowSweet = Console.ReadLine();
            if (allowSweet == "y")
            {
                Intensity intensity = AskIntensity();
                int milk = AskMls("milk");
                SyrupType syrup = AskSyrupType();
                drink = new SyrupCappuccino().MakeSyrupCappuccino(intensity, milk, syrup);
            }
            else
            {
                Console.WriteLine("Do you want milk in it? [y/n]");
                string allowMilk = Console.ReadLine();
                if (allowMilk == "yes")
                {
                    int milk = AskMls("milk");
                    Intensity intensity = AskIntensity();
                    drink = new Cappuccino().MakeCappuccino(intensity, milk);
                }
                else
                {
                    int water = AskMls("water");
                    Intensity intensity = AskIntensity();
                    drink = new Americano().MakeAmericano(intensity, water);
                }
            }
        }
        else
        {
            Intensity intensity = AskIntensity();
            int milk = AskMls("milk");
            int spice = AskMls("pumpkin spice");
            drink = new PumpkinSpiceLatte().MakePumpkinSpiceLatte(intensity, milk, spice);
        }

        return drink;
    }

    private int AskMls(string material)
    {
        int mlsOfSmth = 0;
        bool validInput = false;
        while (!validInput)
        {
            Console.WriteLine($"How much of {material} do you want? (in mls)");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out mlsOfSmth) || mlsOfSmth < 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
            }
            else
            {
                validInput = true;
            }
        }
        return mlsOfSmth;
    }

    private Intensity AskIntensity()
    {
        int intensityNumberInteger;
        while (true)
        {
            Console.Write("What intensity do you want to have (enter the number):\n1.Light\n2.Normal\n3.Strong\n");
            string intensityNumber = Console.ReadLine();
            if (int.TryParse(intensityNumber, out intensityNumberInteger) && intensityNumberInteger >= 1 && intensityNumberInteger <= 3)
            {
                switch (intensityNumberInteger)
                {
                    case 1:
                        return Intensity.LIGHT;
                    case 2:
                        return Intensity.NORMAL;
                    case 3:
                        return Intensity.STRONG;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please choose a number between 1 and 3.");
            }
        }
    }

    private SyrupType AskSyrupType()
    {
        int syrupNumberInteger;
        while (true)
        {
            Console.Write("What type of syrup do you want to try (enter the number):\n1.Macadamia\n2.Vanilla\n3.Coconut\n4.Caramel\n5.Chocolate\n6.Popcorn\n");
            string syrupNumber = Console.ReadLine();
            if (int.TryParse(syrupNumber, out syrupNumberInteger) && syrupNumberInteger >= 1 && syrupNumberInteger <= 6)
            {
                switch (syrupNumberInteger)
                {
                    case 1:
                        return SyrupType.MACADAMIA;
                    case 2:
                        return SyrupType.VANILLA;
                    case 3:
                        return SyrupType.COCONUT;
                    case 4:
                        return SyrupType.CARAMEL;
                    case 5:
                        return SyrupType.CHOCOLATE;
                    case 6:
                        return SyrupType.POPCORN;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please choose a number between 1 and 6.");
            }
        }
    }
}