using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What did you do today that you are the most proud of ?",
        "In what points today was a succesful day for you ?",
        " What was in your plan to do today but you forgot or did not have the chance to do it ?",
        "What were your emotions for today ?",
        "What do you think you can do to be more productive day by day ?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
