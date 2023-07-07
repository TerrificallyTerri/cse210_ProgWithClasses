using System;

public class WritingAssignment : Assignment
{
    // Attributes
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Methods
    public string GetWritingInformation()
    {
        // call getter method
        string studentName = GetStudentName();
        
        return $"Title: {_title} by {studentName}";
    }
}