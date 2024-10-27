using System;
using DisplayNamespace;

class Program
{
    static void Main()
    {
        Display firstDisplay = new Display(1280, 720, 100, "Asus");
        Display secondDisplay = new Display(1920, 1080, 120, "Xiaomi");
        Display thirdDisplay = new Display(3840, 2160, 184, "Samsung");

        firstDisplay.compareWithMonitor(secondDisplay);
        firstDisplay.compareWithMonitor(thirdDisplay);
        secondDisplay.compareWithMonitor(thirdDisplay);
    }
}
