namespace PPDaniOgErik;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public List<Movie> Favorites { get; private set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
        Favorites = new List<Movie>();
    }

    public override string ToString()
    {
        return "Name: " + Username;
    }
}