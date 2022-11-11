namespace PPDaniOgErik;

public class OpptionsMenu
{
    public User currentUser { get; set; }
    public static UsersList ListOfUsers = new();
    public static MoviesList movies = new();
    public void LogInPage()
    {
        Console.WriteLine("1 - log inn");
        Console.WriteLine("2 - Lag bruker");
        Console.WriteLine("X - Exit");
        var cmd = Console.ReadLine().ToLower();
        if (cmd == "1")
        {
            CheckUsername();
        }

        if (cmd == "2")
        {
            AddUser();
        }

        if (cmd == "x")
        {
            Environment.Exit(0);
        }
        //currentUser = username;
    }

    private void AddUser()
    {
        Console.Clear();
        Console.WriteLine("Skriv inn nytt brukernavn: ");
        var nyUsername = Console.ReadLine();
        Console.WriteLine("Skriv inn passord: ");
        var nyPassord = Console.ReadLine();
        bool addUser = false;
        foreach (var user in ListOfUsers.Users)
        {
            ListOfUsers.PrintAll();
           
            if (nyUsername != user.Username)
            {
                addUser = true;
            }
            else
            {
                AddUser();
            }
            
        }


        if (addUser == true)
        {
            ListOfUsers.Users.Add(new User(nyUsername, nyPassord));
        }
        ListOfUsers.PrintAll();
        LoggedInnMenu();


    }

    public void LoggedInnMenu()
    {
        Console.Clear();
        Console.WriteLine("1. - Se alle filmer");
        Console.WriteLine("2. - søk i filmer");
        Console.WriteLine("3. - legg til i favoritter");
        Console.WriteLine("4. - fjern fra favoritter");
        Console.WriteLine("5. - Spill tre på rad");
        Console.WriteLine("X. - Exit");
        var command = Console.ReadLine().ToLower();
        if (command == "1")
        {
            Console.Clear();
            movies.PrintAllMovies();
            Console.WriteLine("press 1 to go back :D ");
            var back2menu = Console.ReadLine();
            if (back2menu == "1") { LoggedInnMenu(); }
        }

        if (command == "x")
        {
            Environment.Exit(0);
        }
    }

    private void CheckUsername()
    {
        Console.WriteLine("Skriv inn Brukernavn: ");
        string username = Console.ReadLine();
        currentUser = ListOfUsers.Users.FirstOrDefault(u => u.Username == username);//Users er lista og ListOfUsers er klassen 
        if (currentUser != null) { CheckPassword(); }
    }

    public void CheckPassword()
    {
        Console.WriteLine("Skriv inn Passord: ");
        string password = Console.ReadLine();
        if (currentUser.Password == password) { LoggedInnMenu(); }
        else {LogInPage();}
    }
}