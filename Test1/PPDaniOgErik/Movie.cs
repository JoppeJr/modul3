using System.Reflection;

namespace PPDaniOgErik;

public class Movie
{
    public int Id { get; set; }
    public string Title;

    public string Genre;

    public int RunTime;

    public Movie(int id, string title, string genre, int runTime)
    {
        Id = id;
        Title = title;
        Genre = genre;
        RunTime = runTime;
    }

    public override string ToString()
    {
        return "Id: " + this.Id + "\n Title: " + this.Title + "\n Genre:" + this.Genre + "\n Runtime: " + this.RunTime;
    }
}