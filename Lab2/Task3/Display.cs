using System;

namespace DisplayNamespace;
public class Display
{
    private int width;
    private int height;
    private float ppi;
    private string model;

    public Display(int width, int height, float ppi, string model)
    {
        this.width = width;
        this.height = height;
        this.ppi = ppi;
        this.model = model;
    }

    public void compareSize(Display m)
    {
            int thisArea = this.width * this.height;
            int otherArea = m.width * m.height;

            if (thisArea > otherArea)
            {
                Console.WriteLine($"{this.model} has a larger screen than {m.model}");
            }
            else if (thisArea < otherArea)
            {
                Console.WriteLine($"{m.model} has a larger screen than {this.model}");
            }
            else
            {
                Console.WriteLine($"{this.model} and {m.model} have the same screen size");
            }
        }

    public void compareSharpness(Display m)
    {
            if (this.ppi > m.ppi)
            {
                Console.WriteLine($"{this.model} has a sharper display than {m.model}");
            }
            else if (this.ppi < m.ppi)
            {
                Console.WriteLine($"{m.model} has a sharper display than {this.model}");
            }
            else
            {
                Console.WriteLine($"{this.model} and {m.model} have the same sharpness");
            }
    }

    public void compareWithMonitor(Display m)
    {
        this.compareSize(m);
        this.compareSharpness(m);
    }
}