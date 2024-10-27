using System.Collections.Generic;
using System;
using DisplayNamespace;

namespace AssistantNamespace;
public class Assistant
{
    private string assistantName;
    private List<Display> assignedDisplays;

    public Assistant(string assistantName)
    {
        this.assistantName = assistantName;
        assignedDisplays = new List<Display>();
    }

    public void assignDisplay(Display d)
    {
        assignedDisplays.Add(d);
    }

    public void assist()
    {
        for(int i = 0; i < assignedDisplays.Count-1; i++)
        {
            assignedDisplays[i].compareWithMonitor(assignedDisplays[i+1]);
            Console.WriteLine();
        }
    }

    public Display buyDisplay(Display d)
    {
        assignedDisplays.Remove(d);
        return d;
    }
}