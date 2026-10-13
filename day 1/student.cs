public class Student
{
    public string? name;
    public int gradelevel;
    public List<int> Scores = new List<int>();

    public void AddScore(int a)
    {
        Scores.Add(a);
    }
    
    public int GetAvarage()
    {
        int a=0;
        foreach (var item in Scores)
        {
            a+=item;
        }
        return a/Scores.Count();
    }
}