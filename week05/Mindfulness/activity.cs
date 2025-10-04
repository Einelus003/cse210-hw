using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like this session? ");
        _duration = int.Parse(Console.ReadLine() ?? "30");
        Console.WriteLine("Prepare to begin...");
        PauseWithSpinner(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("Well done");
        PauseWithSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        PauseWithSpinner(3);
    }

    protected void PauseWithSpinner(int seconds)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(spinner[i % spinner.Count]);
            Thread.Sleep(300);
            Console.Write("\b \b");
            i++;
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public virtual void Run() { }
}
