using System;

public class TimePieces
{
    public void Elipses(int elipTime, string unit, int quantity)
    {
        for (int i = quantity; i > 0; i--)
        {
            Console.CursorVisible = false;
            Console.Write($"{unit} ");
            Thread.Sleep(elipTime);
        }
        Console.CursorVisible = true;
    }
    public void Spinner(int spinTime)
    {
        List<string> spinnerString = new List<string>();

        spinnerString.Add("|");
        spinnerString.Add("/");
        spinnerString.Add("-");
        spinnerString.Add("\\");
        spinnerString.Add("|");
        spinnerString.Add("/");
        spinnerString.Add("-");
        spinnerString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(spinTime);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.CursorVisible = false;
            string s = spinnerString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= spinnerString.Count)
            {
                i = 0;
            }
            Console.CursorVisible = true;
        }
    }
    public void CountDown(int countTime)
    {
        Console.CursorVisible = false;

        for (int i = (countTime); i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.CursorVisible = true;
    }
}