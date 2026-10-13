public class Car()
{
    public string? mark;
    public string? model;
    public int year;
    public int? milage;
    public int? fuel;

public void Info()
    {
        System.Console.WriteLine("Mark = "+mark);
        System.Console.WriteLine("Model = "+model);
        System.Console.WriteLine("Year = "+year);
        System.Console.WriteLine("Millage = "+milage);
        System.Console.WriteLine("Fuel = "+fuel);
    }
       public int fuel2;
    public void AddFuel()
    {
        System.Console.Write
        ("Add second fuel: ");
        fuel2=Convert.ToInt32(Console.ReadLine());

    }
    public void Drive(double millage)
    {
        System.Console.Write($"You have driven {milage} miles. Current milage: {milage} miles Remainig fuel: {fuel} Add fuel {fuel2} Current fuel Level ");
        System.Console.Write(fuel2+fuel);
    }
}