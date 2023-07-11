using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Employee> employees = new List<Employee>();

        employees.Add(new Employee());
        employees.Add(new HourlyEmployee());

        foreach (Employee employee in employees)
        {
            float pay = employee.CalculatePay();
            Console.WriteLine($"{pay}");

        }





    }


}
public class Employee
{
    private float salary = 100f;
    public virtual float CalculatePay()
    {
        return salary;
    }
}
public class HourlyEmployee : Employee
{
    private float rate = 9f;
    private float hours = 100f;

    public override float CalculatePay()
    {
        return rate * hours;
    }
}