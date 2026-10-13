public class Person
{
    public string fname;
    public string lname;
    public int age;
    public string adres;
    public string GetfullName()
    {
        return $"ex: {fname}  {lname}";
    }
    public int GetBirthYear()
    {
        return age;
    }

}