using System;

public class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What made this time different than other times?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.") { }

    public override void PerformActivity()
    {
        Random rand = new Random();
        string selectedPrompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(selectedPrompt);

        Pause(3);

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            Pause(3);
        }

        EndActivity();
    }
}
