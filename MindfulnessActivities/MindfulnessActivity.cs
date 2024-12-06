using System;

public abstract class MindfulnessActivity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public MindfulnessActivity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public virtual void StartActivity()
    {
        Console.WriteLine($"{_activityName}: {_description}");
        Console.WriteLine("Please enter the duration of the activity in seconds:");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Pause(3);
    }

    public void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public virtual void EndActivity()
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"Duration: {_duration} seconds.");
        Pause(3);
    }

    public abstract void PerformActivity();
}
