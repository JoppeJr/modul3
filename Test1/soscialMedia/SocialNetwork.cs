using System.Collections.Generic;

namespace soscialMedia
{
    public class SocialNetwork
    {
        private List<Profile> ListOfUsers { get; set; }

        public SocialNetwork()
        {
            ListOfUsers = new List<Profile>();
            ListOfUsers.Add(new Profile("Dani"));
            ListOfUsers.Add(new Profile("Odd Eirik"));
            ListOfUsers.Add(new Profile("Thomas"));
            ListOfUsers.Add(new Profile("Erik William"));
        }
    }
}