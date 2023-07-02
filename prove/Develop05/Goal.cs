using System;

public abstract class Goal{
    // Attributes
    private string _goalType;
    private string _goalName;
    private string _goalDescription;
    private int    _goalPoints;

    public Goal(string type, string name, string description, int points)
    {
        _goalType        = type;
        _goalName        = name;
        _goalDescription = description;
        _goalPoints = points;
    }

    public string GetGoalType()
    {
        return _goalType;
    }
    public string GetGoalName()
    {
        return _goalName;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
    }
    public int GetGoalPoints()
    {
        return _goalPoints;
    }

    // Methods
    public abstract void GoalList(int number);
    public abstract void GoalEventRecord(List<Goal> goals);
    public abstract string SaveGoal();
    public abstract string LoadGoal();
}