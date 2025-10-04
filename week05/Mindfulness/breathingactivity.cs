using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through slow breathing. Clear your mind and  breathe.") { }

    public override void Run()
    {
        StartMessage();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            Countdown(6);
            Console.WriteLine();
        }

        EndMessage();
    }
}
