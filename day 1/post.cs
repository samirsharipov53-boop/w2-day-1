public class Post
{
   public string? text;
    public int Likes;
    public List<string> comments= new List<string>();
    public void SetPost(string a)
    {
     text=a;   
    }
    public void AddLike()
    {
        Likes++;
    }
    public void AddComent(string a)
    {
        comments.Add(a);
    }
    public void GetInfo()
    {
        System.Console.WriteLine(text+" "+Likes+" Coments: ");
        System.Console.Write(" Coments: ");
        foreach (var item in comments)
        {
            System.Console.Write(item);
        }
    }
}
