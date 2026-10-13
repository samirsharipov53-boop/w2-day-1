public class Player
{
    public string? Name;
    public int num;
    public string? Pos;
    public string? Team;

    public void ScoreGoal()
    {
        System.Console.WriteLine($"{Name}  scored the Goal!!!  {num}");
    }
    public void AsistGoal(string a)
    {
        System.Console.WriteLine($"{Name} scored the goal and {a} asisst the goal");

    }
    public void GetInfo()
    {
        System.Console.WriteLine(Name);
        System.Console.WriteLine(num);
        System.Console.WriteLine(Pos);
        System.Console.WriteLine(Team);
    }
}