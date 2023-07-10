using System;

public class TotalActivities : Activity
{
    // Variables
    private int breathingCount = 0;
    private TimeSpan breathingDuration = TimeSpan.Zero;
    private int reflectionCount = 0;
    private TimeSpan reflectionDuration = TimeSpan.Zero;
    private int listingCount = 0;
    private TimeSpan listingDuration = TimeSpan.Zero;
    // Constructors
    public TotalActivities(int input) : base(input)
    {
        UpdateActivities(input, _activityDuration);
        DisplayTotalActivities();
    }

    // Methods
    public void UpdateActivities(int input, int duration)
    {
        if (input == 1)
        {
            breathingCount++;
            breathingDuration += TimeSpan.FromSeconds(duration);
        }
        else if (input == 2)
        {
            reflectionCount++;
            reflectionDuration += TimeSpan.FromSeconds(duration);
        }
        else
        {
            listingCount++;
            listingDuration += TimeSpan.FromSeconds(duration);
        }
    }
    public void DisplayTotalActivities()
    {
        string summary = @$"
        You have completed the Following in the Mindfulness Programme:
        1. Breathing Activity: {breathingCount} for {breathingDuration} seconds.
        2. Reflecting Activity: {reflectionCount} for {reflectionDuration} seconds.
        3. Listing Activity: {listingCount} for {listingDuration} seconds.
        ";
        Console.WriteLine($"{summary}");

    }
}