using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        
        manager.AddGoal(new SimpleGoal("Play baskeball", "Practice Basketball ", 1000));
        manager.AddGoal(new EternalGoal("Read Scriptures", "Daily scripture studies", 100));
        manager.AddGoal(new ChecklistGoal(" Help people in need ", "Visit the homeless shelter organization   10 times per  month ", 50, 10, 500));

        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display Goals");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                manager.DisplayGoals();
            }
            else if (choice == "2")
            {
                manager.DisplayGoals();
                Console.Write("Which goal did you accomplish? ");
                int index = int.Parse(Console.ReadLine()) - 1;
                manager.RecordEvent(index);
            }
            else if (choice == "3")
            {
                running = false;
            }
        }
    }
}
