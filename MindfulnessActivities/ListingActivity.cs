using System;

public class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void PerformActivity()
    {
        Random rand = new Random();
        string selectedPrompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(selectedPrompt);

        Pause(3);

        Console.WriteLine("Start listing things now. Press enter after each entry.");
        int count = 0;

        while (true)
        {
            string userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput)) break;
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
        EndActivity();
    }
}
