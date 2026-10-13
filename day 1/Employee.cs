public class Employee
{
    public string? firsname;
    public string? lasname;
    public int Age;
    public string? Position;
    public double Salary;

    public void Setsalary(double a)
    {
        Salary=a;
    }
    public double GetSalary()
    {
        return Salary;
    }
    public void GetInfo()
    {
        System.Console.WriteLine("First Name: "+firsname);
        System.Console.WriteLine("First Name: "+lasname);
        System.Console.WriteLine("Position: "+Position);
        System.Console.WriteLine("Age: "+Age);
        System.Console.WriteLine("Salary: "+Salary);
    }
}