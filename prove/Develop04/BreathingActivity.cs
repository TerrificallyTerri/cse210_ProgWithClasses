using System;

public class BreathingActivity : Activity
{
    // Attributes
    private string _breatheIn = "\nBreathe in... ";
    private string _breatheOut = "Now breathe out... ";

    // Constructors
    TimePieces timePieces = new TimePieces();

    public BreathingActivity(int input) : base(input)
    {
        PrepareToBegin();
        Breathing(_activityDuration);
        DisplayActivityEnd();
    }


    // Methods
    public void Breathing(int _activityDuration)
    {
        Console.Clear();
        List<string> breathing = new List<string>();

        breathing.Add(_breatheIn);
        breathing.Add(_breatheOut);

        int duration = _activityDuration;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.CursorVisible = false;
            string s = breathing[i];
            Console.Write(s);
            timePieces.CountDown(5);
            Console.WriteLine();

            i++;

            if (i >= breathing.Count)
            {
                i = 0;
            }

            Console.CursorVisible = true;
        }
    }
}