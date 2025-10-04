using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment a1 = new Assignment("Samuel Inelus ", "Multiplication");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

    
        MathAssignment m1 = new MathAssignment("Robert Francois ", "Addition ", "7.3", "8-19");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
        Console.WriteLine();

        
        WritingAssignment w1 = new WritingAssignment("Woudia Inelus ", "haitian History", " Vertieres War ");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}
