using System;

class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetName("John");
        hEmployee.SetIdNumber("abc123");
        hEmployee.SetPayRate(15);
        hEmployee.SetHoursWorked(35);

        SalaryEmployee sEmployee = new SalaryEmployee();
        sEmployee.SetName("Peter");
        sEmployee.SetIdNumber("def456");
        sEmployee.SetSalary(60000);

        DisplayEmployeeInformation(hEmployee);
        DisplayEmployeeInformation(sEmployee);

        List<Employee> employees = new List<Employee>();
        employees.Add(hEmployee);
        employees.Add(sEmployee);

        foreach (Employee emp in employees)
        {
            float pay = emp.GetPay();
        }

    }
    public static void DisplayEmployeeInformation(Employee employee)
    {
        float pay = employee.GetPay();
        Console.WriteLine($"{employee.GetName()} will be paid ${pay}");
    }

}
// Base Class
public abstract class Employee // abstract methods for abstract class
// methods must override.
{
    protected string _name;
    protected string _idNumber;

    public Employee()
    {
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetIdNumber()
    {
        return _idNumber;
    }
    public void SetIdNumber(string IdNumber)
    {
        _idNumber = IdNumber;
    }
    // public virtual float GetPay()
    // {
    //     return 555;
    // }
    public abstract float GetPay(); //no body for abstract methods. abstract functions only in abstract classes
}
public class SalaryEmployee : Employee
{
    private float _salary = 0;
    public float GetSalary()
    {
        return _salary;
    }
    public void SetSalary(float salary)
    {
        _salary = salary;
    }
    public override float GetPay()
    {
        return _salary / 12;
    }

}
public class HourlyEmployee : Employee
{
    private float _payRate = 0;
    private int _hoursWorked = 0;

    public float GetPayRate()
    {
        return _payRate;
    }
    public void SetPayRate(float payRate)
    {
        _payRate = payRate;
    }
    public int GetHoursWorked()
    {
        return _hoursWorked;
    }
    public void SetHoursWorked(int hoursWorked)
    {
        _hoursWorked = hoursWorked;
    }
    public override float GetPay()
    {
        return _hoursWorked * _payRate;
    }
}