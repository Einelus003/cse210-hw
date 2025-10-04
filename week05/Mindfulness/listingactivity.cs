using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things by listing as many items as you can.") { }

    public override void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Console.Write("Get ready... ");
        Countdown(5);
        Console.WriteLine("Start listing items (press enter after each):");

        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            if (Console.KeyAvailable)
            {
                string entry = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(entry))
                    items.Add(entry);
            }
        }

        Console.WriteLine($"You listed {items.Count} items.");
        EndMessage();
    }
}
