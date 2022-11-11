namespace PPDaniOgErik;

public class UsersList
{
    public List<User> Users { get; set; }


    public UsersList()
    {
        Users = new List<User>();
        Users.Add(new User("Dani", "1234"));
        Users.Add(new User("test", "4321"));

    }

    public void PrintAll()
    {
        foreach (var user in Users)
        {
            Console.WriteLine(user.Username.ToString());
            
        }
    }


}