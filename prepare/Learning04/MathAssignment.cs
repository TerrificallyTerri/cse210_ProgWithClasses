using System;

// Create a class and specify inheritance from the base class
public class MathAssignment : Assignment
{
    // Attributes
    private string _textBookSection;

    private string _problems;

    // Constructor
    // 4 parameters for the MathAssignment Constructor
    // studentName and topic passed to the "base" constructor in "parent class" Assignment
    public MathAssignment(string studentName, string topic, string textBookSection, string problems)
        : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    // Methods
    public string GetHomeWorkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }

}