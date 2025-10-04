using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you helped a stranger .",
        "Think of a time when you challenged yourself doing something difficult .",
        "Think of a time when you were present for someone in need .",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity",
        "This activity will help you reflect on times when you have shown strength and resilience.") { }

    public override void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        PauseWithSpinner(3);

        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            PauseWithSpinner(5);
        }

        EndMessage();
    }
}
