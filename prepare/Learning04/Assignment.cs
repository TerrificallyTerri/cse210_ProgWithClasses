using System;

public class Assignment
{

    // Variables
    private string _studentName;
    private string _topic;

    // Create Constructor:
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic       = topic;
    }

    // Getters and Setters
    public string GetStudentName()
    {
        return _studentName;
    }

    // Methods
    public string Getsummary()
    {
        return $"Student Name: {_studentName} - Topic: {_topic}";
    }
}