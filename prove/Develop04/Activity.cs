using System;

// Parent / Base class
public class Activity
{
    // Variables
    private string _activityName;
    private string _activityStartMessage;
    // private string _activityEndMessage;
    protected int _activityDuration;
    private string _prepMessage = "Get ready... ";

    TimePieces timePieces = new TimePieces();
    // Constructors
    public Activity(int input)
    {
        SetActivity(input);
        DisplayActivityStart(_activityName, _activityStartMessage);
        _activityDuration = GetActivityDuration();
    }

    // Getters and Setters:
    public int GetActivityDuration()
    {
        Console.Write($"\n\nHow long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        return duration;
    }

    public void SetActivityDuration(int duration)
    {
        _activityDuration = duration;
    }

    private void SetActivity(int input)
    {
        if (input == 1)
        {
            _activityName = "Breathing Activity";
            _activityStartMessage = "This activity will help you relax by walking you through breathing in and out slowly. \nClear your mind and focus on your breathing.";
        }
        else if (input == 2)
        {
            _activityName = "Reflection Activity";
            _activityStartMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
        }
        else
        {
            _activityName = "Listing Activity";
            _activityStartMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }
    }

    // methods
    private void DisplayActivityStart(string activityName, string activityMessage)
    {
        Console.WriteLine($"\nWelcome to the {activityName}.\n\n{activityMessage}\n");
        timePieces.Elipses(400, "♥ ", 10);
    }

    public void PrepareToBegin()
    {
        Console.Clear();
        Console.Write($"\n{_prepMessage}");
        timePieces.Spinner(4);
    }

    public void DisplayActivityEnd()
    {
        Console.WriteLine($"\n\nWell Done!!");
        timePieces.Elipses(500, "☺ ", 10);
        Console.WriteLine($"\n\nYou have completed another {_activityDuration} seconds of the {_activityName}.");
        timePieces.Elipses(1000, ". ", 3);
    }


}
